using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlClienteAapp
{
    public partial class Catalogo_Productos : Form
    {
        

        public Catalogo_Productos()
        {
            InitializeComponent();
        }
        private void agregarproducto(string _id)
        {
            Captura_Nuevo_Pedido _catalogo = Owner as Captura_Nuevo_Pedido;
            DataRow fila = _catalogo.tabla.NewRow();
            fila["ProductoID"] = MiSerializador.control.catalogo_productos[_id].id_product;
            fila["ProductoNombre"] = MiSerializador.control.catalogo_productos[_id].name_product;
            fila["ProductoDes"] = MiSerializador.control.catalogo_productos[_id].desc_product;
            fila["Precio"] = MiSerializador.control.catalogo_productos[_id].precio.ToString("0.00") ;
            fila["Index"] = _catalogo.index_productos;
            _catalogo.tabla.Rows.Add(fila);
            ProductoData _productodata = new ProductoData(MiSerializador.control.catalogo_productos[_id].id_product, MiSerializador.control.catalogo_productos[_id].name_product,
                MiSerializador.control.catalogo_productos[_id].desc_product, MiSerializador.control.catalogo_productos[_id].precio);
            


            _catalogo.productos_pedido_data.Add(_catalogo.index_productos, _productodata);
            _catalogo.index_productos++;

            _catalogo.actualizarcampos();
            this.Close();

        }
        private void Producto1Button_Click(object sender, EventArgs e)
        {

            agregarproducto("1");
        }
        private void Producto2Button_Click(object sender, EventArgs e)
        {
            agregarproducto("2");
        }

        private void Producto3Button_Click(object sender, EventArgs e)
        {
            agregarproducto("3");
        }

        private void Producto4Button_Click(object sender, EventArgs e)
        {
            agregarproducto("4");
        }

        private void Producto5Button_Click(object sender, EventArgs e)
        {
            agregarproducto("5");
        }

        private void Producto6Button_Click(object sender, EventArgs e)
        {
            agregarproducto("6");
        }

        private void Producto7Button_Click(object sender, EventArgs e)
        {
            agregarproducto("7");
        }

        private void Producto8Button_Click(object sender, EventArgs e)
        {
            agregarproducto("8");
        }
    }
}
