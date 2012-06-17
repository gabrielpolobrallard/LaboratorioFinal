namespace ReportesLaboratorio
{
    partial class ReporteListaPacientes
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
            this.getPacientesTodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabDBDataSet = new ReportesLaboratorio.LabDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getPacientesTodosTableAdapter = new ReportesLaboratorio.LabDBDataSetTableAdapters.getPacientesTodosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getPacientesTodosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // getPacientesTodosBindingSource
            // 
            this.getPacientesTodosBindingSource.DataMember = "getPacientesTodos";
            this.getPacientesTodosBindingSource.DataSource = this.LabDBDataSet;
            // 
            // LabDBDataSet
            // 
            this.LabDBDataSet.DataSetName = "LabDBDataSet";
            this.LabDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getPacientesTodosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportesLaboratorio.listadoPacientesTodosRpt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(495, 354);
            this.reportViewer1.TabIndex = 0;
            // 
            // getPacientesTodosTableAdapter
            // 
            this.getPacientesTodosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteListaPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 354);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteListaPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Pacientes";
            this.Load += new System.EventHandler(this.ReporteListaPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getPacientesTodosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getPacientesTodosBindingSource;
        private LabDBDataSet LabDBDataSet;
        private LabDBDataSetTableAdapters.getPacientesTodosTableAdapter getPacientesTodosTableAdapter;
    }
}