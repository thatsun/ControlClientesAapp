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
    public partial class Clientes_Consultas : Form
    {
        DataTable tabla;
        public Clientes_Consultas()
        {
            InitializeComponent();
            Iniciar();
        }
        void Iniciar()
        {
            tabla = new DataTable();           
            tabla.Columns.Add("ClientId");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            CC_MyData_gridview.DataSource = tabla;


        }
        private void ConsultarClientes()
        {
            foreach (KeyValuePair<int, ClienteData> Entry in MiSerializador.control.catalogo_clientes)
            {
                if (CC_id_inputfield.Text != "")
                {
                    if (Int32.TryParse(CC_id_inputfield.Text, out int numValue))
                    {
                        if (numValue == Entry.Value.ClienteID)
                        {
                            DataRow fila = tabla.NewRow();
                            
                            fila["ClientId"] = Entry.Value.ClienteID;
                            fila["Nombre"] = Entry.Value.Nombre;
                            fila["Apellido"] = Entry.Value.Apellido;
                            tabla.Rows.Add(fila);

                        }
                    }

                }
                else
                {
                    if (CC_name_inputfield.Text != "")
                    {
                        if (CC_LastName_inputfield.Text != "")
                        {
                            if (CC_LastName_inputfield.Text == Entry.Value.Apellido & CC_name_inputfield.Text == Entry.Value.Nombre)
                            {
                                DataRow fila = tabla.NewRow();
                                
                                fila["ClientId"] = Entry.Value.ClienteID;
                                fila["Nombre"] = Entry.Value.Nombre;
                                fila["Apellido"] = Entry.Value.Apellido;
                                tabla.Rows.Add(fila);
                            }
                        }
                        else
                        {
                            if (CC_name_inputfield.Text == Entry.Value.Nombre)
                            {
                                DataRow fila = tabla.NewRow();
                                
                                fila["ClientId"] = Entry.Value.ClienteID;
                                fila["Nombre"] = Entry.Value.Nombre;
                                fila["Apellido"] = Entry.Value.Apellido;
                                tabla.Rows.Add(fila);
                            }
                        }

                    }
                    else
                    {
                        if (CC_LastName_inputfield.Text != "")
                        {
                            if (CC_LastName_inputfield.Text == Entry.Value.Apellido)
                            {
                                DataRow fila = tabla.NewRow();
                                
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
            CC_id_inputfield.Text = "";
            CC_name_inputfield.Text = "";
            CC_LastName_inputfield.Text = "";
        }

        private void CC_buscar_button_Click(object sender, EventArgs e)
        {
            Iniciar();
            ConsultarClientes();
        }

        private void CC_Limpiar_button_Click(object sender, EventArgs e)
        {
            Limpiar();
            Iniciar();
        }
    }
}
