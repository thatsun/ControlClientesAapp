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
    public partial class ConsultarPedidos : Form
    {

        public string pedidoseleccionado="";
        DataTable tabla;
        public ConsultarPedidos()
        {
            InitializeComponent();
            InicializarActionButton();
            Iniciar();
        }
        void InicializarActionButton()
        {
            if (MiSerializador.control.peddio_modo_consulta != "Consultar")
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                MiDataGridView.Columns.Add(btn);
                
                if (MiSerializador.control.peddio_modo_consulta == "Editar")
                {
                    btn.Text = "Editar";
                }
                if (MiSerializador.control.peddio_modo_consulta == "Confirmar")
                {
                    btn.Text = "Confirmar";
                }
                if (MiSerializador.control.peddio_modo_consulta == "Produccion")
                {
                    btn.Text = "Produccion";
                }
                if (MiSerializador.control.peddio_modo_consulta == "Cancelar")
                {
                    btn.Text = "Cancelar";
                }
                btn.Name = "Accion";
                btn.UseColumnTextForButtonValue = true;
                
                
            }
        }
        void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("IdPedido");
            tabla.Columns.Add("Cliente");
            tabla.Columns.Add("Estado");
            tabla.Columns.Add("Fecha");
            tabla.Columns.Add("ImporteTotal");
            tabla.Columns.Add("ImportePagado");
            tabla.Columns.Add("RestaPagar");
            MiDataGridView.DataSource = tabla;

            MiDataGridView.Columns["ImporteTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            MiDataGridView.Columns["ImportePagado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            MiDataGridView.Columns["RestaPagar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void ConsultarPedidosBuscarPedidos()
        {
            Iniciar();
            foreach (KeyValuePair<string, PedidoData> Entry in MiSerializador.control.catalogo_pedido)
            {
                if ( Entry.Value.ClienteID.Contains(ClienteID_inputfield.Text) & ClienteID_inputfield.Text!="")
                {
                    validatestatus(Entry.Value.PedidoID,Entry.Value.ClienteID);

                }
                else
                {
                    if (MiSerializador.control.catalogo_clientes[Entry.Value.ClienteID].Nombre.ToLower().Contains(Nombre_inputfield.Text.ToLower()) & Nombre_inputfield.Text!="")
                    {
                        validatestatus(Entry.Value.PedidoID, Entry.Value.ClienteID);
                    }
                    else
                    {
                        if ( MiSerializador.control.catalogo_clientes[Entry.Value.ClienteID].Apellido.ToLower().Contains(Apellido_Inputfield.Text.ToLower()) & Apellido_Inputfield.Text!="")
                        {
                            validatestatus(Entry.Value.PedidoID, Entry.Value.ClienteID);
                        }

                    }

                }
            }
        }
        private void  validatestatus(string _pedido_ID, string _clienteID)
        {
            
            if (MiSerializador.control.catalogo_pedido[_pedido_ID].Estado=="pendiente" & IncluirPendiente.CheckState==CheckState.Checked)
            {
                filltable(_pedido_ID, _clienteID);
            }
            else
            {
                if (MiSerializador.control.catalogo_pedido[_pedido_ID].Estado == "confirmado" & IncluirConfirmado.CheckState == CheckState.Checked)
                {
                    filltable(_pedido_ID, _clienteID);
                }
                else
                {
                    if (MiSerializador.control.catalogo_pedido[_pedido_ID].Estado == "produccion" & IncluirProduccion.CheckState == CheckState.Checked)
                    {
                        filltable(_pedido_ID, _clienteID);
                    }
                    else
                    {
                        if (MiSerializador.control.catalogo_pedido[_pedido_ID].Estado == "cancelado" & IncluirCancelado.CheckState == CheckState.Checked)
                        {
                            filltable(_pedido_ID, _clienteID);
                        }
                    }
                    
                }
               
            }
            
            
        }
        private void filltable(string _pedido_ID,string _clienteID)
        {


            DataRow fila = tabla.NewRow();

            fila["IdPedido"] = MiSerializador.control.catalogo_pedido[_pedido_ID].PedidoID;
            fila["Cliente"] = MiSerializador.control.catalogo_clientes[_clienteID].Nombre + " " + MiSerializador.control.catalogo_clientes[_clienteID].Apellido;
            fila["Estado"] = MiSerializador.control.catalogo_pedido[_pedido_ID].Estado;
            fila["Fecha"] = MiSerializador.control.catalogo_pedido[_pedido_ID].FechaPedido[0].ToString() + "/" + MiSerializador.control.catalogo_pedido[_pedido_ID].FechaPedido[1].ToString() + "/" + MiSerializador.control.catalogo_pedido[_pedido_ID].FechaPedido[2].ToString();
            fila["ImporteTotal"] = MiSerializador.control.catalogo_pedido[_pedido_ID].Importetotal;
            fila["ImportePagado"] = MiSerializador.control.catalogo_pedido[_pedido_ID].Importepagado;
            fila["RestaPagar"] = MiSerializador.control.catalogo_pedido[_pedido_ID].Importetotal - MiSerializador.control.catalogo_pedido[_pedido_ID].Importepagado;
            tabla.Rows.Add(fila);




        }
        private void consultartodos()
        {
            Iniciar();
            foreach (KeyValuePair<string, PedidoData> Entry in MiSerializador.control.catalogo_pedido)
            {
                DataRow fila = tabla.NewRow();

                fila["IdPedido"] = MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].PedidoID;
                fila["Cliente"] = MiSerializador.control.catalogo_clientes[Entry.Value.ClienteID].Nombre + " " + MiSerializador.control.catalogo_clientes[Entry.Value.ClienteID].Apellido;
                fila["Estado"] = MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].Estado;
                fila["Fecha"] = MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].FechaPedido[0].ToString() + "/" + MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].FechaPedido[1].ToString() + "/" + MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].FechaPedido[2].ToString();
                fila["ImporteTotal"] = MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].Importetotal;
                fila["ImportePagado"] = MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].Importepagado;
                fila["RestaPagar"] = MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].Importetotal - MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].Importepagado;
                tabla.Rows.Add(fila);
            }

        }
        private void ConsultarPedidos_Load(object sender, EventArgs e)
        {
            if (MiSerializador.control.peddio_modo_consulta=="Consultar")
            {
                return;
            }

            
            if (MiSerializador.control.peddio_modo_consulta == "Editar")
            {
                IncluirPendiente.Visible = false;
                IncluirCancelado.Visible = false;
                IncluirConfirmado.Visible = false;
                IncluirProduccion.Visible = false;

                this.Text = "Buscar Pedidos para Editar";
                return;
            }
            if (MiSerializador.control.peddio_modo_consulta == "Confirmar")
            {
                IncluirPendiente.Visible = false;
                IncluirCancelado.Visible = false;
                IncluirConfirmado.Visible = false;
                IncluirProduccion.Visible = false;

                this.Text = "Buscar Pedidos para Confirmar";
                return;
            }
            if (MiSerializador.control.peddio_modo_consulta == "Produccion")
            {
                IncluirPendiente.Visible = false;
                IncluirCancelado.Visible = false;
                IncluirConfirmado.Visible = false;
                IncluirProduccion.Visible = false;

                IncluirPendiente.Checked = false;
                IncluirConfirmado.Checked = true;

                this.Text = "Buscar Pedidos para enviar a produccion";

                return;
            }
            if (MiSerializador.control.peddio_modo_consulta == "Cancelar")
            {
                IncluirPendiente.Visible = true;
                IncluirCancelado.Visible = false;
                IncluirConfirmado.Visible = true;
                IncluirProduccion.Visible = true;

                IncluirPendiente.Checked = true;
                IncluirConfirmado.Checked = true;
                IncluirProduccion.Checked = true;

                this.Text = "Buscar Pedidos para Cancelar";


                return;
            }

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            Limpiar();

        }
        void Limpiar()
        {
            Iniciar();
            ClienteID_inputfield.Text = "";
            Nombre_inputfield.Text = "";
            Apellido_Inputfield.Text = "";
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            ConsultarPedidosBuscarPedidos();
        }
        private void consultartodosEstado(string _estado_filtrado)
        {
            Iniciar();
            foreach (KeyValuePair<string, PedidoData> Entry in MiSerializador.control.catalogo_pedido)
            {
                if (MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].Estado==_estado_filtrado)
                {
                    DataRow fila = tabla.NewRow();

                    fila["IdPedido"] = MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].PedidoID;
                    fila["Cliente"] = MiSerializador.control.catalogo_clientes[Entry.Value.ClienteID].Nombre + " " + MiSerializador.control.catalogo_clientes[Entry.Value.ClienteID].Apellido;
                    fila["Estado"] = MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].Estado;
                    fila["Fecha"] = MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].FechaPedido[0].ToString() + "/" + MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].FechaPedido[1].ToString() + "/" + MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].FechaPedido[2].ToString();
                    fila["ImporteTotal"] = MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].Importetotal;
                    fila["ImportePagado"] = MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].Importepagado;
                    fila["RestaPagar"] = MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].Importetotal - MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].Importepagado;
                    tabla.Rows.Add(fila);
                }
                
            }

        }
        void consultartodosexcluirestado(string _excluir_estado)
        {
            Iniciar();
            foreach (KeyValuePair<string, PedidoData> Entry in MiSerializador.control.catalogo_pedido)
            {
                if (MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].Estado != _excluir_estado)
                {
                    DataRow fila = tabla.NewRow();

                    fila["IdPedido"] = MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].PedidoID;
                    fila["Cliente"] = MiSerializador.control.catalogo_clientes[Entry.Value.ClienteID].Nombre + " " + MiSerializador.control.catalogo_clientes[Entry.Value.ClienteID].Apellido;
                    fila["Estado"] = MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].Estado;
                    fila["Fecha"] = MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].FechaPedido[0].ToString() + "/" + MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].FechaPedido[1].ToString() + "/" + MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].FechaPedido[2].ToString();
                    fila["ImporteTotal"] = MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].Importetotal;
                    fila["ImportePagado"] = MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].Importepagado;
                    fila["RestaPagar"] = MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].Importetotal - MiSerializador.control.catalogo_pedido[Entry.Value.PedidoID].Importepagado;
                    tabla.Rows.Add(fila);
                }

            }

        }
        private void VreTodos_Button_Click(object sender, EventArgs e)
        {
            if (MiSerializador.control.peddio_modo_consulta=="Consultar")
            {
                consultartodos();
                return;
            }
            if (MiSerializador.control.peddio_modo_consulta == "Editar")
            {
                consultartodosEstado("pendiente");
            }
            if (MiSerializador.control.peddio_modo_consulta == "Confirmar")
            {
                consultartodosEstado("pendiente");
            }
            if (MiSerializador.control.peddio_modo_consulta == "Produccion")
            {
                consultartodosEstado("confirmado");
            }
            if (MiSerializador.control.peddio_modo_consulta == "Cancelar")
            {
                consultartodosexcluirestado("cancelado");
            }
        }
        public void Actualizarinformacion(string _id)
        {
            for (int i=0; i< tabla.Rows.Count;i++)
            {
                if (tabla.Rows[i]["IdPedido"].ToString()==_id)
                {
                    tabla.Rows[i]["Estado"] = MiSerializador.control.catalogo_pedido[_id].Estado;
                    tabla.Rows[i]["Fecha"] = MiSerializador.control.catalogo_pedido[_id].FechaPedido[0].ToString() + "/" + MiSerializador.control.catalogo_pedido[_id].FechaPedido[1].ToString() + "/" + MiSerializador.control.catalogo_pedido[_id].FechaPedido[2].ToString();
                    tabla.Rows[i]["ImporteTotal"] = MiSerializador.control.catalogo_pedido[_id].Importetotal;
                    tabla.Rows[i]["ImportePagado"] = MiSerializador.control.catalogo_pedido[_id].Importepagado;
                    tabla.Rows[i]["RestaPagar"] = MiSerializador.control.catalogo_pedido[_id].Importetotal - MiSerializador.control.catalogo_pedido[_id].Importepagado;
                }      
               
            }
;
        }
        private void MiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    pedidoseleccionado= Convert.ToString( tabla.Rows[e.RowIndex]["IdPedido"]);
                    DetallesPedido _pedido_detalles = new DetallesPedido();
                    AddOwnedForm(_pedido_detalles);
                    _pedido_detalles.ShowDialog();

                }
                if (MiSerializador.control.peddio_modo_consulta!="Consultar")
                {
                    if (e.ColumnIndex == 1)
                    {

                        pedidoseleccionado = Convert.ToString(tabla.Rows[e.RowIndex]["IdPedido"]);
                        MiSerializador.control.id_pedidoseleccionado = pedidoseleccionado;
                        MiSerializador.control.id_seleccionado = MiSerializador.control.catalogo_pedido[pedidoseleccionado].ClienteID;
                        if (MiSerializador.control.peddio_modo_consulta=="Editar")
                        {
                            MiSerializador.control.pedido_modocaptura = "Editar";
                            

                            Captura_Nuevo_Pedido _capturar_pedido = new Captura_Nuevo_Pedido();
                            this.AddOwnedForm(_capturar_pedido);
                            _capturar_pedido.ShowDialog();
                        }
                        if (MiSerializador.control.peddio_modo_consulta=="Confirmar")
                        {
                            const string message = "Desea confirmar el pedido?";
                            const string caption = "Confirmar";
                            var _mesagebox = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            // If the no button was pressed ...
                            if (_mesagebox == DialogResult.Yes)
                            {
                                MiSerializador.control.catalogo_pedido[pedidoseleccionado].Estado = "confirmado";
                                MiSerializador.control.SaveAppdata();

                                MessageBox.Show("Pedido Confirmado");
                                tabla.Rows.RemoveAt(e.RowIndex);
                            }
                        }
                        if (MiSerializador.control.peddio_modo_consulta == "Produccion")
                        {
                            const string message = "Desea enviar a producion el pedido?";
                            const string caption = "Enviar a Produccion";
                            var _mesagebox = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            // If the no button was pressed ...
                            if (_mesagebox == DialogResult.Yes)
                            {
                                MiSerializador.control.catalogo_pedido[pedidoseleccionado].Estado = "produccion";
                                MiSerializador.control.SaveAppdata();

                                MessageBox.Show("Pedido enviado a produccion");
                                tabla.Rows.RemoveAt(e.RowIndex);
                            }
                        }
                        if (MiSerializador.control.peddio_modo_consulta == "Cancelar")
                        {
                            const string message = "Desea cancelar el pedido?";
                            const string caption = "Cancelar pedido";
                            var _mesagebox = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            // If the no button was pressed ...
                            if (_mesagebox == DialogResult.Yes)
                            {
                                MiSerializador.control.catalogo_pedido[pedidoseleccionado].Estado = "cancelado";
                                MiSerializador.control.SaveAppdata();

                                MessageBox.Show("Pedido cancelado");
                                tabla.Rows.RemoveAt(e.RowIndex);
                            }
                        }

                    }
                }
                

            }
        }
    }
}
