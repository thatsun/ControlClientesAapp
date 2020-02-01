namespace ControlClienteAapp
{
    partial class Captura_Nuevo_Pedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idcliente_display = new System.Windows.Forms.TextBox();
            this.name_display = new System.Windows.Forms.TextBox();
            this.PN_captura_guardar = new System.Windows.Forms.Button();
            this.PN_captura_cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Credito = new System.Windows.Forms.CheckBox();
            this.ImporteTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalRestaPagar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MontoAbono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FechaAbonos = new System.Windows.Forms.TextBox();
            this.Abonos = new System.Windows.Forms.NumericUpDown();
            this.Catalogo_Button = new System.Windows.Forms.Button();
            this.MyData_gridview = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.Ultimo_Abono_display = new System.Windows.Forms.TextBox();
            this.Anticipo = new System.Windows.Forms.TextBox();
            this.Quitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Abonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyData_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // idcliente_display
            // 
            this.idcliente_display.Location = new System.Drawing.Point(109, 32);
            this.idcliente_display.Name = "idcliente_display";
            this.idcliente_display.ReadOnly = true;
            this.idcliente_display.Size = new System.Drawing.Size(130, 20);
            this.idcliente_display.TabIndex = 2;
            // 
            // name_display
            // 
            this.name_display.Location = new System.Drawing.Point(109, 74);
            this.name_display.Name = "name_display";
            this.name_display.ReadOnly = true;
            this.name_display.Size = new System.Drawing.Size(130, 20);
            this.name_display.TabIndex = 3;
            // 
            // PN_captura_guardar
            // 
            this.PN_captura_guardar.Location = new System.Drawing.Point(575, 434);
            this.PN_captura_guardar.Name = "PN_captura_guardar";
            this.PN_captura_guardar.Size = new System.Drawing.Size(130, 73);
            this.PN_captura_guardar.TabIndex = 4;
            this.PN_captura_guardar.Text = "Guardar Pedido";
            this.PN_captura_guardar.UseVisualStyleBackColor = true;
            this.PN_captura_guardar.Click += new System.EventHandler(this.PN_captura_guardar_Click);
            // 
            // PN_captura_cancelar
            // 
            this.PN_captura_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.PN_captura_cancelar.Location = new System.Drawing.Point(726, 434);
            this.PN_captura_cancelar.Name = "PN_captura_cancelar";
            this.PN_captura_cancelar.Size = new System.Drawing.Size(133, 73);
            this.PN_captura_cancelar.TabIndex = 5;
            this.PN_captura_cancelar.Text = "Cancelar";
            this.PN_captura_cancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha";
            // 
            // Credito
            // 
            this.Credito.AutoSize = true;
            this.Credito.Location = new System.Drawing.Point(299, 353);
            this.Credito.Name = "Credito";
            this.Credito.Size = new System.Drawing.Size(59, 17);
            this.Credito.TabIndex = 10;
            this.Credito.Text = "Credito";
            this.Credito.UseVisualStyleBackColor = true;
            this.Credito.CheckedChanged += new System.EventHandler(this.Credito_check_changed);
            // 
            // ImporteTotal
            // 
            this.ImporteTotal.Location = new System.Drawing.Point(139, 351);
            this.ImporteTotal.Name = "ImporteTotal";
            this.ImporteTotal.ReadOnly = true;
            this.ImporteTotal.Size = new System.Drawing.Size(130, 20);
            this.ImporteTotal.TabIndex = 11;
            this.ImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ImporteTotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Anticipo";
            // 
            // TotalRestaPagar
            // 
            this.TotalRestaPagar.Location = new System.Drawing.Point(139, 487);
            this.TotalRestaPagar.Name = "TotalRestaPagar";
            this.TotalRestaPagar.ReadOnly = true;
            this.TotalRestaPagar.Size = new System.Drawing.Size(130, 20);
            this.TotalRestaPagar.TabIndex = 15;
            this.TotalRestaPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cantidad de Pagos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Monto Abonos";
            // 
            // MontoAbono
            // 
            this.MontoAbono.Location = new System.Drawing.Point(139, 461);
            this.MontoAbono.Name = "MontoAbono";
            this.MontoAbono.ReadOnly = true;
            this.MontoAbono.Size = new System.Drawing.Size(130, 20);
            this.MontoAbono.TabIndex = 19;
            this.MontoAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "TotalRestaPagar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 518);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Fecha Abonos";
            // 
            // FechaAbonos
            // 
            this.FechaAbonos.Location = new System.Drawing.Point(139, 518);
            this.FechaAbonos.Name = "FechaAbonos";
            this.FechaAbonos.ReadOnly = true;
            this.FechaAbonos.Size = new System.Drawing.Size(130, 20);
            this.FechaAbonos.TabIndex = 22;
            this.FechaAbonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Abonos
            // 
            this.Abonos.Location = new System.Drawing.Point(139, 403);
            this.Abonos.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Abonos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Abonos.Name = "Abonos";
            this.Abonos.Size = new System.Drawing.Size(130, 20);
            this.Abonos.TabIndex = 23;
            this.Abonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Abonos.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Abonos.ValueChanged += new System.EventHandler(this.C_abono_changed);
            // 
            // Catalogo_Button
            // 
            this.Catalogo_Button.Location = new System.Drawing.Point(726, 113);
            this.Catalogo_Button.Name = "Catalogo_Button";
            this.Catalogo_Button.Size = new System.Drawing.Size(122, 53);
            this.Catalogo_Button.TabIndex = 28;
            this.Catalogo_Button.Text = "Agregar Producto";
            this.Catalogo_Button.UseVisualStyleBackColor = true;
            this.Catalogo_Button.Click += new System.EventHandler(this.Catalogo_Button_Click);
            // 
            // MyData_gridview
            // 
            this.MyData_gridview.AllowUserToAddRows = false;
            this.MyData_gridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyData_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MyData_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyData_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quitar,
            this.Editar,
            this.ProductoID,
            this.ProductoNombre,
            this.ProductoDes,
            this.Precio,
            this.Index});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MyData_gridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.MyData_gridview.Location = new System.Drawing.Point(36, 125);
            this.MyData_gridview.MultiSelect = false;
            this.MyData_gridview.Name = "MyData_gridview";
            this.MyData_gridview.ReadOnly = true;
            this.MyData_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.MyData_gridview.Size = new System.Drawing.Size(669, 207);
            this.MyData_gridview.TabIndex = 29;
            this.MyData_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CP_gridview_Contentclick);
            this.MyData_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyData_gridview_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH/mm/dd/MM/yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(366, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.Value = new System.DateTime(2020, 1, 22, 16, 45, 55, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 439);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Abono inicial";
            // 
            // Ultimo_Abono_display
            // 
            this.Ultimo_Abono_display.Location = new System.Drawing.Point(139, 434);
            this.Ultimo_Abono_display.Name = "Ultimo_Abono_display";
            this.Ultimo_Abono_display.ReadOnly = true;
            this.Ultimo_Abono_display.Size = new System.Drawing.Size(130, 20);
            this.Ultimo_Abono_display.TabIndex = 34;
            this.Ultimo_Abono_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Anticipo
            // 
            this.Anticipo.Location = new System.Drawing.Point(139, 377);
            this.Anticipo.Name = "Anticipo";
            this.Anticipo.ReadOnly = true;
            this.Anticipo.Size = new System.Drawing.Size(130, 20);
            this.Anticipo.TabIndex = 35;
            this.Anticipo.Text = "1";
            this.Anticipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Anticipo.TextChanged += new System.EventHandler(this.C_validadoanticipo);
            // 
            // Quitar
            // 
            this.Quitar.HeaderText = "";
            this.Quitar.Name = "Quitar";
            this.Quitar.ReadOnly = true;
            this.Quitar.Text = "Quitar";
            this.Quitar.UseColumnTextForButtonValue = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // ProductoID
            // 
            this.ProductoID.DataPropertyName = "ProductoID";
            this.ProductoID.HeaderText = "ProductoID";
            this.ProductoID.Name = "ProductoID";
            this.ProductoID.ReadOnly = true;
            this.ProductoID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProductoNombre
            // 
            this.ProductoNombre.DataPropertyName = "ProductoNombre";
            this.ProductoNombre.HeaderText = "ProductoNombre";
            this.ProductoNombre.Name = "ProductoNombre";
            this.ProductoNombre.ReadOnly = true;
            this.ProductoNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProductoDes
            // 
            this.ProductoDes.DataPropertyName = "ProductoDes";
            this.ProductoDes.HeaderText = "ProductoDes";
            this.ProductoDes.Name = "ProductoDes";
            this.ProductoDes.ReadOnly = true;
            this.ProductoDes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Index
            // 
            this.Index.DataPropertyName = "Index";
            this.Index.HeaderText = "index";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Visible = false;
            // 
            // Captura_Nuevo_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.PN_captura_cancelar;
            this.ClientSize = new System.Drawing.Size(878, 589);
            this.Controls.Add(this.Anticipo);
            this.Controls.Add(this.Ultimo_Abono_display);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.MyData_gridview);
            this.Controls.Add(this.Catalogo_Button);
            this.Controls.Add(this.Abonos);
            this.Controls.Add(this.FechaAbonos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MontoAbono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalRestaPagar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ImporteTotal);
            this.Controls.Add(this.Credito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PN_captura_cancelar);
            this.Controls.Add(this.PN_captura_guardar);
            this.Controls.Add(this.name_display);
            this.Controls.Add(this.idcliente_display);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Captura_Nuevo_Pedido";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captura de Pedido Nuevo";
            this.Activated += new System.EventHandler(this.PN_obtenerdatos_producto);
            this.Load += new System.EventHandler(this.Captura_Nuevo_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Abonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyData_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idcliente_display;
        private System.Windows.Forms.TextBox name_display;
        private System.Windows.Forms.Button PN_captura_guardar;
        private System.Windows.Forms.Button PN_captura_cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Credito;
        private System.Windows.Forms.TextBox ImporteTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TotalRestaPagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MontoAbono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FechaAbonos;
        private System.Windows.Forms.NumericUpDown Abonos;
        private System.Windows.Forms.Button Catalogo_Button;
        private System.Windows.Forms.DataGridView MyData_gridview;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Ultimo_Abono_display;
        private System.Windows.Forms.TextBox Anticipo;
        private System.Windows.Forms.DataGridViewButtonColumn Quitar;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
    }
}