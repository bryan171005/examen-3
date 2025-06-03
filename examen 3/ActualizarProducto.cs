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
    public partial class ActualizarProducto: Form
    {
        datos dt = new datos();
        public ActualizarProducto(string id,string nombre,string descripcion,string precio,string cantidad,string fecha)
        {
            InitializeComponent();
            txtid.Text = id;
            textnombre.Text = nombre;
            textdescripcion.Text = descripcion;
            textprecio.Text = precio;
            textcantidad.Text = cantidad;
            textfecha.Text = fecha;



        }

        private void ActualizarProducto_Load(object sender, EventArgs e)
        {
            txtid.Enabled = true;
            txtid.ReadOnly = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Producto SET " +
    "Nombre = '" + textnombre.Text + "', " +
    "Descripcion = '" + textdescripcion.Text + "', " +
    "Precio = '" + textprecio.Text + "', " +
    "Stock = " + textcantidad.Text + ", " +
    "FechaRegistro = '" +textfecha.Text + "' " +
    "WHERE Id = " + txtid.Text;

            if (dt.EjecutarComando(sql))
            {
                MessageBox.Show("Producto actualizado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar el producto");
            }

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Deseas eliminar este producto?", "Sistema", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string id = txtid.Text;
                datos dtos = new datos(); // Tu clase de conexión

                // Confirmación final
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este producto?",
                                                      "Confirmar Eliminación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    bool eliminado = dtos.EjecutarComando("DELETE FROM Producto WHERE Id = " + id);

                    if (eliminado)
                    {
                        // Opción: Resetear IDENTITY (si tabla está vacía)
                        dtos.EjecutarComando("DBCC CHECKIDENT ('Productos', RESEED, 0);");

                        MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el producto. Verifica el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
