namespace ControlClienteAapp
{
    partial class editarcliente
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
            this.CC_id = new System.Windows.Forms.Label();
            this.iddisplay = new System.Windows.Forms.TextBox();
            this.ED_name_label = new System.Windows.Forms.Label();
            this.ED_lastname_label = new System.Windows.Forms.Label();
            this.ED_cliente_name_inputfield = new System.Windows.Forms.TextBox();
            this.ED_lastname_inputfield = new System.Windows.Forms.TextBox();
            this.ED_guardar_button = new System.Windows.Forms.Button();
            this.ED_cancelar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CC_id
            // 
            this.CC_id.AutoSize = true;
            this.CC_id.Location = new System.Drawing.Point(47, 29);
            this.CC_id.Name = "CC_id";
            this.CC_id.Size = new System.Drawing.Size(53, 13);
            this.CC_id.TabIndex = 0;
            this.CC_id.Text = "Cliente ID";
            // 
            // iddisplay
            // 
            this.iddisplay.Location = new System.Drawing.Point(116, 26);
            this.iddisplay.Name = "iddisplay";
            this.iddisplay.ReadOnly = true;
            this.iddisplay.Size = new System.Drawing.Size(100, 20);
            this.iddisplay.TabIndex = 1;
            // 
            // ED_name_label
            // 
            this.ED_name_label.AutoSize = true;
            this.ED_name_label.Location = new System.Drawing.Point(47, 86);
            this.ED_name_label.Name = "ED_name_label";
            this.ED_name_label.Size = new System.Drawing.Size(44, 13);
            this.ED_name_label.TabIndex = 2;
            this.ED_name_label.Text = "Nombre";
            // 
            // ED_lastname_label
            // 
            this.ED_lastname_label.AutoSize = true;
            this.ED_lastname_label.Location = new System.Drawing.Point(47, 146);
            this.ED_lastname_label.Name = "ED_lastname_label";
            this.ED_lastname_label.Size = new System.Drawing.Size(44, 13);
            this.ED_lastname_label.TabIndex = 3;
            this.ED_lastname_label.Text = "Apellido";
            // 
            // ED_cliente_name_inputfield
            // 
            this.ED_cliente_name_inputfield.Location = new System.Drawing.Point(116, 86);
            this.ED_cliente_name_inputfield.Name = "ED_cliente_name_inputfield";
            this.ED_cliente_name_inputfield.Size = new System.Drawing.Size(215, 20);
            this.ED_cliente_name_inputfield.TabIndex = 6;
            // 
            // ED_lastname_inputfield
            // 
            this.ED_lastname_inputfield.Location = new System.Drawing.Point(116, 146);
            this.ED_lastname_inputfield.Name = "ED_lastname_inputfield";
            this.ED_lastname_inputfield.Size = new System.Drawing.Size(215, 20);
            this.ED_lastname_inputfield.TabIndex = 7;
            // 
            // ED_guardar_button
            // 
            this.ED_guardar_button.Location = new System.Drawing.Point(437, 26);
            this.ED_guardar_button.Name = "ED_guardar_button";
            this.ED_guardar_button.Size = new System.Drawing.Size(155, 50);
            this.ED_guardar_button.TabIndex = 8;
            this.ED_guardar_button.Text = "Guardar Cambios";
            this.ED_guardar_button.UseVisualStyleBackColor = true;
            this.ED_guardar_button.Click += new System.EventHandler(this.ED_guardar_button_Click);
            // 
            // ED_cancelar_button
            // 
            this.ED_cancelar_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ED_cancelar_button.Location = new System.Drawing.Point(437, 82);
            this.ED_cancelar_button.Name = "ED_cancelar_button";
            this.ED_cancelar_button.Size = new System.Drawing.Size(155, 51);
            this.ED_cancelar_button.TabIndex = 9;
            this.ED_cancelar_button.Text = "Cancelar";
            this.ED_cancelar_button.UseVisualStyleBackColor = true;
            // 
            // editarcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ED_cancelar_button;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.ED_cancelar_button);
            this.Controls.Add(this.ED_guardar_button);
            this.Controls.Add(this.ED_lastname_inputfield);
            this.Controls.Add(this.ED_cliente_name_inputfield);
            this.Controls.Add(this.ED_lastname_label);
            this.Controls.Add(this.ED_name_label);
            this.Controls.Add(this.iddisplay);
            this.Controls.Add(this.CC_id);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editarcliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar datos Cliente";
            this.Load += new System.EventHandler(this.editarcliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CC_id;
        private System.Windows.Forms.TextBox iddisplay;
        private System.Windows.Forms.Label ED_name_label;
        private System.Windows.Forms.Label ED_lastname_label;
        private System.Windows.Forms.TextBox ED_cliente_name_inputfield;
        private System.Windows.Forms.TextBox ED_lastname_inputfield;
        private System.Windows.Forms.Button ED_guardar_button;
        private System.Windows.Forms.Button ED_cancelar_button;
    }
}