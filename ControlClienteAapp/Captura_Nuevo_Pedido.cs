using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlClienteAapp
{
    public partial class Captura_Nuevo_Pedido : Form
    {
        public int index_productos=0;
        public DataTable tabla;

        public decimal C_importeTotal = 0;
        public decimal C_Resta_pagar = 0;
        public int C_Cantidda_abonos = 12;
        public decimal C_montoabono = 0;
        public decimal C_abono_inicial = 0;

        public decimal C_anticipo=1;
        public decimal C_importe_pagado=0;

        int _int_resta = 0;
        int _int_abono = 0;

        public Dictionary<int,ProductoData> productos_pedido_data = new Dictionary<int,ProductoData>();
        
        void Calcularabonos(decimal _restapagar)
        {
            _restapagar = Math.Floor(_restapagar);
            _int_resta = Convert.ToInt32(_restapagar);
            _int_abono = _int_resta / (C_Cantidda_abonos);

            C_montoabono = Convert.ToDecimal(_int_abono);
            C_abono_inicial = _restapagar-Convert.ToDecimal(_int_abono*(C_Cantidda_abonos-1));
        }
        public Captura_Nuevo_Pedido()
        {
            InitializeComponent();
            Iniciar();
            if (MiSerializador.control.pedido_modocaptura=="Editar")
            {
                
                Cargarproductos_cliente(MiSerializador.control.id_pedidoseleccionado);
                Cargarpedidodata(MiSerializador.control.id_pedidoseleccionado);
                actualizarcampos();
            }
           
        }
        public void actualizarcampos()
        {
            C_importeTotal = 0;
            if (tabla.Rows.Count!=0)
            {
                for (int i =0; i< tabla.Rows.Count;i++)
                {
                    C_importeTotal = C_importeTotal+Convert.ToDecimal(tabla.Rows[i]["Precio"]);
                }
            }
            else{
                Credito.CheckState = CheckState.Unchecked;
                TotalRestaPagar.Text = "";
                MontoAbono.Text = "";
                Ultimo_Abono_display.Text = "";
                Anticipo.Text = "1";
                
            }
            

            if (Credito.CheckState==CheckState.Checked)
            {
                
                C_Resta_pagar = C_importeTotal- C_importe_pagado;
                        
                             
                
                
                Calcularabonos(C_importeTotal-C_anticipo);



                TotalRestaPagar.Text = C_Resta_pagar.ToString();
                MontoAbono.Text = C_montoabono.ToString();
                Ultimo_Abono_display.Text = C_abono_inicial.ToString();

            }
            else
            {
                TotalRestaPagar.Text = "";
                MontoAbono.Text = "";
                Ultimo_Abono_display.Text = "";
                Anticipo.Text="1";
            }
            

            
            ImporteTotal.Text = C_importeTotal.ToString();
        }
        void Cargarpedidodata(string _idpedido)
        {
            if (MiSerializador.control.catalogo_pedido[_idpedido].EnPagos==true)
            {
                
                
                Credito.CheckState = CheckState.Checked;
            }
            
            
            if (Credito.CheckState==CheckState.Checked)
            {
                C_Cantidda_abonos = MiSerializador.control.catalogo_pedido[_idpedido].CantidadPagos;
                C_anticipo = MiSerializador.control.catalogo_pedido[_idpedido].ImporteAnticipo;
                Anticipo.Text = C_anticipo.ToString();
                Abonos.Value = C_Cantidda_abonos;
            }
            C_importe_pagado= MiSerializador.control.catalogo_pedido[_idpedido].Importepagado;

        }
        void Cargarproductos_cliente(string _idpedido)
        {
             
            foreach (KeyValuePair<int,ProductoData> Entry in MiSerializador.control.catalogo_pedido[_idpedido].pedido_productos)
            {
                

                MemoryStream memory_stream = new MemoryStream();
                
                // Serialize the object into the memory stream.
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(memory_stream, Entry.Value);

                // Rewind the stream and use it to create a new object.
                memory_stream.Position = 0;
                ProductoData _pdata=(ProductoData)formatter.Deserialize(memory_stream);
                

                productos_pedido_data.Add(Entry.Key, _pdata);
                DataRow fila = tabla.NewRow();
                fila["ProductoID"] = Entry.Value.id_product;
                fila["ProductoNombre"] = Entry.Value.name_product;
                fila["ProductoDes"] = Entry.Value.desc_product;
                fila["Precio"] = Entry.Value.precio.ToString("0.00");
                fila["Index"] = Entry.Key.ToString();

                if(index_productos == Entry.Key)
                {
                    index_productos++;
                }
                tabla.Rows.Add(fila);
            }
            
        }
        private void Iniciar()
        {
            ImporteTotal.Text = C_importeTotal.ToString();
            idcliente_display.Text = MiSerializador.control.id_seleccionado;
            name_display.Text = MiSerializador.control.catalogo_clientes[MiSerializador.control.id_seleccionado].Nombre+" "+ MiSerializador.control.catalogo_clientes[MiSerializador.control.id_seleccionado].Apellido;
            dateTimePicker1.Value = System.DateTime.Now;

            tabla = new DataTable();
            tabla.Columns.Add("ProductoID");
            tabla.Columns.Add("ProductoNombre");
            tabla.Columns.Add("ProductoDes");
            tabla.Columns.Add("Precio");
            tabla.Columns.Add("Index");

            
            MyData_gridview.DataSource = tabla;
            MyData_gridview.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            

           
        }
        private void Captura_Nuevo_Pedido_Load(object sender, EventArgs e)
        {
            if (MiSerializador.control.pedido_modocaptura=="Editar")
            {
                this.Text = "Editar pedido";
            }
        }
        private void PN_obtenerdatos_producto(object sender, EventArgs e)
        {
            
        }
        private void Catalogo_Button_Click(object sender, EventArgs e)
        {
            Catalogo_Productos _producto_catalago = new Catalogo_Productos();
            AddOwnedForm(_producto_catalago);
            _producto_catalago.ShowDialog();
        }

        private void Credito_check_changed(object sender, EventArgs e)
        {
            if (Credito.CheckState==CheckState.Checked)
            {
                Anticipo.ReadOnly = false;
            }
            else
            {
                Anticipo.ReadOnly = true;
            }
            actualizarcampos();
        }

        private void C_abono_changed(object sender, EventArgs e)
        {
            C_Cantidda_abonos = Convert.ToInt32( Abonos.Value);
            actualizarcampos();
        }

        private void Anticipo_changed(object sender, EventArgs e)
        {
            
        }

        private void C_validadoanticipo(object sender, EventArgs e)
        {
            if (Anticipo.Text=="")
            {
                C_anticipo = 1;
                Anticipo.Text = "1";
                return;
            }
            if (Int32.TryParse(Anticipo.Text, out int _ant))
            {
                C_anticipo =Convert.ToDecimal( _ant);
            }
            else
            {
                
                MessageBox.Show("El monto minimo es 1");
                Anticipo.Text = "1";
            }
            actualizarcampos();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void PN_captura_guardar_Click(object sender, EventArgs e)
        {
            if (tabla.Rows.Count > 0)
            {
                if (MiSerializador.control.pedido_modocaptura == "Editar")
                {
                    MiSerializador.control.catalogo_pedido[MiSerializador.control.id_pedidoseleccionado].ImporteAnticipo = C_anticipo;
                    MiSerializador.control.catalogo_pedido[MiSerializador.control.id_pedidoseleccionado].Importepagado = 0;
                    MiSerializador.control.catalogo_pedido[MiSerializador.control.id_pedidoseleccionado].EnPagos= Credito.CheckState == CheckState.Checked;
                    MiSerializador.control.catalogo_pedido[MiSerializador.control.id_pedidoseleccionado].Importetotal = C_importeTotal;

                    MiSerializador.control.catalogo_pedido[MiSerializador.control.id_pedidoseleccionado].CantidadPagos = C_Cantidda_abonos;

                    MiSerializador.control.catalogo_pedido[MiSerializador.control.id_pedidoseleccionado].pedido_productos= productos_pedido_data;
                    MiSerializador.control.catalogo_pedido[MiSerializador.control.id_pedidoseleccionado].pedido_abonos = new Dictionary<string, AbonoData>();
                    if ( MiSerializador.control.catalogo_pedido[MiSerializador.control.id_pedidoseleccionado].EnPagos == true)
                    {

                        
                        for (int i = 1; i < C_Cantidda_abonos + 1; i++)
                        {
                            AbonoData _abono = new AbonoData();

                            _abono.PedidoID = MiSerializador.control.id_pedidoseleccionado;
                            if (i == 1)
                            {
                                _abono.Importe = C_abono_inicial;
                            }
                            else
                            {
                                _abono.Importe = C_montoabono;
                            }


                            MiSerializador.control.catalogo_pedido[MiSerializador.control.id_pedidoseleccionado].pedido_abonos.Add(i.ToString(), _abono);

                        }
                    }
                    MiSerializador.control.SaveAppdata();
                    ConsultarPedidos cp = Owner as ConsultarPedidos;

                    cp.Actualizarinformacion(MiSerializador.control.id_pedidoseleccionado);

                    MessageBox.Show("Cambios Aplicados");
                    this.Close();
                }
                else
                {
                    PedidoData _new_pedido = new PedidoData();
                    MiSerializador.control.id_pedido_autoincremmentado++;
                    _new_pedido.ClienteID = MiSerializador.control.id_seleccionado;
                    _new_pedido.PedidoID = MiSerializador.control.id_seleccionado + MiSerializador.control.id_pedido_autoincremmentado.ToString();
                    _new_pedido.EnPagos = Credito.CheckState == CheckState.Checked;
                    _new_pedido.Importetotal = C_importeTotal;


                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {

                        _new_pedido.pedido_productos.Add(Convert.ToInt32(tabla.Rows[i]["Index"]), productos_pedido_data[i]);

                    }
                    if (_new_pedido.EnPagos == true)
                    {
                        
                        _new_pedido.ImporteAnticipo = C_anticipo;
                        _new_pedido.Importepagado = 0;
                        _new_pedido.CantidadPagos = C_Cantidda_abonos;
                        for (int i = 1; i < C_Cantidda_abonos + 1; i++)
                        {
                            AbonoData _abono = new AbonoData();

                            _abono.PedidoID = _new_pedido.PedidoID;
                            if (i == 1)
                            {
                                _abono.Importe = C_abono_inicial;
                            }
                            else
                            {
                                _abono.Importe = C_montoabono;
                            }


                            _new_pedido.pedido_abonos.Add(i.ToString(), _abono);

                        }
                    }
                    else
                    {
                        _new_pedido.Importepagado = C_importeTotal;
                    }

                    MiSerializador.control.catalogo_pedido.Add(_new_pedido.PedidoID, _new_pedido);
                    MiSerializador.control.SaveAppdata();
                    MessageBox.Show("Pedido Guardado");
                    this.Close();
                }
                
            }
        }

        private void CP_gridview_Contentclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    //remove
                    productos_pedido_data.Remove(Convert.ToInt32( tabla.Rows[e.RowIndex]["Index"]));
                    tabla.Rows.RemoveAt(e.RowIndex);

                    actualizarcampos();

                }
                else
                {
                    if (e.ColumnIndex ==1)
                    {
                        EditarProducto _producto_editar = new EditarProducto();
                        AddOwnedForm(_producto_editar);
                        _producto_editar.ShowDialog();
                    }
                }
            }
        }

        private void MyData_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
