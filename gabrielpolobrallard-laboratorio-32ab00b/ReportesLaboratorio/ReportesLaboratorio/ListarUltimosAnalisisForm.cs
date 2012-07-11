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
    public partial class ListarUltimosAnalisisForm : Form
    {
        int cant = 0;
        public ListarUltimosAnalisisForm(int cant=0)
        {
            InitializeComponent();
            this.cant = cant;
        }

        private void ListarUltimosAnalisisForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LabDBDataSet.ListarUltimosAnalisis' table. You can move, or remove it, as needed.
            this.ListarUltimosAnalisisTableAdapter.Fill(this.LabDBDataSet.ListarUltimosAnalisis,this.cant);

            this.reportViewer1.RefreshReport();
        }
    }
}
