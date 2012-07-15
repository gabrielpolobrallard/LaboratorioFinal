namespace WindowsFormsApplication1.Vista.Ventanas_DialogBoxes_ABMS
{
    partial class GestorDonaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorDonaciones));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnImprimirDonacion = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(562, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(107, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 86);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nueva Donacion";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(231, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 86);
            this.button2.TabIndex = 1;
            this.button2.Text = "Eliminar Donacion";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnImprimirDonacion
            // 
            this.btnImprimirDonacion.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirDonacion.Image")));
            this.btnImprimirDonacion.Location = new System.Drawing.Point(355, 205);
            this.btnImprimirDonacion.Name = "btnImprimirDonacion";
            this.btnImprimirDonacion.Size = new System.Drawing.Size(124, 86);
            this.btnImprimirDonacion.TabIndex = 2;
            this.btnImprimirDonacion.Text = "Imprimir Donacion";
            this.btnImprimirDonacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimirDonacion.UseVisualStyleBackColor = true;
            this.btnImprimirDonacion.Click += new System.EventHandler(this.btnImprimirDonacion_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(246, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Gestor de Donaciones";
            // 
            // GestorDonaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 295);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnImprimirDonacion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GestorDonaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestorDonaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnImprimirDonacion;
        private System.Windows.Forms.Label label11;
    }
}