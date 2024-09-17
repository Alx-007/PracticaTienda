using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;

namespace PresentacionTienda
{
    public partial class Productos : Form
    {
        ManejadorProducto mp;
        public Productos()
        {
            InitializeComponent();
            mp = new ManejadorProducto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlmacenarProductos p = new AlmacenarProductos();
            p.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mp.InsertarProductos(txtNombre.Text, txtDescripcion.Text, txtPrecio.Text);
            MessageBox.Show("Producto Insertado!");
            this.Close();
        }
    }
}
