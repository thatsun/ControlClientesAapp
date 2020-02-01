namespace ControlClienteAapp
{
    partial class Principal
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
            this.m_pedidos_editar = new System.Windows.Forms.ToolStripMenuItem();
            this.S_Editarpedido = new System.Windows.Forms.ToolStripMenuItem();
            this.Sub_confirmarpedido = new System.Windows.Forms.ToolStripMenuItem();
            this.Sub_pedidoproduccion = new System.Windows.Forms.ToolStripMenuItem();
            this.Sub_Cancelarpedido = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_pago = new System.Windows.Forms.ToolStripMenuItem();
            this.Consultar_Pagos = new System.Windows.Forms.ToolStripMenuItem();
            this.Pago_Anticipo = new System.Windows.Forms.ToolStripMenuItem();
            this.Abonar_pagos = new System.Windows.Forms.ToolStripMenuItem();
            this.Liquidar_Pagos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Productos_Consultas = new System.Windows.Forms.ToolStripMenuItem();
            this.Productos_Cambios = new System.Windows.Forms.ToolStripMenuItem();
            this.Productos_Altas = new System.Windows.Forms.ToolStripMenuItem();
            this.Productos_Bajas = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_resportes = new System.Windows.Forms.ToolStripMenuItem();
            this.m_reportes_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.m_reportes_pedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.m_reporte_pagos = new System.Windows.Forms.ToolStripMenuItem();
            this.m_reportes_productos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_aplicacion = new System.Windows.Forms.ToolStripMenuItem();
            this.A_acercade = new System.Windows.Forms.ToolStripMenuItem();
            this.A_ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.A_salir = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_clientes,
            this.menu_pedidos,
            this.menu_pago,
            this.toolStripMenuItem1,
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
            this.m_clientes_altas.Size = new System.Drawing.Size(148, 26);
            this.m_clientes_altas.Text = "Altas";
            this.m_clientes_altas.Click += new System.EventHandler(this.m_clientes_altas_Click);
            // 
            // m_clientes_bajas
            // 
            this.m_clientes_bajas.Name = "m_clientes_bajas";
            this.m_clientes_bajas.Size = new System.Drawing.Size(148, 26);
            this.m_clientes_bajas.Text = "Bajas";
            this.m_clientes_bajas.Click += new System.EventHandler(this.m_clientes_bajas_Click);
            // 
            // m_clientes_consultas
            // 
            this.m_clientes_consultas.Name = "m_clientes_consultas";
            this.m_clientes_consultas.Size = new System.Drawing.Size(148, 26);
            this.m_clientes_consultas.Text = "Consultas";
            this.m_clientes_consultas.Click += new System.EventHandler(this.m_clientes_consultas_Click);
            // 
            // m_clientes_cambios
            // 
            this.m_clientes_cambios.Name = "m_clientes_cambios";
            this.m_clientes_cambios.Size = new System.Drawing.Size(148, 26);
            this.m_clientes_cambios.Text = "Cambios";
            this.m_clientes_cambios.Click += new System.EventHandler(this.m_clientes_cambios_Click);
            // 
            // menu_pedidos
            // 
            this.menu_pedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_pedidos_nuevo,
            this.m_pedidos_consultar,
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
            this.m_pedidos_nuevo.Size = new System.Drawing.Size(147, 26);
            this.m_pedidos_nuevo.Text = "Nuevo";
            this.m_pedidos_nuevo.Click += new System.EventHandler(this.m_pedidos_nuevo_Click);
            // 
            // m_pedidos_consultar
            // 
            this.m_pedidos_consultar.Name = "m_pedidos_consultar";
            this.m_pedidos_consultar.Size = new System.Drawing.Size(147, 26);
            this.m_pedidos_consultar.Text = "Consultar";
            this.m_pedidos_consultar.Click += new System.EventHandler(this.m_pedidos_consultar_Click);
            // 
            // m_pedidos_editar
            // 
            this.m_pedidos_editar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.S_Editarpedido,
            this.Sub_confirmarpedido,
            this.Sub_pedidoproduccion,
            this.Sub_Cancelarpedido});
            this.m_pedidos_editar.Name = "m_pedidos_editar";
            this.m_pedidos_editar.Size = new System.Drawing.Size(147, 26);
            this.m_pedidos_editar.Text = "Acciones";
            // 
            // S_Editarpedido
            // 
            this.S_Editarpedido.Name = "S_Editarpedido";
            this.S_Editarpedido.Size = new System.Drawing.Size(217, 26);
            this.S_Editarpedido.Text = "Editar Pedido";
            this.S_Editarpedido.Click += new System.EventHandler(this.S_Editarpedido_Click);
            // 
            // Sub_confirmarpedido
            // 
            this.Sub_confirmarpedido.Name = "Sub_confirmarpedido";
            this.Sub_confirmarpedido.Size = new System.Drawing.Size(217, 26);
            this.Sub_confirmarpedido.Text = "Confirmar Pedido";
            this.Sub_confirmarpedido.Click += new System.EventHandler(this.Sub_confirmarpedido_Click);
            // 
            // Sub_pedidoproduccion
            // 
            this.Sub_pedidoproduccion.Name = "Sub_pedidoproduccion";
            this.Sub_pedidoproduccion.Size = new System.Drawing.Size(217, 26);
            this.Sub_pedidoproduccion.Text = "Enviar a Produccion";
            this.Sub_pedidoproduccion.Click += new System.EventHandler(this.Sub_pedidoproduccion_Click);
            // 
            // Sub_Cancelarpedido
            // 
            this.Sub_Cancelarpedido.Name = "Sub_Cancelarpedido";
            this.Sub_Cancelarpedido.Size = new System.Drawing.Size(217, 26);
            this.Sub_Cancelarpedido.Text = "Cancelar Pedido";
            this.Sub_Cancelarpedido.Click += new System.EventHandler(this.Sub_Cancelarpedido_Click);
            // 
            // menu_pago
            // 
            this.menu_pago.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Consultar_Pagos,
            this.Pago_Anticipo,
            this.Abonar_pagos,
            this.Liquidar_Pagos});
            this.menu_pago.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menu_pago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu_pago.Name = "menu_pago";
            this.menu_pago.Size = new System.Drawing.Size(64, 25);
            this.menu_pago.Text = "Pagos";
            // 
            // Consultar_Pagos
            // 
            this.Consultar_Pagos.Name = "Consultar_Pagos";
            this.Consultar_Pagos.Size = new System.Drawing.Size(147, 26);
            this.Consultar_Pagos.Text = "Consultar";
            // 
            // Pago_Anticipo
            // 
            this.Pago_Anticipo.Name = "Pago_Anticipo";
            this.Pago_Anticipo.Size = new System.Drawing.Size(147, 26);
            this.Pago_Anticipo.Text = "Anticipo";
            // 
            // Abonar_pagos
            // 
            this.Abonar_pagos.Name = "Abonar_pagos";
            this.Abonar_pagos.Size = new System.Drawing.Size(147, 26);
            this.Abonar_pagos.Text = "Abonar";
            // 
            // Liquidar_Pagos
            // 
            this.Liquidar_Pagos.Name = "Liquidar_Pagos";
            this.Liquidar_Pagos.Size = new System.Drawing.Size(147, 26);
            this.Liquidar_Pagos.Text = "Liquidar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Productos_Consultas,
            this.Productos_Cambios,
            this.Productos_Altas,
            this.Productos_Bajas});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(92, 25);
            this.toolStripMenuItem1.Text = "Productos";
            // 
            // Productos_Consultas
            // 
            this.Productos_Consultas.Name = "Productos_Consultas";
            this.Productos_Consultas.Size = new System.Drawing.Size(148, 26);
            this.Productos_Consultas.Text = "Consultas";
            // 
            // Productos_Cambios
            // 
            this.Productos_Cambios.Name = "Productos_Cambios";
            this.Productos_Cambios.Size = new System.Drawing.Size(148, 26);
            this.Productos_Cambios.Text = "Cambios";
            // 
            // Productos_Altas
            // 
            this.Productos_Altas.Name = "Productos_Altas";
            this.Productos_Altas.Size = new System.Drawing.Size(148, 26);
            this.Productos_Altas.Text = "Altas";
            // 
            // Productos_Bajas
            // 
            this.Productos_Bajas.Name = "Productos_Bajas";
            this.Productos_Bajas.Size = new System.Drawing.Size(148, 26);
            this.Productos_Bajas.Text = "Bajas";
            // 
            // menu_resportes
            // 
            this.menu_resportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_reportes_clientes,
            this.m_reportes_pedidos,
            this.m_reporte_pagos,
            this.m_reportes_productos});
            this.menu_resportes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menu_resportes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu_resportes.Name = "menu_resportes";
            this.menu_resportes.Size = new System.Drawing.Size(84, 25);
            this.menu_resportes.Text = "Reportes";
            // 
            // m_reportes_clientes
            // 
            this.m_reportes_clientes.Name = "m_reportes_clientes";
            this.m_reportes_clientes.Size = new System.Drawing.Size(150, 26);
            this.m_reportes_clientes.Text = "Clientes";
            this.m_reportes_clientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // m_reportes_pedidos
            // 
            this.m_reportes_pedidos.Name = "m_reportes_pedidos";
            this.m_reportes_pedidos.Size = new System.Drawing.Size(150, 26);
            this.m_reportes_pedidos.Text = "Pedidos";
            this.m_reportes_pedidos.Click += new System.EventHandler(this.m_reportes_pedidos_Click);
            // 
            // m_reporte_pagos
            // 
            this.m_reporte_pagos.Name = "m_reporte_pagos";
            this.m_reporte_pagos.Size = new System.Drawing.Size(150, 26);
            this.m_reporte_pagos.Text = "Pagos";
            // 
            // m_reportes_productos
            // 
            this.m_reportes_productos.Name = "m_reportes_productos";
            this.m_reportes_productos.Size = new System.Drawing.Size(150, 26);
            this.m_reportes_productos.Text = "Productos";
            // 
            // menu_aplicacion
            // 
            this.menu_aplicacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.A_acercade,
            this.A_ayuda,
            this.A_salir});
            this.menu_aplicacion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menu_aplicacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu_aplicacion.Name = "menu_aplicacion";
            this.menu_aplicacion.Size = new System.Drawing.Size(93, 25);
            this.menu_aplicacion.Text = "Aplicacion";
            // 
            // A_acercade
            // 
            this.A_acercade.Name = "A_acercade";
            this.A_acercade.Size = new System.Drawing.Size(153, 26);
            this.A_acercade.Text = "Acerca de..";
            // 
            // A_ayuda
            // 
            this.A_ayuda.Name = "A_ayuda";
            this.A_ayuda.Size = new System.Drawing.Size(153, 26);
            this.A_ayuda.Text = "Ayuda";
            // 
            // A_salir
            // 
            this.A_salir.Name = "A_salir";
            this.A_salir.Size = new System.Drawing.Size(153, 26);
            this.A_salir.Text = "Salir";
            this.A_salir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1014, 546);
            this.Controls.Add(this.main_menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.main_menu;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Principal";
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
        private System.Windows.Forms.ToolStripMenuItem m_pedidos_editar;
        private System.Windows.Forms.ToolStripMenuItem menu_pago;
        private System.Windows.Forms.ToolStripMenuItem Consultar_Pagos;
        private System.Windows.Forms.ToolStripMenuItem Abonar_pagos;
        private System.Windows.Forms.ToolStripMenuItem menu_resportes;
        private System.Windows.Forms.ToolStripMenuItem m_reportes_clientes;
        private System.Windows.Forms.ToolStripMenuItem m_reportes_pedidos;
        private System.Windows.Forms.ToolStripMenuItem m_reporte_pagos;
        private System.Windows.Forms.ToolStripMenuItem menu_aplicacion;
        private System.Windows.Forms.ToolStripMenuItem A_acercade;
        private System.Windows.Forms.ToolStripMenuItem A_ayuda;
        private System.Windows.Forms.ToolStripMenuItem A_salir;
        private System.Windows.Forms.ToolStripMenuItem m_reportes_productos;
        private System.Windows.Forms.ToolStripMenuItem Sub_confirmarpedido;
        private System.Windows.Forms.ToolStripMenuItem Sub_pedidoproduccion;
        private System.Windows.Forms.ToolStripMenuItem Sub_Cancelarpedido;
        private System.Windows.Forms.ToolStripMenuItem Liquidar_Pagos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Productos_Consultas;
        private System.Windows.Forms.ToolStripMenuItem Productos_Cambios;
        private System.Windows.Forms.ToolStripMenuItem Productos_Altas;
        private System.Windows.Forms.ToolStripMenuItem Productos_Bajas;
        private System.Windows.Forms.ToolStripMenuItem S_Editarpedido;
        private System.Windows.Forms.ToolStripMenuItem Pago_Anticipo;
    }
}

