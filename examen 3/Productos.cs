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
    public partial class Productos: Form
    {
        datos dt = new datos();
        public Productos()
        {
            InitializeComponent();
        }
        private void Actualizar()
        {
            DataSet ds;
            ds = dt.comandoDS("SELECT Id AS [ID Producto], " +
                              "Nombre, Descripcion, Precio, Cantidad, FechaRegistro " +
                              "FROM Productos");
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarProducto actualiza = new ActualizarProducto(
                dataGridView1[0, e.RowIndex].Value.ToString(), // Id
                dataGridView1[1, e.RowIndex].Value.ToString(), // Nombre
                dataGridView1[2, e.RowIndex].Value.ToString(), // Descripcion
                dataGridView1[3, e.RowIndex].Value.ToString(), // Precio
                dataGridView1[4, e.RowIndex].Value.ToString(), // Cantidad
                dataGridView1[5, e.RowIndex].Value.ToString()  // FechaRegistro
            );
            actualiza.Show();
        }


        private void Productos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
        private void frmProductos_Activated(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            DataSet ds;
            ds = dt.comandoDS("SELECT Id AS [ID Producto], " +
                              "Nombre, Descripcion, Precio, Cantidad, FechaRegistro " +
                              "FROM Productos " +
                              "WHERE Nombre LIKE '" + textBox1.Text + "%'");
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarProducto insertarProducto = new InsertarProducto();
            insertarProducto.ShowDialog();
        }
    }
}
