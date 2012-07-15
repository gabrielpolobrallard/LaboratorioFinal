namespace WindowsFormsApplication1.Vista.Ventanas_DialogBoxes_ABMS
{
    partial class NuevoProductoDialogBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoProductoDialogBox));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBoxNvoProd = new System.Windows.Forms.GroupBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.comboMedida = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCantDisp = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxCantMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoDetalle = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxNvoProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(165, 345);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 74);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBoxNvoProd
            // 
            this.groupBoxNvoProd.Controls.Add(this.comboTipo);
            this.groupBoxNvoProd.Controls.Add(this.comboMedida);
            this.groupBoxNvoProd.Controls.Add(this.label6);
            this.groupBoxNvoProd.Controls.Add(this.comboMarca);
            this.groupBoxNvoProd.Controls.Add(this.label4);
            this.groupBoxNvoProd.Controls.Add(this.label5);
            this.groupBoxNvoProd.Controls.Add(this.label7);
            this.groupBoxNvoProd.Controls.Add(this.label3);
            this.groupBoxNvoProd.Controls.Add(this.label2);
            this.groupBoxNvoProd.Controls.Add(this.textBoxCantDisp);
            this.groupBoxNvoProd.Controls.Add(this.textBoxPrecio);
            this.groupBoxNvoProd.Controls.Add(this.textBoxCantMin);
            this.groupBoxNvoProd.Controls.Add(this.label1);
            this.groupBoxNvoProd.Controls.Add(this.textBoDetalle);
            this.groupBoxNvoProd.Location = new System.Drawing.Point(25, 60);
            this.groupBoxNvoProd.Name = "groupBoxNvoProd";
            this.groupBoxNvoProd.Size = new System.Drawing.Size(436, 279);
            this.groupBoxNvoProd.TabIndex = 4;
            this.groupBoxNvoProd.TabStop = false;
            this.groupBoxNvoProd.Text = "Nuevo Producto";
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(117, 137);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(266, 21);
            this.comboTipo.TabIndex = 3;
            // 
            // comboMedida
            // 
            this.comboMedida.FormattingEnabled = true;
            this.comboMedida.Location = new System.Drawing.Point(117, 102);
            this.comboMedida.Name = "comboMedida";
            this.comboMedida.Size = new System.Drawing.Size(266, 21);
            this.comboMedida.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo";
            // 
            // comboMarca
            // 
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(117, 67);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(266, 21);
            this.comboMarca.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Medida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad Disponible";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Precio Unitario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad Minima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Marca";
            // 
            // textBoxCantDisp
            // 
            this.textBoxCantDisp.Location = new System.Drawing.Point(160, 172);
            this.textBoxCantDisp.Name = "textBoxCantDisp";
            this.textBoxCantDisp.Size = new System.Drawing.Size(223, 20);
            this.textBoxCantDisp.TabIndex = 4;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(160, 241);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(223, 20);
            this.textBoxPrecio.TabIndex = 6;
            // 
            // textBoxCantMin
            // 
            this.textBoxCantMin.Location = new System.Drawing.Point(160, 207);
            this.textBoxCantMin.Name = "textBoxCantMin";
            this.textBoxCantMin.Size = new System.Drawing.Size(223, 20);
            this.textBoxCantMin.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Detalle";
            // 
            // textBoDetalle
            // 
            this.textBoDetalle.Location = new System.Drawing.Point(117, 32);
            this.textBoDetalle.Name = "textBoDetalle";
            this.textBoDetalle.Size = new System.Drawing.Size(266, 20);
            this.textBoDetalle.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(246, 345);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 74);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nuevo Producto";
            // 
            // NuevoProductoDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 431);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBoxNvoProd);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "NuevoProductoDialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Producto";
            this.groupBoxNvoProd.ResumeLayout(false);
            this.groupBoxNvoProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBoxNvoProd;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.ComboBox comboMedida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCantDisp;
        private System.Windows.Forms.TextBox textBoxCantMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoDetalle;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label label11;
    }
}