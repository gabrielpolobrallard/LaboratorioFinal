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
    public partial class ImprimirDonacionFrm : Form
    {
        int id = 0;
        public ImprimirDonacionFrm(int id=0)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ImprimirDonacionFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LabDBDataSet.ImprimirDonacion' table. You can move, or remove it, as needed.
            this.ImprimirDonacionTableAdapter.Fill(this.LabDBDataSet.ImprimirDonacion,this.id);

            this.reportViewer1.RefreshReport();
        }
    }
}
