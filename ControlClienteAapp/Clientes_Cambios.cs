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
    public partial class Clientes_Cambios : Form
    {
        DataTable tabla;
        public Clientes_Cambios()
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
                if (CC_id_inputfield.Text != "")
                {
                    if (CC_id_inputfield.Text == Entry.Value.ClienteID)
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
        private void Clientes_Cambios_Load(object sender, EventArgs e)
        {

        }

        private void CC_buscar_button_Click_1(object sender, EventArgs e)
        {
            Iniciar();
            ConsultarClientes();
        }

        private void CC_Limpiar_button_Click(object sender, EventArgs e)
        {
            Limpiar();
            Iniciar();
        }

        private void CC_MyData_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla.Rows.Count == 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex >= 0)
                {
                    MiSerializador.control.id_seleccionado =Convert.ToString(CC_MyData_gridview.Rows[e.RowIndex].Cells["ClientId"].Value);

                    Limpiar();
                    Iniciar();
                    editarcliente _clientes_cambios = new editarcliente();
                    _clientes_cambios.ShowDialog();
                }
            }
        }
    }
}
