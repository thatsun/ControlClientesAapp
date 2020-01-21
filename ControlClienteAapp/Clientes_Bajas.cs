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
        int idseleccionado = 0;

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
            foreach (KeyValuePair<int, ClienteData> Entry in MiSerializador.control.catalogo_clientes)
            {
                if (BC_id_inputfield.Text != "")
                {
                    if (Int32.TryParse(BC_id_inputfield.Text, out int numValue))
                    {
                        if (numValue == Entry.Value.ClienteID)
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
                else
                {
                    if (BC_name_inputfield.Text != "")
                    {
                        if (BC_apellido_inputfield.Text != "")
                        {
                            if (BC_apellido_inputfield.Text == Entry.Value.Apellido & BC_name_inputfield.Text == Entry.Value.Nombre)
                            {
                                DataRow fila = tabla.NewRow();
                                fila["Seleccionar"] = false;
                                fila["ClientId"] = Entry.Value.ClienteID;
                                fila["Nombre"] = Entry.Value.Nombre;
                                fila["Apellido"] = Entry.Value.Apellido;
                                tabla.Rows.Add(fila);
                            }
                        }
                        else
                        {
                            if (BC_name_inputfield.Text == Entry.Value.Nombre)
                            {
                                DataRow fila = tabla.NewRow();
                                fila["Seleccionar"] =false;
                                fila["ClientId"] = Entry.Value.ClienteID;
                                fila["Nombre"] = Entry.Value.Nombre;
                                fila["Apellido"] = Entry.Value.Apellido;
                                tabla.Rows.Add(fila);
                            }
                        }
                        
                    }
                    else
                    {
                        if (BC_apellido_inputfield.Text!="")
                        {
                            if (BC_apellido_inputfield.Text == Entry.Value.Apellido)
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
                    idseleccionado = Convert.ToInt32(tabla.Rows[i]["ClientId"]);
                    MiSerializador.control.catalogo_clientes.Remove(idseleccionado);
                }
            }
            
            MiSerializador.control.SaveAppdata();
            idseleccionado = 0;
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
