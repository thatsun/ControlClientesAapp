namespace ControlClienteAapp
{
    partial class ConsultarPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MiDataGridView = new System.Windows.Forms.DataGridView();
            this.Detalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.ClienteID_inputfield = new System.Windows.Forms.TextBox();
            this.ClienteIDLabel = new System.Windows.Forms.Label();
            this.Nombre_inputfield = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Apellido_Inputfield = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IncluirPendiente = new System.Windows.Forms.CheckBox();
            this.IncluirConfirmado = new System.Windows.Forms.CheckBox();
            this.IncluirProduccion = new System.Windows.Forms.CheckBox();
            this.IncluirCancelado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha_Busqueda = new System.Windows.Forms.DateTimePicker();
            this.Filtar_fecha = new System.Windows.Forms.CheckBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.VreTodos_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MiDataGridView
            // 
            this.MiDataGridView.AllowUserToAddRows = false;
            this.MiDataGridView.AllowUserToDeleteRows = false;
            this.MiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detalles});
            this.MiDataGridView.Location = new System.Drawing.Point(32, 237);
            this.MiDataGridView.Name = "MiDataGridView";
            this.MiDataGridView.ReadOnly = true;
            this.MiDataGridView.Size = new System.Drawing.Size(849, 263);
            this.MiDataGridView.TabIndex = 0;
            this.MiDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MiDataGridView_CellContentClick);
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "";
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            this.Detalles.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Detalles.Text = "Detalles";
            this.Detalles.UseColumnTextForButtonValue = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(437, 24);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(107, 71);
            this.BuscarButton.TabIndex = 1;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(661, 24);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(106, 71);
            this.LimpiarButton.TabIndex = 2;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // ClienteID_inputfield
            // 
            this.ClienteID_inputfield.Location = new System.Drawing.Point(125, 60);
            this.ClienteID_inputfield.Name = "ClienteID_inputfield";
            this.ClienteID_inputfield.Size = new System.Drawing.Size(100, 20);
            this.ClienteID_inputfield.TabIndex = 3;
            // 
            // ClienteIDLabel
            // 
            this.ClienteIDLabel.AutoSize = true;
            this.ClienteIDLabel.Location = new System.Drawing.Point(46, 63);
            this.ClienteIDLabel.Name = "ClienteIDLabel";
            this.ClienteIDLabel.Size = new System.Drawing.Size(50, 13);
            this.ClienteIDLabel.TabIndex = 4;
            this.ClienteIDLabel.Text = "ClienteID";
            // 
            // Nombre_inputfield
            // 
            this.Nombre_inputfield.Location = new System.Drawing.Point(125, 99);
            this.Nombre_inputfield.Name = "Nombre_inputfield";
            this.Nombre_inputfield.Size = new System.Drawing.Size(100, 20);
            this.Nombre_inputfield.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // Apellido_Inputfield
            // 
            this.Apellido_Inputfield.Location = new System.Drawing.Point(125, 138);
            this.Apellido_Inputfield.Name = "Apellido_Inputfield";
            this.Apellido_Inputfield.Size = new System.Drawing.Size(100, 20);
            this.Apellido_Inputfield.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido";
            // 
            // IncluirPendiente
            // 
            this.IncluirPendiente.AutoSize = true;
            this.IncluirPendiente.Checked = true;
            this.IncluirPendiente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncluirPendiente.Location = new System.Drawing.Point(51, 197);
            this.IncluirPendiente.Name = "IncluirPendiente";
            this.IncluirPendiente.Size = new System.Drawing.Size(74, 17);
            this.IncluirPendiente.TabIndex = 9;
            this.IncluirPendiente.Text = "Pendiente";
            this.IncluirPendiente.UseVisualStyleBackColor = true;
            // 
            // IncluirConfirmado
            // 
            this.IncluirConfirmado.AutoSize = true;
            this.IncluirConfirmado.Location = new System.Drawing.Point(232, 197);
            this.IncluirConfirmado.Name = "IncluirConfirmado";
            this.IncluirConfirmado.Size = new System.Drawing.Size(79, 17);
            this.IncluirConfirmado.TabIndex = 10;
            this.IncluirConfirmado.Text = "Confirmado";
            this.IncluirConfirmado.UseVisualStyleBackColor = true;
            // 
            // IncluirProduccion
            // 
            this.IncluirProduccion.AutoSize = true;
            this.IncluirProduccion.Location = new System.Drawing.Point(421, 197);
            this.IncluirProduccion.Name = "IncluirProduccion";
            this.IncluirProduccion.Size = new System.Drawing.Size(80, 17);
            this.IncluirProduccion.TabIndex = 11;
            this.IncluirProduccion.Text = "Produccion";
            this.IncluirProduccion.UseVisualStyleBackColor = true;
            // 
            // IncluirCancelado
            // 
            this.IncluirCancelado.AutoSize = true;
            this.IncluirCancelado.Location = new System.Drawing.Point(599, 197);
            this.IncluirCancelado.Name = "IncluirCancelado";
            this.IncluirCancelado.Size = new System.Drawing.Size(77, 17);
            this.IncluirCancelado.TabIndex = 12;
            this.IncluirCancelado.Text = "Cancelado";
            this.IncluirCancelado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Criterios de Busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fecha";
            // 
            // Fecha_Busqueda
            // 
            this.Fecha_Busqueda.Enabled = false;
            this.Fecha_Busqueda.Location = new System.Drawing.Point(661, 145);
            this.Fecha_Busqueda.Name = "Fecha_Busqueda";
            this.Fecha_Busqueda.Size = new System.Drawing.Size(200, 20);
            this.Fecha_Busqueda.TabIndex = 15;
            // 
            // Filtar_fecha
            // 
            this.Filtar_fecha.AutoSize = true;
            this.Filtar_fecha.Location = new System.Drawing.Point(369, 144);
            this.Filtar_fecha.Name = "Filtar_fecha";
            this.Filtar_fecha.Size = new System.Drawing.Size(206, 17);
            this.Filtar_fecha.TabIndex = 19;
            this.Filtar_fecha.Text = "Incluir Fecha en criterios de busqueda";
            this.Filtar_fecha.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Location = new System.Drawing.Point(775, 24);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(106, 71);
            this.CancelarButton.TabIndex = 20;
            this.CancelarButton.Text = "Salir";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // VreTodos_Button
            // 
            this.VreTodos_Button.Location = new System.Drawing.Point(550, 24);
            this.VreTodos_Button.Name = "VreTodos_Button";
            this.VreTodos_Button.Size = new System.Drawing.Size(105, 71);
            this.VreTodos_Button.TabIndex = 21;
            this.VreTodos_Button.Text = "Todos";
            this.VreTodos_Button.UseVisualStyleBackColor = true;
            this.VreTodos_Button.Click += new System.EventHandler(this.VreTodos_Button_Click);
            // 
            // ConsultarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(914, 531);
            this.Controls.Add(this.VreTodos_Button);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.Filtar_fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fecha_Busqueda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IncluirCancelado);
            this.Controls.Add(this.IncluirProduccion);
            this.Controls.Add(this.IncluirConfirmado);
            this.Controls.Add(this.IncluirPendiente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Apellido_Inputfield);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre_inputfield);
            this.Controls.Add(this.ClienteIDLabel);
            this.Controls.Add(this.ClienteID_inputfield);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.MiDataGridView);
            this.Name = "ConsultarPedidos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Pedidos";
            this.Load += new System.EventHandler(this.ConsultarPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MiDataGridView;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.TextBox ClienteID_inputfield;
        private System.Windows.Forms.Label ClienteIDLabel;
        private System.Windows.Forms.TextBox Nombre_inputfield;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Apellido_Inputfield;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox IncluirPendiente;
        private System.Windows.Forms.CheckBox IncluirConfirmado;
        private System.Windows.Forms.CheckBox IncluirProduccion;
        private System.Windows.Forms.CheckBox IncluirCancelado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Fecha_Busqueda;
        private System.Windows.Forms.CheckBox Filtar_fecha;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.DataGridViewButtonColumn Detalles;
        private System.Windows.Forms.Button VreTodos_Button;
    }
}