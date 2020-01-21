namespace ControlClienteAapp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.menu_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.m_clientes_altas = new System.Windows.Forms.ToolStripMenuItem();
            this.m_clientes_bajas = new System.Windows.Forms.ToolStripMenuItem();
            this.m_clientes_consultas = new System.Windows.Forms.ToolStripMenuItem();
            this.m_clientes_cambios = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_pedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.m_pedidos_nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.m_pedidos_consultar = new System.Windows.Forms.ToolStripMenuItem();
            this.m_pedidos_eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.m_pedidos_editar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cuentas = new System.Windows.Forms.ToolStripMenuItem();
            this.m_cuentas_xcliente = new System.Windows.Forms.ToolStripMenuItem();
            this.m_cuentas_xestado = new System.Windows.Forms.ToolStripMenuItem();
            this.m_cuentas_abono = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_resportes = new System.Windows.Forms.ToolStripMenuItem();
            this.m_reportes_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.m_reportes_pedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.m_reporte_cuentas = new System.Windows.Forms.ToolStripMenuItem();
            this.m_reportes_abonosvigentes = new System.Windows.Forms.ToolStripMenuItem();
            this.m_reportes_abonos_vencidos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_aplicacion = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_clientes,
            this.menu_pedidos,
            this.menu_cuentas,
            this.menu_resportes,
            this.menu_aplicacion});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.main_menu.Size = new System.Drawing.Size(1014, 31);
            this.main_menu.TabIndex = 9;
            this.main_menu.TabStop = true;
            this.main_menu.Text = "menuStrip1";
            // 
            // menu_clientes
            // 
            this.menu_clientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_clientes_altas,
            this.m_clientes_bajas,
            this.m_clientes_consultas,
            this.m_clientes_cambios});
            this.menu_clientes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menu_clientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu_clientes.Name = "menu_clientes";
            this.menu_clientes.Size = new System.Drawing.Size(77, 25);
            this.menu_clientes.Text = "Clientes";
            this.menu_clientes.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // m_clientes_altas
            // 
            this.m_clientes_altas.Name = "m_clientes_altas";
            this.m_clientes_altas.Size = new System.Drawing.Size(180, 26);
            this.m_clientes_altas.Text = "Altas";
            this.m_clientes_altas.Click += new System.EventHandler(this.m_clientes_altas_Click);
            // 
            // m_clientes_bajas
            // 
            this.m_clientes_bajas.Name = "m_clientes_bajas";
            this.m_clientes_bajas.Size = new System.Drawing.Size(180, 26);
            this.m_clientes_bajas.Text = "Bajas";
            this.m_clientes_bajas.Click += new System.EventHandler(this.m_clientes_bajas_Click);
            // 
            // m_clientes_consultas
            // 
            this.m_clientes_consultas.Name = "m_clientes_consultas";
            this.m_clientes_consultas.Size = new System.Drawing.Size(180, 26);
            this.m_clientes_consultas.Text = "Consultas";
            this.m_clientes_consultas.Click += new System.EventHandler(this.m_clientes_consultas_Click);
            // 
            // m_clientes_cambios
            // 
            this.m_clientes_cambios.Name = "m_clientes_cambios";
            this.m_clientes_cambios.Size = new System.Drawing.Size(180, 26);
            this.m_clientes_cambios.Text = "Cambios";
            // 
            // menu_pedidos
            // 
            this.menu_pedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_pedidos_nuevo,
            this.m_pedidos_consultar,
            this.m_pedidos_eliminar,
            this.m_pedidos_editar});
            this.menu_pedidos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menu_pedidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu_pedidos.Name = "menu_pedidos";
            this.menu_pedidos.Size = new System.Drawing.Size(77, 25);
            this.menu_pedidos.Text = "Pedidos";
            // 
            // m_pedidos_nuevo
            // 
            this.m_pedidos_nuevo.Name = "m_pedidos_nuevo";
            this.m_pedidos_nuevo.Size = new System.Drawing.Size(180, 26);
            this.m_pedidos_nuevo.Text = "Nuevo";
            // 
            // m_pedidos_consultar
            // 
            this.m_pedidos_consultar.Name = "m_pedidos_consultar";
            this.m_pedidos_consultar.Size = new System.Drawing.Size(180, 26);
            this.m_pedidos_consultar.Text = "Consultar";
            // 
            // m_pedidos_eliminar
            // 
            this.m_pedidos_eliminar.Name = "m_pedidos_eliminar";
            this.m_pedidos_eliminar.Size = new System.Drawing.Size(180, 26);
            this.m_pedidos_eliminar.Text = "Eliminar";
            // 
            // m_pedidos_editar
            // 
            this.m_pedidos_editar.Name = "m_pedidos_editar";
            this.m_pedidos_editar.Size = new System.Drawing.Size(180, 26);
            this.m_pedidos_editar.Text = "Editar";
            // 
            // menu_cuentas
            // 
            this.menu_cuentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_cuentas_xcliente,
            this.m_cuentas_xestado,
            this.m_cuentas_abono});
            this.menu_cuentas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menu_cuentas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu_cuentas.Name = "menu_cuentas";
            this.menu_cuentas.Size = new System.Drawing.Size(78, 25);
            this.menu_cuentas.Text = "Cuentas";
            // 
            // m_cuentas_xcliente
            // 
            this.m_cuentas_xcliente.Name = "m_cuentas_xcliente";
            this.m_cuentas_xcliente.Size = new System.Drawing.Size(225, 26);
            this.m_cuentas_xcliente.Text = "Consultar por cliente";
            // 
            // m_cuentas_xestado
            // 
            this.m_cuentas_xestado.Name = "m_cuentas_xestado";
            this.m_cuentas_xestado.Size = new System.Drawing.Size(225, 26);
            this.m_cuentas_xestado.Text = "Consultar por estado";
            // 
            // m_cuentas_abono
            // 
            this.m_cuentas_abono.Name = "m_cuentas_abono";
            this.m_cuentas_abono.Size = new System.Drawing.Size(225, 26);
            this.m_cuentas_abono.Text = "Abono";
            // 
            // menu_resportes
            // 
            this.menu_resportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_reportes_clientes,
            this.m_reportes_pedidos,
            this.m_reporte_cuentas,
            this.m_reportes_abonosvigentes,
            this.m_reportes_abonos_vencidos});
            this.menu_resportes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menu_resportes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu_resportes.Name = "menu_resportes";
            this.menu_resportes.Size = new System.Drawing.Size(84, 25);
            this.menu_resportes.Text = "Reportes";
            this.menu_resportes.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // m_reportes_clientes
            // 
            this.m_reportes_clientes.Name = "m_reportes_clientes";
            this.m_reportes_clientes.Size = new System.Drawing.Size(198, 26);
            this.m_reportes_clientes.Text = "Clientes";
            this.m_reportes_clientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // m_reportes_pedidos
            // 
            this.m_reportes_pedidos.Name = "m_reportes_pedidos";
            this.m_reportes_pedidos.Size = new System.Drawing.Size(198, 26);
            this.m_reportes_pedidos.Text = "Pedidos";
            this.m_reportes_pedidos.Click += new System.EventHandler(this.m_reportes_pedidos_Click);
            // 
            // m_reporte_cuentas
            // 
            this.m_reporte_cuentas.Name = "m_reporte_cuentas";
            this.m_reporte_cuentas.Size = new System.Drawing.Size(198, 26);
            this.m_reporte_cuentas.Text = "Cuentas";
            // 
            // m_reportes_abonosvigentes
            // 
            this.m_reportes_abonosvigentes.Name = "m_reportes_abonosvigentes";
            this.m_reportes_abonosvigentes.Size = new System.Drawing.Size(198, 26);
            this.m_reportes_abonosvigentes.Text = "Abonos vigentes";
            // 
            // m_reportes_abonos_vencidos
            // 
            this.m_reportes_abonos_vencidos.Name = "m_reportes_abonos_vencidos";
            this.m_reportes_abonos_vencidos.Size = new System.Drawing.Size(198, 26);
            this.m_reportes_abonos_vencidos.Text = "Abonos vencidos";
            // 
            // menu_aplicacion
            // 
            this.menu_aplicacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menu_aplicacion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menu_aplicacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu_aplicacion.Name = "menu_aplicacion";
            this.menu_aplicacion.Size = new System.Drawing.Size(93, 25);
            this.menu_aplicacion.Text = "Aplicacion";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de..";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1014, 546);
            this.Controls.Add(this.main_menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.main_menu;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Control de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem menu_clientes;
        private System.Windows.Forms.ToolStripMenuItem m_clientes_altas;
        private System.Windows.Forms.ToolStripMenuItem m_clientes_bajas;
        private System.Windows.Forms.ToolStripMenuItem m_clientes_consultas;
        private System.Windows.Forms.ToolStripMenuItem m_clientes_cambios;
        private System.Windows.Forms.ToolStripMenuItem menu_pedidos;
        private System.Windows.Forms.ToolStripMenuItem m_pedidos_nuevo;
        private System.Windows.Forms.ToolStripMenuItem m_pedidos_consultar;
        private System.Windows.Forms.ToolStripMenuItem m_pedidos_eliminar;
        private System.Windows.Forms.ToolStripMenuItem m_pedidos_editar;
        private System.Windows.Forms.ToolStripMenuItem menu_cuentas;
        private System.Windows.Forms.ToolStripMenuItem m_cuentas_xcliente;
        private System.Windows.Forms.ToolStripMenuItem m_cuentas_xestado;
        private System.Windows.Forms.ToolStripMenuItem m_cuentas_abono;
        private System.Windows.Forms.ToolStripMenuItem menu_resportes;
        private System.Windows.Forms.ToolStripMenuItem m_reportes_clientes;
        private System.Windows.Forms.ToolStripMenuItem m_reportes_pedidos;
        private System.Windows.Forms.ToolStripMenuItem m_reporte_cuentas;
        private System.Windows.Forms.ToolStripMenuItem menu_aplicacion;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_reportes_abonosvigentes;
        private System.Windows.Forms.ToolStripMenuItem m_reportes_abonos_vencidos;
    }
}

