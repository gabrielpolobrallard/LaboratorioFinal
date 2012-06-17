namespace ReportesLaboratorio
{
    partial class reportedestock
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_informe_stock_completoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabDBDataSet = new ReportesLaboratorio.LabDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_informe_stock_completoTableAdapter = new ReportesLaboratorio.LabDBDataSetTableAdapters.sp_informe_stock_completoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_informe_stock_completoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_informe_stock_completoBindingSource
            // 
            this.sp_informe_stock_completoBindingSource.DataMember = "sp_informe_stock_completo";
            this.sp_informe_stock_completoBindingSource.DataSource = this.LabDBDataSet;
            // 
            // LabDBDataSet
            // 
            this.LabDBDataSet.DataSetName = "LabDBDataSet";
            this.LabDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.sp_informe_stock_completoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportesLaboratorio.infome_stock_report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(570, 297);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_informe_stock_completoTableAdapter
            // 
            this.sp_informe_stock_completoTableAdapter.ClearBeforeFill = true;
            // 
            // reportedestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 297);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportedestock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "reportedestock";
            this.Load += new System.EventHandler(this.reportedestock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_informe_stock_completoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_informe_stock_completoBindingSource;
        private LabDBDataSet LabDBDataSet;
        private LabDBDataSetTableAdapters.sp_informe_stock_completoTableAdapter sp_informe_stock_completoTableAdapter;
    }
}