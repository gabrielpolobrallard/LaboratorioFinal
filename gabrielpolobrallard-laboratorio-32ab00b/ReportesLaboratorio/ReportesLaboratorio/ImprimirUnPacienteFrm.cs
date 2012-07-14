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
    public partial class ImprimirUnPacienteFrm : Form
    {
        int id = 0;
        public ImprimirUnPacienteFrm(int id=0)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ImprimirUnPacienteFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LabDBDataSet.ImprimirUnPaciente' table. You can move, or remove it, as needed.
            this.ImprimirUnPacienteTableAdapter.Fill(this.LabDBDataSet.ImprimirUnPaciente,this.id);

            this.reportViewer1.RefreshReport();
        }
    }
}
