using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlClienteAapp
{
    
    public partial class DetalleProducto : Form
    {
        int productoseleccionado = 0;
        public DetalleProducto()
        {
            InitializeComponent();
        }
        void Iniciar()
        {
            ProductoIndex_display.Text = productoseleccionado.ToString();
        }
        private void DetalleProducto_Load(object sender, EventArgs e)
        {
            DetallesPedido _detalles_pedido = Owner as DetallesPedido;
            productoseleccionado = _detalles_pedido.productoseleccionado;
            Iniciar();
        }
    }
}
