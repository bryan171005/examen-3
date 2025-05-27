using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Net;
using System.Threading;
using System.Configuration;
using Fleck;
using System.Windows.Forms;


namespace examen_3
{   
class servidorwebsocket
    {



        private WebSocketServer servidor = new WebSocketServer("ws://0.0.0.0:8181");

        public void iniciar()
        {
            servidor.Start(socket =>
            {
                socket.OnOpen =() =>
                {
                    MessageBox.Show("Cliente conectado: " + socket.ConnectionInfo.ClientIpAddress, "Conexión WebSocket", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
                socket.OnClose =() =>
                {
                    MessageBox.Show("Cliente desconectado: " + socket.ConnectionInfo.ClientIpAddress, "Desconexión WebSocket", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
                socket.OnMessage =message =>
                {
                    MessageBox.Show("Mensaje recibido: " + message, "Mensaje WebSocket", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    socket.Send("Mensaje recibido: " + message);
                };
            });
        }
    }
}
