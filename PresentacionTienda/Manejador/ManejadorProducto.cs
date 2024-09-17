using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejador
{
    public class ManejadorProducto
    {
        Base b = new Base("localhost", "root", "", "presentaciontienda");

        public void MostrarRegistros(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar($"SELECT * FROM productos WHERE idP LIKE '%{filtro}%'", "productos").Tables[0];
            tabla.Columns.Insert(4, Boton("Eliminar", Color.Red));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        DataGridViewButtonColumn Boton(string t, Color fondo)
        {
            DataGridViewButtonColumn b = new DataGridViewButtonColumn();
            b.Text = t;
            b.UseColumnTextForButtonValue = true;
            b.FlatStyle = FlatStyle.Flat;
            b.DefaultCellStyle.BackColor = fondo;
            b.DefaultCellStyle.ForeColor = Color.White;
            return b;
        }

        public void InsertarProductos(string codigo, string nombre, string descrpcion, string precio)
        {
            b.Comando($"INSERT INTO productos VALUES (NULL, '{nombre}', '{descrpcion}', {double.Parse(precio)});");
        }

        public void Borrar(int id)
        {
            DialogResult rs = MessageBox.Show("¿Está seguro de borrar el producto?", "Atencion!", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                b.Comando($"delete from productos where idP = {id}");
                DialogResult rs2 = MessageBox.Show("Registro Eliminado!!", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
