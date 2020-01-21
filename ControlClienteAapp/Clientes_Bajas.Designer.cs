namespace ControlClienteAapp
{
    partial class ClientesBajas
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
            this.BC_buscar_button = new System.Windows.Forms.Button();
            this.BC_borrar_button = new System.Windows.Forms.Button();
            this.BC_dataGridView = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BC_apellido_inputfield = new System.Windows.Forms.TextBox();
            this.BC_name_inputfield = new System.Windows.Forms.TextBox();
            this.BC_id_inputfield = new System.Windows.Forms.TextBox();
            this.BC_id_label = new System.Windows.Forms.Label();
            this.BC_nombre_label = new System.Windows.Forms.Label();
            this.BC_apellido_label = new System.Windows.Forms.Label();
            this.Resultados = new System.Windows.Forms.Label();
            this.Criterios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BC_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BC_buscar_button
            // 
            this.BC_buscar_button.Location = new System.Drawing.Point(356, 62);
            this.BC_buscar_button.Name = "BC_buscar_button";
            this.BC_buscar_button.Size = new System.Drawing.Size(118, 70);
            this.BC_buscar_button.TabIndex = 6;
            this.BC_buscar_button.Text = "Buscar";
            this.BC_buscar_button.UseVisualStyleBackColor = true;
            this.BC_buscar_button.Click += new System.EventHandler(this.BC_buscar_button_Click);
            // 
            // BC_borrar_button
            // 
            this.BC_borrar_button.Enabled = false;
            this.BC_borrar_button.Location = new System.Drawing.Point(480, 62);
            this.BC_borrar_button.Name = "BC_borrar_button";
            this.BC_borrar_button.Size = new System.Drawing.Size(118, 70);
            this.BC_borrar_button.TabIndex = 7;
            this.BC_borrar_button.Text = "Borrar";
            this.BC_borrar_button.UseVisualStyleBackColor = true;
            this.BC_borrar_button.Click += new System.EventHandler(this.BC_borrar_button_Click);
            // 
            // BC_dataGridView
            // 
            this.BC_dataGridView.AllowUserToAddRows = false;
            this.BC_dataGridView.AllowUserToDeleteRows = false;
            this.BC_dataGridView.CausesValidation = false;
            this.BC_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BC_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.BC_dataGridView.Location = new System.Drawing.Point(60, 203);
            this.BC_dataGridView.MultiSelect = false;
            this.BC_dataGridView.Name = "BC_dataGridView";
            this.BC_dataGridView.ReadOnly = true;
            this.BC_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.BC_dataGridView.Size = new System.Drawing.Size(537, 205);
            this.BC_dataGridView.TabIndex = 9;
            this.BC_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BC_dataGridView_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.DataPropertyName = "Seleccionar";
            this.Seleccionar.FalseValue = "False";
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.TrueValue = "True";
            // 
            // BC_apellido_inputfield
            // 
            this.BC_apellido_inputfield.Location = new System.Drawing.Point(164, 143);
            this.BC_apellido_inputfield.Name = "BC_apellido_inputfield";
            this.BC_apellido_inputfield.Size = new System.Drawing.Size(126, 20);
            this.BC_apellido_inputfield.TabIndex = 5;
            // 
            // BC_name_inputfield
            // 
            this.BC_name_inputfield.Location = new System.Drawing.Point(164, 102);
            this.BC_name_inputfield.Name = "BC_name_inputfield";
            this.BC_name_inputfield.Size = new System.Drawing.Size(126, 20);
            this.BC_name_inputfield.TabIndex = 4;
            // 
            // BC_id_inputfield
            // 
            this.BC_id_inputfield.Location = new System.Drawing.Point(164, 62);
            this.BC_id_inputfield.Name = "BC_id_inputfield";
            this.BC_id_inputfield.Size = new System.Drawing.Size(126, 20);
            this.BC_id_inputfield.TabIndex = 3;
            // 
            // BC_id_label
            // 
            this.BC_id_label.AutoSize = true;
            this.BC_id_label.Location = new System.Drawing.Point(70, 68);
            this.BC_id_label.Name = "BC_id_label";
            this.BC_id_label.Size = new System.Drawing.Size(15, 13);
            this.BC_id_label.TabIndex = 10;
            this.BC_id_label.Text = "id";
            // 
            // BC_nombre_label
            // 
            this.BC_nombre_label.AutoSize = true;
            this.BC_nombre_label.Location = new System.Drawing.Point(70, 102);
            this.BC_nombre_label.Name = "BC_nombre_label";
            this.BC_nombre_label.Size = new System.Drawing.Size(44, 13);
            this.BC_nombre_label.TabIndex = 11;
            this.BC_nombre_label.Text = "Nombre";
            // 
            // BC_apellido_label
            // 
            this.BC_apellido_label.AutoSize = true;
            this.BC_apellido_label.Location = new System.Drawing.Point(70, 143);
            this.BC_apellido_label.Name = "BC_apellido_label";
            this.BC_apellido_label.Size = new System.Drawing.Size(44, 13);
            this.BC_apellido_label.TabIndex = 12;
            this.BC_apellido_label.Text = "Apellido";
            // 
            // Resultados
            // 
            this.Resultados.AutoSize = true;
            this.Resultados.Location = new System.Drawing.Point(69, 178);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(60, 13);
            this.Resultados.TabIndex = 13;
            this.Resultados.Text = "Resultados";
            // 
            // Criterios
            // 
            this.Criterios.AutoSize = true;
            this.Criterios.Location = new System.Drawing.Point(57, 31);
            this.Criterios.Name = "Criterios";
            this.Criterios.Size = new System.Drawing.Size(109, 13);
            this.Criterios.TabIndex = 14;
            this.Criterios.Text = "Criterios de busqueda";
            // 
            // ClientesBajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Criterios);
            this.Controls.Add(this.Resultados);
            this.Controls.Add(this.BC_apellido_label);
            this.Controls.Add(this.BC_nombre_label);
            this.Controls.Add(this.BC_id_label);
            this.Controls.Add(this.BC_dataGridView);
            this.Controls.Add(this.BC_borrar_button);
            this.Controls.Add(this.BC_buscar_button);
            this.Controls.Add(this.BC_apellido_inputfield);
            this.Controls.Add(this.BC_name_inputfield);
            this.Controls.Add(this.BC_id_inputfield);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClientesBajas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Bajas";
            ((System.ComponentModel.ISupportInitialize)(this.BC_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BC_buscar_button;
        private System.Windows.Forms.Button BC_borrar_button;
        private System.Windows.Forms.DataGridView BC_dataGridView;
        private System.Windows.Forms.TextBox BC_apellido_inputfield;
        private System.Windows.Forms.TextBox BC_name_inputfield;
        private System.Windows.Forms.TextBox BC_id_inputfield;
        private System.Windows.Forms.Label BC_id_label;
        private System.Windows.Forms.Label BC_nombre_label;
        private System.Windows.Forms.Label BC_apellido_label;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Label Resultados;
        private System.Windows.Forms.Label Criterios;
    }
}