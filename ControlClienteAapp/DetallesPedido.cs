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
    public partial class DetallesPedido : Form
    {
        
        public int  productoseleccionado = 0;
        public DataTable tabla;
        public DetallesPedido()
        {
            InitializeComponent();
            
            
        }
        void Iniciar()
        {

            tabla = new DataTable();
            tabla.Columns.Add("ProductoID");
            tabla.Columns.Add("ProductoNombre");
            tabla.Columns.Add("ProductoDes");
            tabla.Columns.Add("Precio");
            tabla.Columns.Add("Index");


            MyData_gridview.DataSource = tabla;
            MyData_gridview.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
        }
        private void Mostrardatos(string _idpedido)
        {
            Idpedido_display.Text = _idpedido;
            ImporteTotal_display.Text = MiSerializador.control.catalogo_pedido[_idpedido].Importetotal.ToString();
            Estado_display.Text = MiSerializador.control.catalogo_pedido[_idpedido].Estado;
            Anticipo_display.Text = MiSerializador.control.catalogo_pedido[_idpedido].ImporteAnticipo.ToString();
            if (MiSerializador.control.catalogo_pedido[_idpedido].EnPagos==true)
            {
                Cant_abonos_display.Text = MiSerializador.control.catalogo_pedido[_idpedido].CantidadPagos.ToString();
                Abono_inicial_display.Text = MiSerializador.control.catalogo_pedido[_idpedido].pedido_abonos["1"].Importe.ToString();
                Monto_abono_display.Text = MiSerializador.control.catalogo_pedido[_idpedido].pedido_abonos["2"].Importe.ToString();

                Resta_pagar_display.Text =(MiSerializador.control.catalogo_pedido[_idpedido].Importetotal - MiSerializador.control.catalogo_pedido[_idpedido].Importepagado).ToString();
                Total_pagado_display.Text = MiSerializador.control.catalogo_pedido[_idpedido].Importepagado.ToString();

            }
            else
            {
                Total_pagado_display.Text = MiSerializador.control.catalogo_pedido[_idpedido].Importepagado.ToString();
            }
            foreach (KeyValuePair<int, ProductoData> Entry in MiSerializador.control.catalogo_pedido[_idpedido].pedido_productos)
            {
                DataRow fila = tabla.NewRow();

                fila["ProductoID"] = Entry.Value.id_product;
                fila["ProductoNombre"] = Entry.Value.name_product;
                fila["ProductoDes"] = Entry.Value.desc_product;
                fila["Precio"] = Entry.Value.precio.ToString();
                fila["Index"] = Entry.Key.ToString();
                tabla.Rows.Add(fila);
            }
        }
        private void MyData_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //detalleproducto
            if (e.RowIndex>=0)
            {
                if (e.ColumnIndex==0)
                {
                    productoseleccionado = Convert.ToInt32( tabla.Rows[e.RowIndex]["Index"]);
                    DetalleProducto _detalleproducto = new DetalleProducto();
                    AddOwnedForm(_detalleproducto);
                    _detalleproducto.ShowDialog();
                }
            }
            
        }

        private void DetallesPedido_Load(object sender, EventArgs e)
        {
            ConsultarPedidos _consultas = Owner as ConsultarPedidos;

            Idpedido_display.Text  = _consultas.pedidoseleccionado.ToString();
            Iniciar();
            Mostrardatos( _consultas.pedidoseleccionado);
        }
    }
}
