namespace WindowsFormsApplication1.Vista.Ventanas
{
    partial class GestionOSFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionOSFrm));
            this.dgvOS = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevaOs = new System.Windows.Forms.Button();
            this.btnEliminarOs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEliminarContacto = new System.Windows.Forms.Button();
            this.btnNuevoContacto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvContacto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOS
            // 
            this.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOS.Location = new System.Drawing.Point(28, 92);
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOS.Size = new System.Drawing.Size(555, 150);
            this.dgvOS.TabIndex = 0;
            this.dgvOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOS_CellClick);
            this.dgvOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOS_CellContentClick);
            this.dgvOS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOS_CellDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.Controls.Add(this.btnNuevaOs, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminarOs, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(97, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 32);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnNuevaOs
            // 
            this.btnNuevaOs.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaOs.Image")));
            this.btnNuevaOs.Location = new System.Drawing.Point(114, 3);
            this.btnNuevaOs.Name = "btnNuevaOs";
            this.btnNuevaOs.Size = new System.Drawing.Size(75, 23);
            this.btnNuevaOs.TabIndex = 0;
            this.btnNuevaOs.Text = "Nueva";
            this.btnNuevaOs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaOs.UseVisualStyleBackColor = true;
            this.btnNuevaOs.Click += new System.EventHandler(this.btnNuevaOs_Click);
            // 
            // btnEliminarOs
            // 
            this.btnEliminarOs.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarOs.Image")));
            this.btnEliminarOs.Location = new System.Drawing.Point(211, 3);
            this.btnEliminarOs.Name = "btnEliminarOs";
            this.btnEliminarOs.Size = new System.Drawing.Size(72, 23);
            this.btnEliminarOs.TabIndex = 1;
            this.btnEliminarOs.Text = "Eliminar";
            this.btnEliminarOs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarOs.UseVisualStyleBackColor = true;
            this.btnEliminarOs.Click += new System.EventHandler(this.btnEliminarOs_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Obra Social";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnEliminarContacto);
            this.groupBox1.Controls.Add(this.btnNuevoContacto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvContacto);
            this.groupBox1.Controls.Add(this.dgvOS);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 433);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obra Social";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(293, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Gestion de Obras Sociales";
            // 
            // btnEliminarContacto
            // 
            this.btnEliminarContacto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarContacto.Image")));
            this.btnEliminarContacto.Location = new System.Drawing.Point(308, 243);
            this.btnEliminarContacto.Name = "btnEliminarContacto";
            this.btnEliminarContacto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarContacto.TabIndex = 0;
            this.btnEliminarContacto.Text = "Eliminar";
            this.btnEliminarContacto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarContacto.UseVisualStyleBackColor = true;
            // 
            // btnNuevoContacto
            // 
            this.btnNuevoContacto.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoContacto.Image")));
            this.btnNuevoContacto.Location = new System.Drawing.Point(211, 243);
            this.btnNuevoContacto.Name = "btnNuevoContacto";
            this.btnNuevoContacto.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoContacto.TabIndex = 0;
            this.btnNuevoContacto.Text = "Nuevo";
            this.btnNuevoContacto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoContacto.UseVisualStyleBackColor = true;
            this.btnNuevoContacto.Click += new System.EventHandler(this.btnNuevoContacto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contactos";
            // 
            // dgvContacto
            // 
            this.dgvContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacto.Location = new System.Drawing.Point(28, 270);
            this.dgvContacto.Name = "dgvContacto";
            this.dgvContacto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacto.Size = new System.Drawing.Size(555, 150);
            this.dgvContacto.TabIndex = 0;
            this.dgvContacto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacto_CellContentClick);
            // 
            // GestionOSFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 433);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionOSFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Obras Sociales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNuevaOs;
        private System.Windows.Forms.Button btnEliminarOs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarContacto;
        private System.Windows.Forms.Button btnNuevoContacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvContacto;
        private System.Windows.Forms.Label label11;
    }
}