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
    public partial class AlmacenarProductos : Form
    {
        ManejadorProducto mp;
        public AlmacenarProductos()
        {
            InitializeComponent();
            mp = new ManejadorProducto();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p.ShowDialog();
        }

        public void Mostrar()
        {
            mp.MostrarRegistros(dtgvProductos, txtBuscar.Text);
        }

        int fila, columns, id;

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
