using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReportesLaboratorio
{
    public partial class ReporteCompraFrm : Form
    {
        int idc = 0;
        public ReporteCompraFrm(int id)
        {

            InitializeComponent();
            this.idc = id;
        }

        private void ReporteCompraFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LabDBDataSet.reporte_compra_x_id' table. You can move, or remove it, as needed.
            this.reporte_compra_x_idTableAdapter.Fill(this.LabDBDataSet.reporte_compra_x_id,idc);

            this.reportViewer1.RefreshReport();
        }
    }
}
