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
    public partial class EmitirReporteRemitoFrm : Form
    {
        int idreport = 0;
        public EmitirReporteRemitoFrm(int id=0)
        {
            this.idreport = id;
            InitializeComponent();
        }

        private void EmitirReporteRemitoFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LabDBDataSet.emitirReciboReporte' table. You can move, or remove it, as needed.
            this.emitirReciboReporteTableAdapter.Fill(this.LabDBDataSet.emitirReciboReporte,this.idreport);

            this.reportViewer1.RefreshReport();
        }
    }
}
