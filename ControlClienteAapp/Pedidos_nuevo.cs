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
    public partial class Pedidos_nuevo : Form
    {
        DataTable tabla;
        public Pedidos_nuevo()
        {
            InitializeComponent();
            Iniciar();
            ConsultarClientes();
        }
        private void Iniciar()
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
                DataRow fila = tabla.NewRow();
                fila["ClientId"] = Entry.Value.ClienteID;
                fila["Nombre"] = Entry.Value.Nombre;
                fila["Apellido"] = Entry.Value.Apellido;
                tabla.Rows.Add(fila);
            }
        }
        private void PN_crear_button_Click(object sender, EventArgs e)
        {
            ///abrir captura de detalles pedido
        }

        private void CC_MyData_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void CC_MyData_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla.Rows.Count == 0)
            {
                return;
            }
            if (e.RowIndex >= 0)
            {
                MiSerializador.control.id_seleccionado = Convert.ToString(CC_MyData_gridview.Rows[e.RowIndex].Cells["ClientId"].Value);

                MiSerializador.control.pedido_modocaptura = "Nuevo";
                
                Captura_Nuevo_Pedido _capturar_pedido = new Captura_Nuevo_Pedido();
                _capturar_pedido.ShowDialog();
               
                this.Close();
            }
        }
    }
}
