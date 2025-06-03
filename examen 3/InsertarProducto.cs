using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_3
{
    public partial class InsertarProducto: Form
    {
        datos dt = new datos();
        public InsertarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Insertar nuevo producto
            string sql = "INSERT INTO Producto (Nombre, Descripcion, Precio, Stock, FechaRegistro) " +
                         "VALUES ('" + textnombre.Text + "', " +
                         "'" + textdescripcion.Text + "', " +
                         "'" + textprecio.Text + "', " +
                         textcantidad.Text + ", " +
                         "'" + textfecha.Text+ "')";

            if (dt.EjecutarComando(sql))
            {
                MessageBox.Show("Producto agregado correctamente");
            }
            else
            {
                MessageBox.Show("Error al agregar el producto");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertarProducto ip = new InsertarProducto();
            ip.Close();
        }
    }
}
