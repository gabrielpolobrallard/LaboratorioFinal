namespace ReportesLaboratorio
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.labDBDataSet = new ReportesLaboratorio.LabDBDataSet();
            this.spreportehormonaxidReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_reporte_hormona_x_id_ReporteTableAdapter = new ReportesLaboratorio.LabDBDataSetTableAdapters.sp_reporte_hormona_x_id_ReporteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.labDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreportehormonaxidReporteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSAnalisis";
            reportDataSource1.Value = this.spreportehormonaxidReporteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportesLaboratorio.Hormonas_x_idFINAL.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(682, 386);
            this.reportViewer1.TabIndex = 0;
            // 
            // labDBDataSet
            // 
            this.labDBDataSet.DataSetName = "LabDBDataSet";
            this.labDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spreportehormonaxidReporteBindingSource
            // 
            this.spreportehormonaxidReporteBindingSource.DataMember = "sp_reporte_hormona_x_id_Reporte";
            this.spreportehormonaxidReporteBindingSource.DataSource = this.labDBDataSet;
            // 
            // sp_reporte_hormona_x_id_ReporteTableAdapter
            // 
            this.sp_reporte_hormona_x_id_ReporteTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 386);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreportehormonaxidReporteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spreportehormonaxidReporteBindingSource;
        private LabDBDataSet labDBDataSet;
        private LabDBDataSetTableAdapters.sp_reporte_hormona_x_id_ReporteTableAdapter sp_reporte_hormona_x_id_ReporteTableAdapter;
        //private LabDBDataSet1 LabDBDataSet1;
        //private LabDBDataSet1TableAdapters.sp_reporte_hormona_x_id_ReporteTableAdapter sp_reporte_hormona_x_id_ReporteTableAdapter;
    }
}

