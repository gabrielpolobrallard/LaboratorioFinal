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
    public partial class ReporteImprimirCredencial : Form
    {
        int rid = 0;
        public ReporteImprimirCredencial(int id)
        {
            this.rid = id;
            InitializeComponent();
        }

        private void ReporteImprimirCredencial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LabDBDataSet.ReporteCredencial' table. You can move, or remove it, as needed.
            this.ReporteCredencialTableAdapter.Fill(this.LabDBDataSet.ReporteCredencial,this.rid);

            this.reportViewer1.RefreshReport();
        }
    }
}
