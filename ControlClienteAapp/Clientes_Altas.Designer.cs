namespace ControlClienteAapp
{
    partial class cliente_altas
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
            this.Consultar_button = new System.Windows.Forms.Button();
            this.Limpiar_button = new System.Windows.Forms.Button();
            this.MyData_gridview = new System.Windows.Forms.DataGridView();
            this.apellido_label = new System.Windows.Forms.Label();
            this.LastName_inputfield = new System.Windows.Forms.TextBox();
            this.name_inputfield = new System.Windows.Forms.TextBox();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.nombre_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CA_cancelbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyData_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Consultar_button
            // 
            this.Consultar_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Consultar_button.Location = new System.Drawing.Point(510, 51);
            this.Consultar_button.Name = "Consultar_button";
            this.Consultar_button.Size = new System.Drawing.Size(88, 59);
            this.Consultar_button.TabIndex = 16;
            this.Consultar_button.Text = "Consultar";
            this.Consultar_button.UseVisualStyleBackColor = true;
            this.Consultar_button.Click += new System.EventHandler(this.Consultar_button_Click);
            // 
            // Limpiar_button
            // 
            this.Limpiar_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Limpiar_button.Location = new System.Drawing.Point(416, 51);
            this.Limpiar_button.Name = "Limpiar_button";
            this.Limpiar_button.Size = new System.Drawing.Size(88, 59);
            this.Limpiar_button.TabIndex = 15;
            this.Limpiar_button.Text = "Limpiar";
            this.Limpiar_button.UseVisualStyleBackColor = true;
            this.Limpiar_button.Click += new System.EventHandler(this.Limpiar_button_Click);
            // 
            // MyData_gridview
            // 
            this.MyData_gridview.AllowUserToAddRows = false;
            this.MyData_gridview.AllowUserToDeleteRows = false;
            this.MyData_gridview.AllowUserToResizeRows = false;
            this.MyData_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyData_gridview.Location = new System.Drawing.Point(42, 173);
            this.MyData_gridview.MultiSelect = false;
            this.MyData_gridview.Name = "MyData_gridview";
            this.MyData_gridview.ReadOnly = true;
            this.MyData_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyData_gridview.Size = new System.Drawing.Size(654, 212);
            this.MyData_gridview.TabIndex = 14;
            this.MyData_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyData_gridview_CellContentClick);
            // 
            // apellido_label
            // 
            this.apellido_label.AutoSize = true;
            this.apellido_label.Location = new System.Drawing.Point(39, 102);
            this.apellido_label.Name = "apellido_label";
            this.apellido_label.Size = new System.Drawing.Size(44, 13);
            this.apellido_label.TabIndex = 13;
            this.apellido_label.Text = "Apellido";
            // 
            // LastName_inputfield
            // 
            this.LastName_inputfield.Location = new System.Drawing.Point(127, 99);
            this.LastName_inputfield.Name = "LastName_inputfield";
            this.LastName_inputfield.Size = new System.Drawing.Size(165, 20);
            this.LastName_inputfield.TabIndex = 12;
            // 
            // name_inputfield
            // 
            this.name_inputfield.Location = new System.Drawing.Point(127, 51);
            this.name_inputfield.Name = "name_inputfield";
            this.name_inputfield.Size = new System.Drawing.Size(165, 20);
            this.name_inputfield.TabIndex = 11;
            // 
            // Guardar_button
            // 
            this.Guardar_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Guardar_button.Location = new System.Drawing.Point(322, 51);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(88, 59);
            this.Guardar_button.TabIndex = 10;
            this.Guardar_button.Text = "Guardar";
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // nombre_label
            // 
            this.nombre_label.AutoSize = true;
            this.nombre_label.Location = new System.Drawing.Point(39, 51);
            this.nombre_label.Name = "nombre_label";
            this.nombre_label.Size = new System.Drawing.Size(44, 13);
            this.nombre_label.TabIndex = 9;
            this.nombre_label.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registros";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CA_cancelbutton
            // 
            this.CA_cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CA_cancelbutton.Location = new System.Drawing.Point(604, 51);
            this.CA_cancelbutton.Name = "CA_cancelbutton";
            this.CA_cancelbutton.Size = new System.Drawing.Size(92, 59);
            this.CA_cancelbutton.TabIndex = 18;
            this.CA_cancelbutton.Text = "Cancelar";
            this.CA_cancelbutton.UseVisualStyleBackColor = true;
            // 
            // cliente_altas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CA_cancelbutton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CA_cancelbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Consultar_button);
            this.Controls.Add(this.Limpiar_button);
            this.Controls.Add(this.MyData_gridview);
            this.Controls.Add(this.apellido_label);
            this.Controls.Add(this.LastName_inputfield);
            this.Controls.Add(this.name_inputfield);
            this.Controls.Add(this.Guardar_button);
            this.Controls.Add(this.nombre_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cliente_altas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altas clientes";
            ((System.ComponentModel.ISupportInitialize)(this.MyData_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Consultar_button;
        private System.Windows.Forms.Button Limpiar_button;
        private System.Windows.Forms.DataGridView MyData_gridview;
        private System.Windows.Forms.Label apellido_label;
        private System.Windows.Forms.TextBox LastName_inputfield;
        private System.Windows.Forms.TextBox name_inputfield;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.Label nombre_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CA_cancelbutton;
    }
}