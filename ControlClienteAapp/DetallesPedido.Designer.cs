namespace ControlClienteAapp
{
    partial class DetallesPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Abono_inicial_display = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MyData_gridview = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.Monto_abono_display = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Total_pagado_display = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ImporteTotal_display = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Estado_display = new System.Windows.Forms.TextBox();
            this.Idpedido_display = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Anticipo_display = new System.Windows.Forms.TextBox();
            this.Cant_abonos_display = new System.Windows.Forms.TextBox();
            this.Fecha_display = new System.Windows.Forms.TextBox();
            this.Resta_pagar_display = new System.Windows.Forms.TextBox();
            this.TotalResta = new System.Windows.Forms.Label();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Detalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyData_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Abono_inicial_display
            // 
            this.Abono_inicial_display.Location = new System.Drawing.Point(136, 421);
            this.Abono_inicial_display.Name = "Abono_inicial_display";
            this.Abono_inicial_display.ReadOnly = true;
            this.Abono_inicial_display.Size = new System.Drawing.Size(130, 20);
            this.Abono_inicial_display.TabIndex = 56;
            this.Abono_inicial_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Abono inicial";
            // 
            // MyData_gridview
            // 
            this.MyData_gridview.AllowUserToAddRows = false;
            this.MyData_gridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyData_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MyData_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyData_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detalles,
            this.ProductoID,
            this.ProductoNombre,
            this.ProductoDes,
            this.Precio,
            this.Index});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MyData_gridview.DefaultCellStyle = dataGridViewCellStyle4;
            this.MyData_gridview.Location = new System.Drawing.Point(33, 112);
            this.MyData_gridview.MultiSelect = false;
            this.MyData_gridview.Name = "MyData_gridview";
            this.MyData_gridview.ReadOnly = true;
            this.MyData_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.MyData_gridview.Size = new System.Drawing.Size(679, 207);
            this.MyData_gridview.TabIndex = 53;
            this.MyData_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyData_gridview_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Total Pagado";
            // 
            // Monto_abono_display
            // 
            this.Monto_abono_display.Location = new System.Drawing.Point(136, 448);
            this.Monto_abono_display.Name = "Monto_abono_display";
            this.Monto_abono_display.ReadOnly = true;
            this.Monto_abono_display.Size = new System.Drawing.Size(130, 20);
            this.Monto_abono_display.TabIndex = 48;
            this.Monto_abono_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Monto Abonos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Cantidad de Pagos";
            // 
            // Total_pagado_display
            // 
            this.Total_pagado_display.Location = new System.Drawing.Point(136, 474);
            this.Total_pagado_display.Name = "Total_pagado_display";
            this.Total_pagado_display.ReadOnly = true;
            this.Total_pagado_display.Size = new System.Drawing.Size(130, 20);
            this.Total_pagado_display.TabIndex = 45;
            this.Total_pagado_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Anticipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "ImporteTotal";
            // 
            // ImporteTotal_display
            // 
            this.ImporteTotal_display.Location = new System.Drawing.Point(136, 338);
            this.ImporteTotal_display.Name = "ImporteTotal_display";
            this.ImporteTotal_display.ReadOnly = true;
            this.ImporteTotal_display.Size = new System.Drawing.Size(130, 20);
            this.ImporteTotal_display.TabIndex = 42;
            this.ImporteTotal_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Fecha";
            // 
            // Estado_display
            // 
            this.Estado_display.Location = new System.Drawing.Point(106, 61);
            this.Estado_display.Name = "Estado_display";
            this.Estado_display.ReadOnly = true;
            this.Estado_display.Size = new System.Drawing.Size(130, 20);
            this.Estado_display.TabIndex = 39;
            // 
            // Idpedido_display
            // 
            this.Idpedido_display.Location = new System.Drawing.Point(106, 19);
            this.Idpedido_display.Name = "Idpedido_display";
            this.Idpedido_display.ReadOnly = true;
            this.Idpedido_display.Size = new System.Drawing.Size(130, 20);
            this.Idpedido_display.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Id Pedido";
            // 
            // Anticipo_display
            // 
            this.Anticipo_display.Location = new System.Drawing.Point(136, 365);
            this.Anticipo_display.Name = "Anticipo_display";
            this.Anticipo_display.ReadOnly = true;
            this.Anticipo_display.Size = new System.Drawing.Size(130, 20);
            this.Anticipo_display.TabIndex = 57;
            // 
            // Cant_abonos_display
            // 
            this.Cant_abonos_display.Location = new System.Drawing.Point(136, 394);
            this.Cant_abonos_display.Name = "Cant_abonos_display";
            this.Cant_abonos_display.ReadOnly = true;
            this.Cant_abonos_display.Size = new System.Drawing.Size(130, 20);
            this.Cant_abonos_display.TabIndex = 58;
            // 
            // Fecha_display
            // 
            this.Fecha_display.Location = new System.Drawing.Point(302, 19);
            this.Fecha_display.Name = "Fecha_display";
            this.Fecha_display.ReadOnly = true;
            this.Fecha_display.Size = new System.Drawing.Size(130, 20);
            this.Fecha_display.TabIndex = 59;
            // 
            // Resta_pagar_display
            // 
            this.Resta_pagar_display.Location = new System.Drawing.Point(136, 505);
            this.Resta_pagar_display.Name = "Resta_pagar_display";
            this.Resta_pagar_display.ReadOnly = true;
            this.Resta_pagar_display.Size = new System.Drawing.Size(130, 20);
            this.Resta_pagar_display.TabIndex = 51;
            this.Resta_pagar_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalResta
            // 
            this.TotalResta.AutoSize = true;
            this.TotalResta.Location = new System.Drawing.Point(26, 505);
            this.TotalResta.Name = "TotalResta";
            this.TotalResta.Size = new System.Drawing.Size(66, 13);
            this.TotalResta.TabIndex = 50;
            this.TotalResta.Text = "Resta Pagar";
            // 
            // Cerrar
            // 
            this.Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cerrar.Location = new System.Drawing.Point(607, 12);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(105, 69);
            this.Cerrar.TabIndex = 60;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "";
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            this.Detalles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Detalles.Text = "Detalles";
            this.Detalles.UseColumnTextForButtonValue = true;
            // 
            // ProductoID
            // 
            this.ProductoID.DataPropertyName = "ProductoID";
            this.ProductoID.HeaderText = "ProductoID";
            this.ProductoID.Name = "ProductoID";
            this.ProductoID.ReadOnly = true;
            // 
            // ProductoNombre
            // 
            this.ProductoNombre.DataPropertyName = "ProductoNombre";
            this.ProductoNombre.HeaderText = "ProductoNombre";
            this.ProductoNombre.Name = "ProductoNombre";
            this.ProductoNombre.ReadOnly = true;
            // 
            // ProductoDes
            // 
            this.ProductoDes.DataPropertyName = "ProductoDes";
            this.ProductoDes.HeaderText = "ProductoDes";
            this.ProductoDes.Name = "ProductoDes";
            this.ProductoDes.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Index
            // 
            this.Index.DataPropertyName = "Index";
            this.Index.HeaderText = "index";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Visible = false;
            // 
            // Action_button
            // 
            this.Action_button.Location = new System.Drawing.Point(490, 13);
            this.Action_button.Name = "Action_button";
            this.Action_button.Size = new System.Drawing.Size(111, 68);
            this.Action_button.TabIndex = 61;
            this.Action_button.Text = "Accion";
            this.Action_button.UseVisualStyleBackColor = true;
            this.Action_button.Visible = false;
            // 
            // DetallesPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cerrar;
            this.ClientSize = new System.Drawing.Size(742, 565);
            this.Controls.Add(this.Action_button);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Fecha_display);
            this.Controls.Add(this.Cant_abonos_display);
            this.Controls.Add(this.Anticipo_display);
            this.Controls.Add(this.Abono_inicial_display);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MyData_gridview);
            this.Controls.Add(this.Resta_pagar_display);
            this.Controls.Add(this.TotalResta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Monto_abono_display);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Total_pagado_display);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ImporteTotal_display);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Estado_display);
            this.Controls.Add(this.Idpedido_display);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetallesPedido";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetallesPedido";
            this.Load += new System.EventHandler(this.DetallesPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyData_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Abono_inicial_display;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView MyData_gridview;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Monto_abono_display;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Total_pagado_display;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ImporteTotal_display;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Estado_display;
        private System.Windows.Forms.TextBox Idpedido_display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Anticipo_display;
        private System.Windows.Forms.TextBox Cant_abonos_display;
        private System.Windows.Forms.TextBox Fecha_display;
        private System.Windows.Forms.TextBox Resta_pagar_display;
        private System.Windows.Forms.Label TotalResta;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.DataGridViewButtonColumn Detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.Button Action_button;
    }
}