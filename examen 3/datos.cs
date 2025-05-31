using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.WebSockets;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using System.Windows.Forms;
namespace examen_3
{
    class datos
    {
        private string cadenaConexion;
        private SqlConnection conexion;

        public datos()
        {

            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"]?.ConnectionString;

            if (cadenaConexion == null)
            {
                MessageBox.Show("Error al obtener la cadena de conexión desde el archivo de configuración.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        // Cliente WebSocket para notificaciones
        private static ProductosWebSocketClient _webSocketClient;

        static datos()
        {
            // Inicializar el cliente WebSocket (cambia la IP si el servidor está en otra máquina)
            _webSocketClient = new ProductosWebSocketClient("ws://10.13.58.180:8090/");
            _ = Task.Run(async () => await _webSocketClient.ConnectAsync());
        }

        public static ProductosWebSocketClient WebSocketClient => _webSocketClient;
        private SqlConnection AbrirConexion()
        {
            conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        private void CerrarConexion()
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
        public bool EjecutarComando(string cmd)
        {
            try
            {
                // Notificar cambios a través de WebSocket después de ejecutar el comando
                _ = Task.Run(async () =>
                {
                    if (_webSocketClient?.IsConnected == true)
                    {
                        await _webSocketClient.NotifyDataChangedAsync();
                    }
                });
                SqlCommand comando = new SqlCommand(cmd, AbrirConexion());
                comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                // cerrarConexion();
            }
        }
        public DataSet comandoDS(string cmd)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter comando = new SqlDataAdapter(cmd, AbrirConexion());
                comando.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                // if (ds!= null)
                //    cerrarConexion();
            }
            //////////////}
        }
    }
}
