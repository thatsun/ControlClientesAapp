namespace ControlClienteAapp
{
    partial class Pedidos_nuevo
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
            this.PN_salir_button = new System.Windows.Forms.Button();
            this.CC_MyData_gridview = new System.Windows.Forms.DataGridView();
            this.IntruuccionesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CC_MyData_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // PN_salir_button
            // 
            this.PN_salir_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.PN_salir_button.Location = new System.Drawing.Point(612, 35);
            this.PN_salir_button.Name = "PN_salir_button";
            this.PN_salir_button.Size = new System.Drawing.Size(140, 67);
            this.PN_salir_button.TabIndex = 0;
            this.PN_salir_button.Text = "Salir";
            this.PN_salir_button.UseVisualStyleBackColor = true;
            // 
            // CC_MyData_gridview
            // 
            this.CC_MyData_gridview.AllowUserToAddRows = false;
            this.CC_MyData_gridview.AllowUserToDeleteRows = false;
            this.CC_MyData_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CC_MyData_gridview.Location = new System.Drawing.Point(41, 134);
            this.CC_MyData_gridview.Name = "CC_MyData_gridview";
            this.CC_MyData_gridview.ReadOnly = true;
            this.CC_MyData_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CC_MyData_gridview.Size = new System.Drawing.Size(711, 276);
            this.CC_MyData_gridview.TabIndex = 2;
            this.CC_MyData_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CC_MyData_gridview_CellClick);
            this.CC_MyData_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CC_MyData_gridview_CellContentClick);
            // 
            // IntruuccionesLabel
            // 
            this.IntruuccionesLabel.AutoSize = true;
            this.IntruuccionesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntruuccionesLabel.Location = new System.Drawing.Point(36, 53);
            this.IntruuccionesLabel.Name = "IntruuccionesLabel";
            this.IntruuccionesLabel.Size = new System.Drawing.Size(408, 25);
            this.IntruuccionesLabel.TabIndex = 3;
            this.IntruuccionesLabel.Text = "Para crear un pedido por favor elige un cliente";
            // 
            // Pedidos_nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.PN_salir_button;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IntruuccionesLabel);
            this.Controls.Add(this.CC_MyData_gridview);
            this.Controls.Add(this.PN_salir_button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pedidos_nuevo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.CC_MyData_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PN_salir_button;
        private System.Windows.Forms.DataGridView CC_MyData_gridview;
        private System.Windows.Forms.Label IntruuccionesLabel;
    }
}