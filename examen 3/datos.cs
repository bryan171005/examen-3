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
namespace examen_3
{
    class datos
    {
        string cadenaConexion;

        public datos(string cadenaConexion)
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["Miconexion"].ConnectionString;
        }

        private SqlConnection abrirConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        private void cerrarConexion()
        {
            try
            {
                
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

        }
        public bool EjecutarComando(string cmd)
        {
            try
            {
                SqlCommand comando = new SqlCommand(cmd, abrirConexion());
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
                SqlDataAdapter comando = new SqlDataAdapter(cmd, abrirConexion());
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
        }
    }
}
