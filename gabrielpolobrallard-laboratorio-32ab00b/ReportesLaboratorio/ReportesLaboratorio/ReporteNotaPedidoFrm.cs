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
    public partial class ReporteNotaPedidoFrm : Form
    {
        int idpedido = 0;
        public ReporteNotaPedidoFrm(int id=0)
        {
            this.idpedido = id;
            InitializeComponent();
        }

        private void ReporteNotaPedidoFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LabDBDataSet.NotaPedido_x_id' table. You can move, or remove it, as needed.
            this.NotaPedido_x_idTableAdapter.Fill(this.LabDBDataSet.NotaPedido_x_id,idpedido);

            this.reportViewer1.RefreshReport();
        }
    }
}
