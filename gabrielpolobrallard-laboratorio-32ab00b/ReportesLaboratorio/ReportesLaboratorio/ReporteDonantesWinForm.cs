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
    public partial class ReporteDonantesWinForm : Form
    {
        public ReporteDonantesWinForm()
        {
            InitializeComponent();
        }

        private void ReporteDonantesWinForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LabDBDataSet.getDonantesTodos' table. You can move, or remove it, as needed.
            this.getDonantesTodosTableAdapter.Fill(this.LabDBDataSet.getDonantesTodos);

            this.reportViewer1.RefreshReport();
        }
    }
}
