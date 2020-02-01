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
            foreach (KeyValuePair<string, ClienteData> Entry in MiSerializador.control.catalogo_clientes)
            {
                if (Entry.Value.ClienteID.Contains(CC_id_inputfield.Text)& CC_id_inputfield.Text!="")
                {
                    DataRow fila = tabla.NewRow();

                    fila["ClientId"] = Entry.Value.ClienteID;
                    fila["Nombre"] = Entry.Value.Nombre;
                    fila["Apellido"] = Entry.Value.Apellido;
                    tabla.Rows.Add(fila);

                }
                else
                {
                    if (MiSerializador.control.catalogo_clientes[Entry.Value.ClienteID].Nombre.ToLower().Contains(CC_name_inputfield.Text.ToLower()) & CC_name_inputfield.Text!="")
                    {
                        DataRow fila = tabla.NewRow();

                        fila["ClientId"] = Entry.Value.ClienteID;
                        fila["Nombre"] = Entry.Value.Nombre;
                        fila["Apellido"] = Entry.Value.Apellido;
                        tabla.Rows.Add(fila);
                    }
                    else
                    {
                        if (MiSerializador.control.catalogo_clientes[Entry.Value.ClienteID].Apellido.ToLower().Contains(CC_LastName_inputfield.Text.ToLower()) & CC_LastName_inputfield.Text!="")
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
