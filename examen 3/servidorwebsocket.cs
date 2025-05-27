using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Net;
using System.Threading;


namespace examen_3
{
    class servidorwebsocket
    {
        public async Task iniciar()
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:5000/ws/");
            listener.Start();
            Console.WriteLine("Servidor WebSocket escuchando en ws://localhost:5000/ws/");
            while (true)
            {
                var contexto = await listener.GetContextAsync();
                if (contexto.Request.IsWebSocketRequest)
                {
                    var vssocket = await contexto.AcceptWebSocketAsync(null);
                    WebSocket socket = vssocket.WebSocket;

                    byte[] buffer = new byte[1024];
                    //var result = await socket.ReceiveAsync(new ArraySegment<byte> (buffer),);
                }
                else
                {
                    contexto.Response.StatusCode = 400;
                    contexto.Response.Close();
                }
            }
        }
    }
}
