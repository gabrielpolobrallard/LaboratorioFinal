﻿namespace ReportesLaboratorio
{
    partial class ReporteDonantesWinForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LabDBDataSet = new ReportesLaboratorio.LabDBDataSet();
            this.getDonantesTodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getDonantesTodosTableAdapter = new ReportesLaboratorio.LabDBDataSetTableAdapters.getDonantesTodosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LabDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDonantesTodosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.getDonantesTodosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportesLaboratorio.ListaDonantes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // LabDBDataSet
            // 
            this.LabDBDataSet.DataSetName = "LabDBDataSet";
            this.LabDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getDonantesTodosBindingSource
            // 
            this.getDonantesTodosBindingSource.DataMember = "getDonantesTodos";
            this.getDonantesTodosBindingSource.DataSource = this.LabDBDataSet;
            // 
            // getDonantesTodosTableAdapter
            // 
            this.getDonantesTodosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteDonantesWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteDonantesWinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteDonantesWinForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteDonantesWinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LabDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDonantesTodosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getDonantesTodosBindingSource;
        private LabDBDataSet LabDBDataSet;
        private LabDBDataSetTableAdapters.getDonantesTodosTableAdapter getDonantesTodosTableAdapter;
    }
}