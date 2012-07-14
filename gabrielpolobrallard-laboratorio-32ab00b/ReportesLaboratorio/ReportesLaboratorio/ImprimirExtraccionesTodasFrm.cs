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
    public partial class ImprimirExtraccionesTodasFrm : Form
    {
     
        public ImprimirExtraccionesTodasFrm()
        {
            InitializeComponent();
            
        }

        private void ImprimirExtraccionesTodasFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LabDBDataSet.ImprimirMuestrasTodas' table. You can move, or remove it, as needed.
            this.ImprimirMuestrasTodasTableAdapter.Fill(this.LabDBDataSet.ImprimirMuestrasTodas);

            this.reportViewer1.RefreshReport();
        }
    }
}
