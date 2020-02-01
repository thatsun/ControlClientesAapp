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
    public partial class Principal : Form
    {
        MiSerializador controller;
           
        public Principal()
        {
            InitializeComponent();
            this.TopLevel = true;

            controller = new MiSerializador();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void m_clientes_altas_Click(object sender, EventArgs e)
        {
            cliente_altas _clientes_altas = new cliente_altas();
            _clientes_altas.ShowDialog();
        }

        private void m_clientes_bajas_Click(object sender, EventArgs e)
        {
            ClientesBajas _clientes_altas = new ClientesBajas();
            _clientes_altas.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void m_reportes_pedidos_Click(object sender, EventArgs e)
        {
            pedido _reportepedido = new pedido();
            _reportepedido.ShowDialog();
        }

        private void m_clientes_consultas_Click(object sender, EventArgs e)
        {
            Clientes_Consultas _clientes_consultas = new Clientes_Consultas();
            _clientes_consultas.ShowDialog();
        }

        private void m_clientes_cambios_Click(object sender, EventArgs e)
        {
            Clientes_Cambios _clientes_cambios = new Clientes_Cambios();
            _clientes_cambios.ShowDialog();
        }

        private void m_pedidos_nuevo_Click(object sender, EventArgs e)
        {
            Pedidos_nuevo _pedido_nuevo = new Pedidos_nuevo();
            _pedido_nuevo.ShowDialog();
        }

        private void m_pedidos_consultar_Click(object sender, EventArgs e)
        {
            MiSerializador.control.peddio_modo_consulta = "Consultar";
            ConsultarPedidos _pedido_consulta = new ConsultarPedidos();
            _pedido_consulta.ShowDialog();
        }

        private void Sub_confirmarpedido_Click(object sender, EventArgs e)
        {
            MiSerializador.control.peddio_modo_consulta = "Confirmar";
            ConsultarPedidos _pedido_consulta = new ConsultarPedidos();
            _pedido_consulta.ShowDialog();
        }

        private void Sub_pedidoproduccion_Click(object sender, EventArgs e)
        {
            MiSerializador.control.peddio_modo_consulta = "Produccion";
            ConsultarPedidos _pedido_consulta = new ConsultarPedidos();
            _pedido_consulta.ShowDialog();
        }

        private void Sub_Cancelarpedido_Click(object sender, EventArgs e)
        {
            MiSerializador.control.peddio_modo_consulta = "Cancelar";
            ConsultarPedidos _pedido_consulta = new ConsultarPedidos();
            _pedido_consulta.ShowDialog();
        }

        private void S_Editarpedido_Click(object sender, EventArgs e)
        {
            MiSerializador.control.peddio_modo_consulta = "Editar";
            ConsultarPedidos _pedido_consulta = new ConsultarPedidos();
            _pedido_consulta.ShowDialog();
        }
    }
}
