namespace WindowsFormsApplication1.Vista.mayoRediseño
{
    partial class Base
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelBaseMenu = new System.Windows.Forms.Panel();
            this.btnMenuPaciente = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panelBaseMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(792, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(109, 17);
            this.statusLabel.Text = "toolStripStatusLabel1";
            // 
            // panelBaseMenu
            // 
            this.panelBaseMenu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panelBaseMenu.Controls.Add(this.btnMenuPaciente);
            this.panelBaseMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBaseMenu.Location = new System.Drawing.Point(0, 0);
            this.panelBaseMenu.Name = "panelBaseMenu";
            this.panelBaseMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelBaseMenu.Size = new System.Drawing.Size(792, 40);
            this.panelBaseMenu.TabIndex = 1;
            // 
            // btnMenuPaciente
            // 
            this.btnMenuPaciente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnMenuPaciente.Location = new System.Drawing.Point(12, 9);
            this.btnMenuPaciente.Name = "btnMenuPaciente";
            this.btnMenuPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnMenuPaciente.TabIndex = 0;
            this.btnMenuPaciente.Text = "Pacientes";
            this.btnMenuPaciente.UseVisualStyleBackColor = false;
            this.btnMenuPaciente.Click += new System.EventHandler(this.btnMenuPaciente_Click);
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.panelBaseMenu);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Base";
            this.Text = "Base";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelBaseMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        protected System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Panel panelBaseMenu;
        private System.Windows.Forms.Button btnMenuPaciente;
    }
}