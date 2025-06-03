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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private async void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
        }

        private void imprimirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimirarchivo imprimirarchivo = new Imprimirarchivo();
            imprimirarchivo.Show();
        }

    }
}
