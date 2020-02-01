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
    public partial class editarcliente : Form
    {
        public editarcliente()
        {
            InitializeComponent();
            Iniciar();
        }
        private void Iniciar()
        {
            iddisplay.Text = MiSerializador.control.id_seleccionado;
            ED_cliente_name_inputfield.Text = MiSerializador.control.catalogo_clientes[MiSerializador.control.id_seleccionado].Nombre;
            ED_lastname_inputfield.Text = MiSerializador.control.catalogo_clientes[MiSerializador.control.id_seleccionado].Apellido;
        }
        private void editarcliente_Load(object sender, EventArgs e)
        {

        }

        private void ED_guardar_button_Click(object sender, EventArgs e)
        {
            MiSerializador.control.catalogo_clientes[MiSerializador.control.id_seleccionado].Nombre = ED_cliente_name_inputfield.Text;
            MiSerializador.control.catalogo_clientes[MiSerializador.control.id_seleccionado].Apellido = ED_lastname_inputfield.Text;
            MiSerializador.control.SaveAppdata();
            this.Close();
        }
    }
}
