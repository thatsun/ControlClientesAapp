using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlClienteAapp
{
    public partial class cliente_altas : Form
    {
        DataTable tabla;
        
        
        public cliente_altas()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            GuardarCliente();
            Iniciar();
            Limpiar();
            ConsultarClientes();
        }
        private void Limpiar_button_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("ClientId");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            MyData_gridview.DataSource = tabla;
        }
        private void GuardarCliente()
        {
            ClienteData _clienteData = new ClienteData()
            {
                Nombre = name_inputfield.Text,
                Apellido = LastName_inputfield.Text

            };
            MiSerializador.control.id_autoincrementado++;
            _clienteData.ClienteID = MiSerializador.control.id_autoincrementado.ToString();
            MiSerializador.control.catalogo_clientes.Add(_clienteData.ClienteID, _clienteData);
            MiSerializador.control.SaveAppdata();
        }
        private void ConsultarClientes()
        {
            foreach (KeyValuePair<string, ClienteData> Entry in MiSerializador.control.catalogo_clientes)
            {
                DataRow fila = tabla.NewRow();
                fila["ClientId"] = Entry.Value.ClienteID;
                fila["Nombre"] = Entry.Value.Nombre;
                fila["Apellido"] = Entry.Value.Apellido;
                tabla.Rows.Add(fila);
            }
        }
        private void Limpiar()
        {
            name_inputfield.Text = "";
            LastName_inputfield.Text = "";
        }

        private void Consultar_button_Click(object sender, EventArgs e)
        {
            Iniciar();
            Limpiar();
            ConsultarClientes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MyData_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
