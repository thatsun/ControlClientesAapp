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
    

    public partial class ClientesBajas : Form
    {
        DataTable tabla;
        string idseleccionado = "";

        public ClientesBajas()
        {
            InitializeComponent();
            Iniciar();
        }
        void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Seleccionar");
            tabla.Columns.Add("ClientId");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            BC_dataGridView.DataSource = tabla;

            
        }
        private void ConsultarClientes()
        {
            foreach (KeyValuePair<string, ClienteData> Entry in MiSerializador.control.catalogo_clientes)
            {
                if (Entry.Value.ClienteID.Contains(BC_id_inputfield.Text) & BC_id_inputfield.Text != "")
                {
                    DataRow fila = tabla.NewRow();
                    fila["Seleccionar"] = false;
                    fila["ClientId"] = Entry.Value.ClienteID;
                    fila["Nombre"] = Entry.Value.Nombre;
                    fila["Apellido"] = Entry.Value.Apellido;
                    tabla.Rows.Add(fila);

                }
                else
                {
                    if (MiSerializador.control.catalogo_clientes[Entry.Value.ClienteID].Nombre.ToLower().Contains(BC_name_inputfield.Text.ToLower()) & BC_name_inputfield.Text != "")
                    {
                        DataRow fila = tabla.NewRow();
                        fila["Seleccionar"] = false;
                        fila["ClientId"] = Entry.Value.ClienteID;
                        fila["Nombre"] = Entry.Value.Nombre;
                        fila["Apellido"] = Entry.Value.Apellido;
                        tabla.Rows.Add(fila);
                    }
                    else
                    {
                        if (MiSerializador.control.catalogo_clientes[Entry.Value.ClienteID].Apellido.ToLower().Contains(BC_apellido_inputfield.Text.ToLower()) & BC_apellido_inputfield.Text != "")
                        {
                            DataRow fila = tabla.NewRow();
                            fila["Seleccionar"] = false;
                            fila["ClientId"] = Entry.Value.ClienteID;
                            fila["Nombre"] = Entry.Value.Nombre;
                            fila["Apellido"] = Entry.Value.Apellido;
                            tabla.Rows.Add(fila);
                        }

                    }

                }
            }
            
        }
        private void Limpiar()
        {
            BC_id_inputfield.Text = "";
            BC_name_inputfield.Text = "";
            BC_apellido_inputfield.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BC_buscar_button_Click(object sender, EventArgs e)
        {
            BC_borrar_button.Enabled = false;
            Iniciar();
            ConsultarClientes();
        }

        private void BC_borrar_button_Click(object sender, EventArgs e)
        {
            
            BC_borrar_button.Enabled = false;
            ///borra algo
            ///
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                
                if (Convert.ToBoolean(tabla.Rows[i]["Seleccionar"]) == true)
                {
                    bool borrado = true;
                    idseleccionado = Convert.ToString(tabla.Rows[i]["ClientId"]);
                    foreach (KeyValuePair<string, PedidoData> _Entry in MiSerializador.control.catalogo_pedido)
                    {
                        if (_Entry.Value.ClienteID == idseleccionado)
                        {

                            borrado = false;
                        }                      

                    }
                    if (borrado) {
                        
                        MiSerializador.control.catalogo_clientes.Remove(idseleccionado);
                    }
                    else
                    {
                        MessageBox.Show("El regsitro no se pued eliminar por que tiene pedidos asociados");
                    }
                    
                }
            }
            
            MiSerializador.control.SaveAppdata();
            idseleccionado = "";
            Limpiar();
            Iniciar();
        }
        private void BC_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla.Rows.Count==0)
            {
                return;
            }
            if (e.ColumnIndex==0)
            {
                if (e.RowIndex>=0)
                {
                    if (Convert.ToBoolean(tabla.Rows[e.RowIndex]["Seleccionar"])==true)
                    {
                        tabla.Rows[e.RowIndex]["Seleccionar"] = false;
                    }
                    else
                    {
                        tabla.Rows[e.RowIndex]["Seleccionar"] = true;
                    }
                    bool activarborrador = false;
                    for (int i=0; i< tabla.Rows.Count; i++)
                    {
                        if (Convert.ToBoolean(tabla.Rows[i]["Seleccionar"]) == true)
                        {
                            activarborrador = true;
                        }
                    }
                    BC_borrar_button.Enabled = activarborrador;
                }
            }
        }        
    }
}
