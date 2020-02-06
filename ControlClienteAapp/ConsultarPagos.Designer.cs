namespace ControlClienteAapp
{
    partial class ConsultarPagos
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
            this.VreTodos_Button = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.Filtar_fecha = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha_Busqueda = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.VigentesCheckBox = new System.Windows.Forms.CheckBox();
            this.VencidosCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Apellido_Inputfield = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre_inputfield = new System.Windows.Forms.TextBox();
            this.ClienteIDLabel = new System.Windows.Forms.Label();
            this.ClienteID_inputfield = new System.Windows.Forms.TextBox();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.MiDataGridView = new System.Windows.Forms.DataGridView();
            this.Detalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PendienteCheckBox = new System.Windows.Forms.CheckBox();
            this.PagadosCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.MiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VreTodos_Button
            // 
            this.VreTodos_Button.Location = new System.Drawing.Point(585, 49);
            this.VreTodos_Button.Name = "VreTodos_Button";
            this.VreTodos_Button.Size = new System.Drawing.Size(105, 71);
            this.VreTodos_Button.TabIndex = 40;
            this.VreTodos_Button.Text = "Todos";
            this.VreTodos_Button.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Location = new System.Drawing.Point(810, 49);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(106, 71);
            this.CancelarButton.TabIndex = 39;
            this.CancelarButton.Text = "Salir";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // Filtar_fecha
            // 
            this.Filtar_fecha.AutoSize = true;
            this.Filtar_fecha.Location = new System.Drawing.Point(404, 169);
            this.Filtar_fecha.Name = "Filtar_fecha";
            this.Filtar_fecha.Size = new System.Drawing.Size(206, 17);
            this.Filtar_fecha.TabIndex = 38;
            this.Filtar_fecha.Text = "Incluir Fecha en criterios de busqueda";
            this.Filtar_fecha.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Fecha";
            // 
            // Fecha_Busqueda
            // 
            this.Fecha_Busqueda.Enabled = false;
            this.Fecha_Busqueda.Location = new System.Drawing.Point(696, 170);
            this.Fecha_Busqueda.Name = "Fecha_Busqueda";
            this.Fecha_Busqueda.Size = new System.Drawing.Size(200, 20);
            this.Fecha_Busqueda.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Criterios de Busqueda";
            // 
            // VigentesCheckBox
            // 
            this.VigentesCheckBox.AutoSize = true;
            this.VigentesCheckBox.Checked = true;
            this.VigentesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VigentesCheckBox.Location = new System.Drawing.Point(67, 222);
            this.VigentesCheckBox.Name = "VigentesCheckBox";
            this.VigentesCheckBox.Size = new System.Drawing.Size(106, 17);
            this.VigentesCheckBox.TabIndex = 34;
            this.VigentesCheckBox.Text = "Abonos Vigentes";
            this.VigentesCheckBox.UseVisualStyleBackColor = true;
            // 
            // VencidosCheckBox
            // 
            this.VencidosCheckBox.AutoSize = true;
            this.VencidosCheckBox.Location = new System.Drawing.Point(282, 222);
            this.VencidosCheckBox.Name = "VencidosCheckBox";
            this.VencidosCheckBox.Size = new System.Drawing.Size(109, 17);
            this.VencidosCheckBox.TabIndex = 33;
            this.VencidosCheckBox.Text = "Abonos Vencidos";
            this.VencidosCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Apellido";
            // 
            // Apellido_Inputfield
            // 
            this.Apellido_Inputfield.Location = new System.Drawing.Point(160, 163);
            this.Apellido_Inputfield.Name = "Apellido_Inputfield";
            this.Apellido_Inputfield.Size = new System.Drawing.Size(100, 20);
            this.Apellido_Inputfield.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre";
            // 
            // Nombre_inputfield
            // 
            this.Nombre_inputfield.Location = new System.Drawing.Point(160, 124);
            this.Nombre_inputfield.Name = "Nombre_inputfield";
            this.Nombre_inputfield.Size = new System.Drawing.Size(100, 20);
            this.Nombre_inputfield.TabIndex = 27;
            // 
            // ClienteIDLabel
            // 
            this.ClienteIDLabel.AutoSize = true;
            this.ClienteIDLabel.Location = new System.Drawing.Point(81, 88);
            this.ClienteIDLabel.Name = "ClienteIDLabel";
            this.ClienteIDLabel.Size = new System.Drawing.Size(50, 13);
            this.ClienteIDLabel.TabIndex = 26;
            this.ClienteIDLabel.Text = "ClienteID";
            // 
            // ClienteID_inputfield
            // 
            this.ClienteID_inputfield.Location = new System.Drawing.Point(160, 85);
            this.ClienteID_inputfield.Name = "ClienteID_inputfield";
            this.ClienteID_inputfield.Size = new System.Drawing.Size(100, 20);
            this.ClienteID_inputfield.TabIndex = 25;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(696, 49);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(106, 71);
            this.LimpiarButton.TabIndex = 24;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(472, 49);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(107, 71);
            this.BuscarButton.TabIndex = 23;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // MiDataGridView
            // 
            this.MiDataGridView.AllowUserToAddRows = false;
            this.MiDataGridView.AllowUserToDeleteRows = false;
            this.MiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detalles});
            this.MiDataGridView.Location = new System.Drawing.Point(67, 262);
            this.MiDataGridView.Name = "MiDataGridView";
            this.MiDataGridView.ReadOnly = true;
            this.MiDataGridView.Size = new System.Drawing.Size(849, 263);
            this.MiDataGridView.TabIndex = 22;
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
            // PendienteCheckBox
            // 
            this.PendienteCheckBox.AutoSize = true;
            this.PendienteCheckBox.Location = new System.Drawing.Point(458, 222);
            this.PendienteCheckBox.Name = "PendienteCheckBox";
            this.PendienteCheckBox.Size = new System.Drawing.Size(118, 17);
            this.PendienteCheckBox.TabIndex = 41;
            this.PendienteCheckBox.Text = "Abonos Pendientes";
            this.PendienteCheckBox.UseVisualStyleBackColor = true;
            // 
            // PagadosCheckBox
            // 
            this.PagadosCheckBox.AutoSize = true;
            this.PagadosCheckBox.Location = new System.Drawing.Point(681, 222);
            this.PagadosCheckBox.Name = "PagadosCheckBox";
            this.PagadosCheckBox.Size = new System.Drawing.Size(107, 17);
            this.PagadosCheckBox.TabIndex = 42;
            this.PagadosCheckBox.Text = "Abonos Pagados";
            this.PagadosCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConsultarPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 635);
            this.Controls.Add(this.PagadosCheckBox);
            this.Controls.Add(this.PendienteCheckBox);
            this.Controls.Add(this.VreTodos_Button);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.Filtar_fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fecha_Busqueda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VigentesCheckBox);
            this.Controls.Add(this.VencidosCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Apellido_Inputfield);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre_inputfield);
            this.Controls.Add(this.ClienteIDLabel);
            this.Controls.Add(this.ClienteID_inputfield);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.MiDataGridView);
            this.Name = "ConsultarPagos";
            this.Text = "Consultar Pagos";
            this.Load += new System.EventHandler(this.ConsultarPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VreTodos_Button;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.CheckBox Filtar_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Fecha_Busqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox VigentesCheckBox;
        private System.Windows.Forms.CheckBox VencidosCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Apellido_Inputfield;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nombre_inputfield;
        private System.Windows.Forms.Label ClienteIDLabel;
        private System.Windows.Forms.TextBox ClienteID_inputfield;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView MiDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn Detalles;
        private System.Windows.Forms.CheckBox PendienteCheckBox;
        private System.Windows.Forms.CheckBox PagadosCheckBox;
    }
}