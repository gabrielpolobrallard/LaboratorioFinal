namespace WindowsFormsApplication1.Vista.Ventanas
{
    partial class CompraForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgCompraProd = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NuevoProdBtn = new System.Windows.Forms.Button();
            this.EditarProdBtn = new System.Windows.Forms.Button();
            this.agregarACompraBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.subtotalprodtxt = new System.Windows.Forms.TextBox();
            this.txtboxDescuento = new System.Windows.Forms.TextBox();
            this.precioprodtxt = new System.Windows.Forms.TextBox();
            this.cantidadTxt = new System.Windows.Forms.TextBox();
            this.nombreprodtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboTipoPago = new System.Windows.Forms.ComboBox();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.PrecioTotalTxt = new System.Windows.Forms.TextBox();
            this.cantidadProdTottxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GuardarCompraBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dvgDetalle = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenerarNotaPedBtn = new System.Windows.Forms.Button();
            this.checkBoxVincularNota = new System.Windows.Forms.CheckBox();
            this.comboNotasPedido = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCompraProd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgCompraProd
            // 
            this.dvgCompraProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCompraProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCompraProd.Location = new System.Drawing.Point(6, 19);
            this.dvgCompraProd.Name = "dvgCompraProd";
            this.dvgCompraProd.RowHeadersVisible = false;
            this.dvgCompraProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCompraProd.Size = new System.Drawing.Size(456, 371);
            this.dvgCompraProd.TabIndex = 0;
            this.dvgCompraProd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCompraProd_CellClick);
            this.dvgCompraProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCompraProd_CellContentClick);
            this.dvgCompraProd.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCompraProd_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NuevoProdBtn);
            this.groupBox1.Controls.Add(this.EditarProdBtn);
            this.groupBox1.Controls.Add(this.agregarACompraBtn);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dvgCompraProd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 534);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Producto";
            // 
            // NuevoProdBtn
            // 
            this.NuevoProdBtn.Location = new System.Drawing.Point(468, 157);
            this.NuevoProdBtn.Name = "NuevoProdBtn";
            this.NuevoProdBtn.Size = new System.Drawing.Size(75, 23);
            this.NuevoProdBtn.TabIndex = 0;
            this.NuevoProdBtn.Text = "Nuevo";
            this.NuevoProdBtn.Click += new System.EventHandler(this.NuevoProdBtn_Click);
            // 
            // EditarProdBtn
            // 
            this.EditarProdBtn.Location = new System.Drawing.Point(468, 186);
            this.EditarProdBtn.Name = "EditarProdBtn";
            this.EditarProdBtn.Size = new System.Drawing.Size(75, 23);
            this.EditarProdBtn.TabIndex = 4;
            this.EditarProdBtn.Text = "Editar";
            this.EditarProdBtn.UseVisualStyleBackColor = true;
            this.EditarProdBtn.Click += new System.EventHandler(this.EditarProdBtn_Click);
            // 
            // agregarACompraBtn
            // 
            this.agregarACompraBtn.Location = new System.Drawing.Point(347, 433);
            this.agregarACompraBtn.Name = "agregarACompraBtn";
            this.agregarACompraBtn.Size = new System.Drawing.Size(115, 84);
            this.agregarACompraBtn.TabIndex = 1;
            this.agregarACompraBtn.Text = "Agregar a Compra/Nota";
            this.agregarACompraBtn.UseVisualStyleBackColor = true;
            this.agregarACompraBtn.Click += new System.EventHandler(this.agregarACompraBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.subtotalprodtxt);
            this.groupBox3.Controls.Add(this.txtboxDescuento);
            this.groupBox3.Controls.Add(this.precioprodtxt);
            this.groupBox3.Controls.Add(this.cantidadTxt);
            this.groupBox3.Controls.Add(this.nombreprodtxt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(6, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 99);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Descuento   %";
            // 
            // subtotalprodtxt
            // 
            this.subtotalprodtxt.Location = new System.Drawing.Point(79, 63);
            this.subtotalprodtxt.Name = "subtotalprodtxt";
            this.subtotalprodtxt.Size = new System.Drawing.Size(71, 20);
            this.subtotalprodtxt.TabIndex = 1;
            // 
            // txtboxDescuento
            // 
            this.txtboxDescuento.Location = new System.Drawing.Point(231, 67);
            this.txtboxDescuento.Name = "txtboxDescuento";
            this.txtboxDescuento.Size = new System.Drawing.Size(87, 20);
            this.txtboxDescuento.TabIndex = 1;
            this.txtboxDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // precioprodtxt
            // 
            this.precioprodtxt.Location = new System.Drawing.Point(173, 44);
            this.precioprodtxt.Name = "precioprodtxt";
            this.precioprodtxt.Size = new System.Drawing.Size(145, 20);
            this.precioprodtxt.TabIndex = 1;
            // 
            // cantidadTxt
            // 
            this.cantidadTxt.Location = new System.Drawing.Point(79, 44);
            this.cantidadTxt.Name = "cantidadTxt";
            this.cantidadTxt.Size = new System.Drawing.Size(45, 20);
            this.cantidadTxt.TabIndex = 2;
            this.cantidadTxt.TextChanged += new System.EventHandler(this.cantidadTxt_TextChanged);
            // 
            // nombreprodtxt
            // 
            this.nombreprodtxt.Location = new System.Drawing.Point(79, 19);
            this.nombreprodtxt.Name = "nombreprodtxt";
            this.nombreprodtxt.Size = new System.Drawing.Size(239, 20);
            this.nombreprodtxt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Subtotal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboNotasPedido);
            this.groupBox2.Controls.Add(this.checkBoxVincularNota);
            this.groupBox2.Controls.Add(this.comboTipoPago);
            this.groupBox2.Controls.Add(this.dtpFechaCompra);
            this.groupBox2.Controls.Add(this.PrecioTotalTxt);
            this.groupBox2.Controls.Add(this.textBoxDescripcion);
            this.groupBox2.Controls.Add(this.cantidadProdTottxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(592, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 164);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Compra";
            // 
            // comboTipoPago
            // 
            this.comboTipoPago.FormattingEnabled = true;
            this.comboTipoPago.Location = new System.Drawing.Point(334, 103);
            this.comboTipoPago.Name = "comboTipoPago";
            this.comboTipoPago.Size = new System.Drawing.Size(174, 21);
            this.comboTipoPago.TabIndex = 2;
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.Location = new System.Drawing.Point(139, 67);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(194, 20);
            this.dtpFechaCompra.TabIndex = 1;
            // 
            // PrecioTotalTxt
            // 
            this.PrecioTotalTxt.Location = new System.Drawing.Point(139, 136);
            this.PrecioTotalTxt.Name = "PrecioTotalTxt";
            this.PrecioTotalTxt.Size = new System.Drawing.Size(94, 20);
            this.PrecioTotalTxt.TabIndex = 1;
            // 
            // cantidadProdTottxt
            // 
            this.cantidadProdTottxt.Location = new System.Drawing.Point(139, 104);
            this.cantidadProdTottxt.Name = "cantidadProdTottxt";
            this.cantidadProdTottxt.Size = new System.Drawing.Size(100, 20);
            this.cantidadProdTottxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Precio Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipo de Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // GuardarCompraBtn
            // 
            this.GuardarCompraBtn.Location = new System.Drawing.Point(604, 563);
            this.GuardarCompraBtn.Name = "GuardarCompraBtn";
            this.GuardarCompraBtn.Size = new System.Drawing.Size(129, 23);
            this.GuardarCompraBtn.TabIndex = 1;
            this.GuardarCompraBtn.Text = "Guardar Compra";
            this.GuardarCompraBtn.UseVisualStyleBackColor = true;
            this.GuardarCompraBtn.Click += new System.EventHandler(this.GuardarCompraBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dvgDetalle);
            this.groupBox4.Location = new System.Drawing.Point(592, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(565, 364);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalle";
            // 
            // dvgDetalle
            // 
            this.dvgDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.Unidad,
            this.Descuento,
            this.Subtotal});
            this.dvgDetalle.Location = new System.Drawing.Point(15, 19);
            this.dvgDetalle.Name = "dvgDetalle";
            this.dvgDetalle.RowHeadersVisible = false;
            this.dvgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgDetalle.Size = new System.Drawing.Size(523, 327);
            this.dvgDetalle.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            // 
            // Descuento
            // 
            dataGridViewCellStyle2.Format = "00.00%";
            dataGridViewCellStyle2.NullValue = null;
            this.Descuento.DefaultCellStyle = dataGridViewCellStyle2;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // GenerarNotaPedBtn
            // 
            this.GenerarNotaPedBtn.Location = new System.Drawing.Point(469, 563);
            this.GenerarNotaPedBtn.Name = "GenerarNotaPedBtn";
            this.GenerarNotaPedBtn.Size = new System.Drawing.Size(129, 23);
            this.GenerarNotaPedBtn.TabIndex = 0;
            this.GenerarNotaPedBtn.Text = "Generar Nota";
            this.GenerarNotaPedBtn.UseVisualStyleBackColor = true;
            this.GenerarNotaPedBtn.Click += new System.EventHandler(this.GenerarNotaPedBtn_Click);
            // 
            // checkBoxVincularNota
            // 
            this.checkBoxVincularNota.AutoSize = true;
            this.checkBoxVincularNota.Location = new System.Drawing.Point(248, 135);
            this.checkBoxVincularNota.Name = "checkBoxVincularNota";
            this.checkBoxVincularNota.Size = new System.Drawing.Size(143, 17);
            this.checkBoxVincularNota.TabIndex = 3;
            this.checkBoxVincularNota.Text = "Vincular a Nota (compra)";
            this.checkBoxVincularNota.UseVisualStyleBackColor = true;
            this.checkBoxVincularNota.CheckedChanged += new System.EventHandler(this.checkBoxVincularNota_CheckedChanged);
            // 
            // comboNotasPedido
            // 
            this.comboNotasPedido.Enabled = false;
            this.comboNotasPedido.FormattingEnabled = true;
            this.comboNotasPedido.Location = new System.Drawing.Point(387, 131);
            this.comboNotasPedido.Name = "comboNotasPedido";
            this.comboNotasPedido.Size = new System.Drawing.Size(121, 21);
            this.comboNotasPedido.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Descripción";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(139, 30);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(369, 20);
            this.textBoxDescripcion.TabIndex = 0;
            // 
            // CompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 637);
            this.Controls.Add(this.GenerarNotaPedBtn);
            this.Controls.Add(this.GuardarCompraBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "CompraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompraForm";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCompraProd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCompraProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.TextBox PrecioTotalTxt;
        private System.Windows.Forms.TextBox cantidadProdTottxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox subtotalprodtxt;
        private System.Windows.Forms.TextBox cantidadTxt;
        private System.Windows.Forms.TextBox nombreprodtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button NuevoProdBtn;
        private System.Windows.Forms.Button EditarProdBtn;
        private System.Windows.Forms.Button agregarACompraBtn;
        private System.Windows.Forms.TextBox precioprodtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GuardarCompraBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dvgDetalle;
        private System.Windows.Forms.Button GenerarNotaPedBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.ComboBox comboTipoPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboNotasPedido;
        private System.Windows.Forms.CheckBox checkBoxVincularNota;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDescripcion;
    }
}