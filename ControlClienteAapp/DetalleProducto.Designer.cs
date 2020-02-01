namespace ControlClienteAapp
{
    partial class DetalleProducto
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
            this.Detalle_CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductoIndex_display = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Detalle_CancelButton
            // 
            this.Detalle_CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Detalle_CancelButton.Location = new System.Drawing.Point(627, 34);
            this.Detalle_CancelButton.Name = "Detalle_CancelButton";
            this.Detalle_CancelButton.Size = new System.Drawing.Size(118, 75);
            this.Detalle_CancelButton.TabIndex = 0;
            this.Detalle_CancelButton.Text = "Cancelar";
            this.Detalle_CancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ProductoIndex";
            // 
            // ProductoIndex_display
            // 
            this.ProductoIndex_display.Location = new System.Drawing.Point(133, 47);
            this.ProductoIndex_display.Name = "ProductoIndex_display";
            this.ProductoIndex_display.ReadOnly = true;
            this.ProductoIndex_display.Size = new System.Drawing.Size(100, 20);
            this.ProductoIndex_display.TabIndex = 2;
            // 
            // DetalleProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Detalle_CancelButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductoIndex_display);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Detalle_CancelButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetalleProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleProducto";
            this.Load += new System.EventHandler(this.DetalleProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Detalle_CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductoIndex_display;
    }
}