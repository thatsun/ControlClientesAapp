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
    public partial class ConsultarPagos : Form
    {
        DataTable tabla;
        public ConsultarPagos()
        {
            InitializeComponent();
        }
        void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("IdPedido");
            tabla.Columns.Add("Cliente");
            tabla.Columns.Add("Estado");
            tabla.Columns.Add("FechaLimitePago");
            tabla.Columns.Add("Monto");
            
            MiDataGridView.DataSource = tabla;

            MiDataGridView.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
           
        }
        void ConsultarporBusqueda()
        {
            Iniciar();
            foreach (KeyValuePair<string, PedidoData> Entry in MiSerializador.control.catalogo_pedido)
            {
                if (Entry.Value.ClienteID.Contains(ClienteID_inputfield.Text) & ClienteID_inputfield.Text != "")
                {
                    foreach (KeyValuePair<string,AbonoData> Item in Entry.Value.pedido_abonos)
                    {
                        validatestatus(Item.Value.AbonoID, Item.Value.PedidoID, Entry.Value.ClienteID);
                    }
                    

                }
                else
                {
                    if (MiSerializador.control.catalogo_clientes[Entry.Value.ClienteID].Nombre.ToLower().Contains(Nombre_inputfield.Text.ToLower()) & Nombre_inputfield.Text != "")
                    {
                        foreach (KeyValuePair<string, AbonoData> Item in Entry.Value.pedido_abonos)
                        {
                            validatestatus(Item.Value.AbonoID, Item.Value.PedidoID, Entry.Value.ClienteID);
                        }
                    }
                    else
                    {
                        if (MiSerializador.control.catalogo_clientes[Entry.Value.ClienteID].Apellido.ToLower().Contains(Apellido_Inputfield.Text.ToLower()) & Apellido_Inputfield.Text != "")
                        {
                            foreach (KeyValuePair<string, AbonoData> Item in Entry.Value.pedido_abonos)
                            {
                                validatestatus(Item.Value.AbonoID, Item.Value.PedidoID, Entry.Value.ClienteID);
                            }
                        }

                    }

                }
            }
        }
        void validatestatus(string _abonoID, string _pedidoID, string _clienteID)
        {
            if (MiSerializador.control.catalogo_pedido[_pedidoID].pedido_abonos[_abonoID].Estado == "pendiente" & PendienteCheckBox.CheckState == CheckState.Checked)
            {
                filltable(_pedidoID, _abonoID, _clienteID);
            }
            else
            {
                if (MiSerializador.control.catalogo_pedido[_pedidoID].pedido_abonos[_abonoID].Estado == "vigente" & VigentesCheckBox.CheckState == CheckState.Checked)
                {
                    filltable(_pedidoID, _abonoID, _clienteID);
                }
                else
                {
                    if (MiSerializador.control.catalogo_pedido[_pedidoID].pedido_abonos[_abonoID].Estado == "pagado" & PagadosCheckBox.CheckState == CheckState.Checked)
                    {
                        filltable(_pedidoID, _abonoID, _clienteID);
                    }
                    else
                    {
                        if (MiSerializador.control.catalogo_pedido[_pedidoID].pedido_abonos[_abonoID].Estado == "vencido" & VencidosCheckBox.CheckState == CheckState.Checked)
                        {
                            filltable(_pedidoID, _abonoID, _clienteID);
                        }
                    }

                }

            }
        }
        void filltable(string _pedidoID, string _abonoID ,string _clienteID)
        {
            DataRow fila = tabla.NewRow();

            fila["IdPedido"] = MiSerializador.control.catalogo_pedido[_pedidoID].PedidoID;
            fila["Cliente"] = MiSerializador.control.catalogo_clientes[_clienteID].Nombre + " " + MiSerializador.control.catalogo_clientes[_clienteID].Apellido;
            fila["Estado"] = MiSerializador.control.catalogo_pedido[_pedidoID].pedido_abonos[_abonoID].Estado;
            fila["FechaLimitePago"] = MiSerializador.control.catalogo_pedido[_pedidoID].pedido_abonos[_abonoID].Fecha_de_pago[0].ToString() + "/" + MiSerializador.control.catalogo_pedido[_pedidoID].pedido_abonos[_abonoID].Fecha_de_pago[1].ToString() + "/" + MiSerializador.control.catalogo_pedido[_pedidoID].pedido_abonos[_abonoID].Fecha_de_pago[2].ToString();
            fila["Monto"] = MiSerializador.control.catalogo_pedido[_pedidoID].pedido_abonos[_abonoID].Importe.ToString();
            
            
            tabla.Rows.Add(fila);
        }
        private void ConsultarPagos_Load(object sender, EventArgs e)
        {

        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            ConsultarporBusqueda();
        }

    }
}
