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
    public partial class reportedestock : Form
    {
        private string opcion = "";
        public reportedestock()
        {
            InitializeComponent();
        }
        public reportedestock(string s)
        {
            this.opcion = s;
            InitializeComponent();
        }

        private void reportedestock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LabDBDataSet.sp_informe_stock_completo' table. You can move, or remove it, as needed.
            this.sp_informe_stock_completoTableAdapter.Fill(this.LabDBDataSet.sp_informe_stock_completo,this.opcion);

            this.reportViewer1.RefreshReport();
        }
    }
}
