namespace ControlClienteAapp
{
    partial class Clientes_Cambios
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
            this.label2 = new System.Windows.Forms.Label();
            this.CC_buscar_button = new System.Windows.Forms.Button();
            this.BC_id_label = new System.Windows.Forms.Label();
            this.CC_id_inputfield = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CC_Limpiar_button = new System.Windows.Forms.Button();
            this.CC_MyData_gridview = new System.Windows.Forms.DataGridView();
            this.apellido_label = new System.Windows.Forms.Label();
            this.CC_LastName_inputfield = new System.Windows.Forms.TextBox();
            this.CC_name_inputfield = new System.Windows.Forms.TextBox();
            this.nombre_label = new System.Windows.Forms.Label();
            this.Aplicar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CC_CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CC_MyData_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Criterios de busqueda";
            // 
            // CC_buscar_button
            // 
            this.CC_buscar_button.Location = new System.Drawing.Point(430, 66);
            this.CC_buscar_button.Name = "CC_buscar_button";
            this.CC_buscar_button.Size = new System.Drawing.Size(90, 58);
            this.CC_buscar_button.TabIndex = 40;
            this.CC_buscar_button.Text = "Buscar";
            this.CC_buscar_button.UseVisualStyleBackColor = true;
            this.CC_buscar_button.Click += new System.EventHandler(this.CC_buscar_button_Click_1);
            // 
            // BC_id_label
            // 
            this.BC_id_label.AutoSize = true;
            this.BC_id_label.Location = new System.Drawing.Point(124, 66);
            this.BC_id_label.Name = "BC_id_label";
            this.BC_id_label.Size = new System.Drawing.Size(15, 13);
            this.BC_id_label.TabIndex = 39;
            this.BC_id_label.Text = "id";
            // 
            // CC_id_inputfield
            // 
            this.CC_id_inputfield.Location = new System.Drawing.Point(209, 63);
            this.CC_id_inputfield.Name = "CC_id_inputfield";
            this.CC_id_inputfield.Size = new System.Drawing.Size(126, 20);
            this.CC_id_inputfield.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Resultados";
            // 
            // CC_Limpiar_button
            // 
            this.CC_Limpiar_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CC_Limpiar_button.Location = new System.Drawing.Point(526, 66);
            this.CC_Limpiar_button.Name = "CC_Limpiar_button";
            this.CC_Limpiar_button.Size = new System.Drawing.Size(88, 59);
            this.CC_Limpiar_button.TabIndex = 36;
            this.CC_Limpiar_button.Text = "Limpiar";
            this.CC_Limpiar_button.UseVisualStyleBackColor = true;
            this.CC_Limpiar_button.Click += new System.EventHandler(this.CC_Limpiar_button_Click);
            // 
            // CC_MyData_gridview
            // 
            this.CC_MyData_gridview.AllowUserToAddRows = false;
            this.CC_MyData_gridview.AllowUserToDeleteRows = false;
            this.CC_MyData_gridview.AllowUserToResizeRows = false;
            this.CC_MyData_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CC_MyData_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aplicar,
            this.ClientId,
            this.Nombre,
            this.Apellido});
            this.CC_MyData_gridview.Location = new System.Drawing.Point(124, 199);
            this.CC_MyData_gridview.MultiSelect = false;
            this.CC_MyData_gridview.Name = "CC_MyData_gridview";
            this.CC_MyData_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CC_MyData_gridview.Size = new System.Drawing.Size(556, 212);
            this.CC_MyData_gridview.TabIndex = 35;
            this.CC_MyData_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CC_MyData_gridview_CellContentClick);
            // 
            // apellido_label
            // 
            this.apellido_label.AutoSize = true;
            this.apellido_label.Location = new System.Drawing.Point(121, 145);
            this.apellido_label.Name = "apellido_label";
            this.apellido_label.Size = new System.Drawing.Size(44, 13);
            this.apellido_label.TabIndex = 34;
            this.apellido_label.Text = "Apellido";
            // 
            // CC_LastName_inputfield
            // 
            this.CC_LastName_inputfield.Location = new System.Drawing.Point(209, 142);
            this.CC_LastName_inputfield.Name = "CC_LastName_inputfield";
            this.CC_LastName_inputfield.Size = new System.Drawing.Size(165, 20);
            this.CC_LastName_inputfield.TabIndex = 33;
            // 
            // CC_name_inputfield
            // 
            this.CC_name_inputfield.Location = new System.Drawing.Point(209, 101);
            this.CC_name_inputfield.Name = "CC_name_inputfield";
            this.CC_name_inputfield.Size = new System.Drawing.Size(165, 20);
            this.CC_name_inputfield.TabIndex = 32;
            // 
            // nombre_label
            // 
            this.nombre_label.AutoSize = true;
            this.nombre_label.Location = new System.Drawing.Point(121, 104);
            this.nombre_label.Name = "nombre_label";
            this.nombre_label.Size = new System.Drawing.Size(44, 13);
            this.nombre_label.TabIndex = 31;
            this.nombre_label.Text = "Nombre";
            // 
            // Aplicar
            // 
            this.Aplicar.HeaderText = "";
            this.Aplicar.Name = "Aplicar";
            this.Aplicar.Text = "Editar";
            this.Aplicar.UseColumnTextForButtonValue = true;
            // 
            // ClientId
            // 
            this.ClientId.DataPropertyName = "ClientId";
            this.ClientId.HeaderText = "Id";
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // CC_CancelButton
            // 
            this.CC_CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CC_CancelButton.Location = new System.Drawing.Point(621, 66);
            this.CC_CancelButton.Name = "CC_CancelButton";
            this.CC_CancelButton.Size = new System.Drawing.Size(83, 59);
            this.CC_CancelButton.TabIndex = 42;
            this.CC_CancelButton.Text = "Cancelar";
            this.CC_CancelButton.UseVisualStyleBackColor = true;
            // 
            // Clientes_Cambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CC_CancelButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CC_CancelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CC_buscar_button);
            this.Controls.Add(this.BC_id_label);
            this.Controls.Add(this.CC_id_inputfield);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CC_Limpiar_button);
            this.Controls.Add(this.CC_MyData_gridview);
            this.Controls.Add(this.apellido_label);
            this.Controls.Add(this.CC_LastName_inputfield);
            this.Controls.Add(this.CC_name_inputfield);
            this.Controls.Add(this.nombre_label);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clientes_Cambios";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Cambios";
            this.Load += new System.EventHandler(this.Clientes_Cambios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CC_MyData_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CC_buscar_button;
        private System.Windows.Forms.Label BC_id_label;
        private System.Windows.Forms.TextBox CC_id_inputfield;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CC_Limpiar_button;
        private System.Windows.Forms.DataGridView CC_MyData_gridview;
        private System.Windows.Forms.Label apellido_label;
        private System.Windows.Forms.TextBox CC_LastName_inputfield;
        private System.Windows.Forms.TextBox CC_name_inputfield;
        private System.Windows.Forms.Label nombre_label;
        private System.Windows.Forms.DataGridViewButtonColumn Aplicar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.Button CC_CancelButton;
    }
}