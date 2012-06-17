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
    public partial class ReporteListaPacientes : Form
    {
        public ReporteListaPacientes()
        {
            InitializeComponent();
        }

        private void ReporteListaPacientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LabDBDataSet.getPacientesTodos' table. You can move, or remove it, as needed.
            this.getPacientesTodosTableAdapter.Fill(this.LabDBDataSet.getPacientesTodos);

            this.reportViewer1.RefreshReport();
        }
    }
}
