using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void listarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportesLaboratorio.ReporteListaPacientes rplpac = new ReportesLaboratorio.ReporteListaPacientes();
            rplpac.MdiParent = this;
            rplpac.WindowState = FormWindowState.Maximized;
            rplpac.Show();
        }

        private void ingresarResultadosProtocolosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoInsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.mayoRediseño.PacientesNewForm Frmpprin = new Vista.mayoRediseño.PacientesNewForm();
            Frmpprin.MdiParent = this;
          
            Frmpprin.WindowState = FormWindowState.Maximized;
            Frmpprin.Show();

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas.CompraForm compFrm = new Vista.Ventanas.CompraForm();
            compFrm.MdiParent = this;
            compFrm.WindowState = FormWindowState.Maximized;
            compFrm.Show();
        }

        private void ordenadoPorDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportesLaboratorio.reportedestock stockreportfrm = new ReportesLaboratorio.reportedestock("detalle");
            stockreportfrm.MdiParent = this;
            stockreportfrm.WindowState = FormWindowState.Maximized;
            stockreportfrm.Show();
            
        }

        private void ordenadoPorPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportesLaboratorio.reportedestock stockreportfrm = new ReportesLaboratorio.reportedestock("precio");
            stockreportfrm.MdiParent = this;
            stockreportfrm.WindowState = FormWindowState.Maximized;
            stockreportfrm.Show();
        }

        private void ordenadoPorTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportesLaboratorio.reportedestock stockreportfrm = new ReportesLaboratorio.reportedestock("tipo");
            stockreportfrm.MdiParent = this;
            stockreportfrm.WindowState = FormWindowState.Maximized;
            stockreportfrm.Show();
        }

        private void ordenadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportesLaboratorio.reportedestock stockreportfrm = new ReportesLaboratorio.reportedestock("marca");
            stockreportfrm.MdiParent = this;
            stockreportfrm.WindowState = FormWindowState.Maximized;
            stockreportfrm.Show();
        }

        private void modificarInsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas.ControlStockFrm cstokfrm = new Vista.Ventanas.ControlStockFrm();
            cstokfrm.MdiParent = this;
            cstokfrm.WindowState = FormWindowState.Maximized;
            cstokfrm.Show();
        }

        private void nuevoInsumoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.NuevoProductoDialogBox nvoProdFrm = new Vista.Ventanas_DialogBoxes_ABMS.NuevoProductoDialogBox();
            nvoProdFrm.MdiParent = this;
            nvoProdFrm.WindowState = FormWindowState.Maximized;
            nvoProdFrm.Show();

        }

        private void gestionMedicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas.MedicosForm mdfrm= new Vista.Ventanas.MedicosForm();
            mdfrm.MdiParent = this;
            mdfrm.WindowState = FormWindowState.Maximized;
            mdfrm.Show();
        }

        private void nuevoMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.NvoMedicoForm nvomed = new Vista.Ventanas_DialogBoxes_ABMS.NvoMedicoForm();
            nvomed.MdiParent = this;
           
            nvomed.Show();
        }

        private void nuevoPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Vista.mayoRediseño.Pacientes pac = new Vista.mayoRediseño.Pacientes();
            pac.Show();
        }

        private void nuevoAnalisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas.analisisFrm anfrm = new Vista.Ventanas.analisisFrm();
            anfrm.Show();
        }
    }
}
