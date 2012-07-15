namespace WindowsFormsApplication1.Vista.mayoRediseño
{
    partial class GestionDonantesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDonantesFrm));
            this.panelPacBus = new System.Windows.Forms.Panel();
            this.btnEliminarPac = new System.Windows.Forms.Button();
            this.btnNuevoPac = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnGSReset = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelPacBus.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPacBus
            // 
            this.panelPacBus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelPacBus.Controls.Add(this.btnEliminarPac);
            this.panelPacBus.Controls.Add(this.btnNuevoPac);
            this.panelPacBus.Controls.Add(this.btnGenerarReporte);
            this.panelPacBus.Controls.Add(this.btnGSReset);
            this.panelPacBus.Controls.Add(this.maskedTextBox1);
            this.panelPacBus.Controls.Add(this.label2);
            this.panelPacBus.Controls.Add(this.label3);
            this.panelPacBus.Controls.Add(this.label1);
            this.panelPacBus.Controls.Add(this.comboBox1);
            this.panelPacBus.Controls.Add(this.textBox1);
            this.panelPacBus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPacBus.Location = new System.Drawing.Point(0, 0);
            this.panelPacBus.Name = "panelPacBus";
            this.panelPacBus.Size = new System.Drawing.Size(1050, 100);
            this.panelPacBus.TabIndex = 0;
            // 
            // btnEliminarPac
            // 
            this.btnEliminarPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPac.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarPac.Image")));
            this.btnEliminarPac.Location = new System.Drawing.Point(851, 23);
            this.btnEliminarPac.Name = "btnEliminarPac";
            this.btnEliminarPac.Size = new System.Drawing.Size(75, 55);
            this.btnEliminarPac.TabIndex = 5;
            this.btnEliminarPac.Text = "Eliminar";
            this.btnEliminarPac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminarPac.UseVisualStyleBackColor = true;
            // 
            // btnNuevoPac
            // 
            this.btnNuevoPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPac.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoPac.Image")));
            this.btnNuevoPac.Location = new System.Drawing.Point(770, 23);
            this.btnNuevoPac.Name = "btnNuevoPac";
            this.btnNuevoPac.Size = new System.Drawing.Size(75, 55);
            this.btnNuevoPac.TabIndex = 5;
            this.btnNuevoPac.Text = "Nuevo";
            this.btnNuevoPac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevoPac.UseVisualStyleBackColor = true;
            this.btnNuevoPac.Click += new System.EventHandler(this.btnNuevoPac_Click);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarReporte.Image")));
            this.btnGenerarReporte.Location = new System.Drawing.Point(547, 55);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(203, 23);
            this.btnGenerarReporte.TabIndex = 4;
            this.btnGenerarReporte.Text = "Imprimir Listado Completo";
            this.btnGenerarReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // btnGSReset
            // 
            this.btnGSReset.Location = new System.Drawing.Point(675, 23);
            this.btnGSReset.Name = "btnGSReset";
            this.btnGSReset.Size = new System.Drawing.Size(75, 23);
            this.btnGSReset.TabIndex = 3;
            this.btnGSReset.Text = "Resetear";
            this.btnGSReset.UseVisualStyleBackColor = true;
            this.btnGSReset.Click += new System.EventHandler(this.btnGSReset_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(132, 52);
            this.maskedTextBox1.Mask = "00000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(138, 20);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Grupo Sanguineo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre o Apellido";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(547, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 476);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1050, 476);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            this.dataGridView1.Leave += new System.EventHandler(this.dataGridView1_Leave);
            // 
            // GestionDonantesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelPacBus);
            this.Name = "GestionDonantesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion de Donantes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PacientesNewForm_Load_1);
            this.panelPacBus.ResumeLayout(false);
            this.panelPacBus.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPacBus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnGSReset;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnEliminarPac;
        private System.Windows.Forms.Button btnNuevoPac;
    }
}