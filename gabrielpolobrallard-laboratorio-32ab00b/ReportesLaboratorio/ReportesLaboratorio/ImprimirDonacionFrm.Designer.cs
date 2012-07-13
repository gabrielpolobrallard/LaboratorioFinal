namespace ReportesLaboratorio
{
    partial class ImprimirDonacionFrm
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
            this.LabDBDataSet = new ReportesLaboratorio.LabDBDataSet();
            this.ImprimirDonacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ImprimirDonacionTableAdapter = new ReportesLaboratorio.LabDBDataSetTableAdapters.ImprimirDonacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LabDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImprimirDonacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ImprimirDonacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportesLaboratorio.ImprimirDonacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(458, 316);
            this.reportViewer1.TabIndex = 0;
            // 
            // LabDBDataSet
            // 
            this.LabDBDataSet.DataSetName = "LabDBDataSet";
            this.LabDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ImprimirDonacionBindingSource
            // 
            this.ImprimirDonacionBindingSource.DataMember = "ImprimirDonacion";
            this.ImprimirDonacionBindingSource.DataSource = this.LabDBDataSet;
            // 
            // ImprimirDonacionTableAdapter
            // 
            this.ImprimirDonacionTableAdapter.ClearBeforeFill = true;
            // 
            // ImprimirDonacionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 316);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ImprimirDonacionFrm";
            this.Text = "ImprimirDonacionFrm";
            this.Load += new System.EventHandler(this.ImprimirDonacionFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LabDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImprimirDonacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ImprimirDonacionBindingSource;
        private LabDBDataSet LabDBDataSet;
        private LabDBDataSetTableAdapters.ImprimirDonacionTableAdapter ImprimirDonacionTableAdapter;
    }
}