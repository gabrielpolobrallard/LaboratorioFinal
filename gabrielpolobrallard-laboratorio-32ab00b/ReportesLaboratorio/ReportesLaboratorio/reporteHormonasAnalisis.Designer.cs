namespace ReportesLaboratorio
{
    partial class reporteHormonasAnalisis
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
            this.sp_reporte_hormona_x_id_ReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabDBDataSet = new ReportesLaboratorio.LabDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_reporte_hormona_x_id_ReporteTableAdapter = new ReportesLaboratorio.LabDBDataSetTableAdapters.sp_reporte_hormona_x_id_ReporteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_reporte_hormona_x_id_ReporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_reporte_hormona_x_id_ReporteBindingSource
            // 
            this.sp_reporte_hormona_x_id_ReporteBindingSource.DataMember = "sp_reporte_hormona_x_id_Reporte";
            this.sp_reporte_hormona_x_id_ReporteBindingSource.DataSource = this.LabDBDataSet;
            // 
            // LabDBDataSet
            // 
            this.LabDBDataSet.DataSetName = "LabDBDataSet";
            this.LabDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSAnalisis";
            reportDataSource1.Value = this.sp_reporte_hormona_x_id_ReporteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportesLaboratorio.Hormonas_x_id.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(648, 423);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_reporte_hormona_x_id_ReporteTableAdapter
            // 
            this.sp_reporte_hormona_x_id_ReporteTableAdapter.ClearBeforeFill = true;
            // 
            // reporteHormonasAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 423);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reporteHormonasAnalisis";
            this.Text = "reporteHormonasAnalisis";
            this.Load += new System.EventHandler(this.reporteHormonasAnalisis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_reporte_hormona_x_id_ReporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_reporte_hormona_x_id_ReporteBindingSource;
        private LabDBDataSet LabDBDataSet;
        private LabDBDataSetTableAdapters.sp_reporte_hormona_x_id_ReporteTableAdapter sp_reporte_hormona_x_id_ReporteTableAdapter;
    }
}