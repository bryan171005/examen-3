using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace examen_3
{
    public class WebSocketMessage
    {
        public string Type { get; set; }
        public string Data { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class ProductosWebSocketClient
    {
        private ClientWebSocket _webSocket;
        private CancellationTokenSource _cancellationTokenSource;
        private readonly string _serverUrl;

        public event Action OnDataChanged;

        public ProductosWebSocketClient(string serverUrl)
        {
            _serverUrl = serverUrl;
        }

        public async Task ConnectAsync()
        {
            try
            {
                _webSocket = new ClientWebSocket();
                _cancellationTokenSource = new CancellationTokenSource();

                await _webSocket.ConnectAsync(new Uri(_serverUrl), _cancellationTokenSource.Token);

                // Iniciar escucha de mensajes en un hilo separado
                _ = Task.Run(ListenForMessagesAsync);

                Console.WriteLine("Conectado al servidor WebSocket");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error conectando al WebSocket: {ex.Message}");
            }
        }

        private async Task ListenForMessagesAsync()
        {
            var buffer = new byte[4096];

            while (_webSocket.State == WebSocketState.Open && !_cancellationTokenSource.Token.IsCancellationRequested)
            {
                try
                {
                    var result = await _webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), _cancellationTokenSource.Token);

                    if (result.MessageType == WebSocketMessageType.Text)
                    {
                        var message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                        var wsMessage = JsonConvert.DeserializeObject<WebSocketMessage>(message);

                        if (wsMessage.Type == "DATA_CHANGED")
                        {
                            // Invocar el evento en el hilo de la UI
                            if (OnDataChanged != null)
                            {
                                // Usar Control.Invoke para ejecutar en el hilo de la UI
                                await Task.Run(() => OnDataChanged?.Invoke());
                            }
                        }
                    }
                }
                catch (WebSocketException)
                {
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error recibiendo mensaje: {ex.Message}");
                }
            }
        }

        public async Task NotifyDataChangedAsync()
        {
            if (_webSocket?.State == WebSocketState.Open)
            {
                try
                {
                    var message = new WebSocketMessage
                    {
                        Type = "DATA_CHANGED",
                        Data = "productos",
                        Timestamp = DateTime.Now
                    };

                    var json = JsonConvert.SerializeObject(message);
                    var bytes = Encoding.UTF8.GetBytes(json);

                    await _webSocket.SendAsync(
                        new ArraySegment<byte>(bytes),
                        WebSocketMessageType.Text,
                        true,
                        _cancellationTokenSource.Token
                    );
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error enviando notificación: {ex.Message}");
                }
            }
        }

        public async Task DisconnectAsync()
        {
            try
            {
                if (_webSocket?.State == WebSocketState.Open)
                {
                    await _webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
                }

                _cancellationTokenSource?.Cancel();
                _webSocket?.Dispose();
                _cancellationTokenSource?.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error desconectando: {ex.Message}");
            }
        }

        public bool IsConnected => _webSocket?.State == WebSocketState.Open;
    }
}