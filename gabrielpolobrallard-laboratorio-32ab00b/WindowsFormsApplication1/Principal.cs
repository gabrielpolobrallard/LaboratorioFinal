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

        private void emitirFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas.FacturacionFrm facfrm = new Vista.Ventanas.FacturacionFrm();
            facfrm.WindowState = FormWindowState.Maximized;
            facfrm.Show();
            
        }

        private void nuevoDonanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.mayoRediseño.DonantesA dna = new Vista.mayoRediseño.DonantesA();
            dna.Show();
        }

        private void actualizarDonanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.mayoRediseño.GestionDonantesFrm dnfrm = new Vista.mayoRediseño.GestionDonantesFrm();
            dnfrm.Show();
        }

        private void imprimirCredencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.seleccionarDonanteImprimirCred sdi= new Vista.Ventanas_DialogBoxes_ABMS.seleccionarDonanteImprimirCred();
            sdi.ShowDialog();
        }

        private void listarDonantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportesLaboratorio.ReporteDonantesWinForm dnfotmr = new ReportesLaboratorio.ReporteDonantesWinForm();
            dnfotmr.Show();
        }

        private void listarUltimosAnálisisRealizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.ListarUltimosAnalisisDialog nvolistUlt = new Vista.Ventanas_DialogBoxes_ABMS.ListarUltimosAnalisisDialog();
            nvolistUlt.ShowDialog();
        }

        private void extraccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas.NvaExtraccion ge = new Vista.Ventanas.NvaExtraccion();
            ge.ShowDialog();
        }

        private void nuevaObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas.GestionOSFrm osfrm = new Vista.Ventanas.GestionOSFrm();
            osfrm.ShowDialog();
        }

        private void laboratoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.GestionLaboratoriosMarcas gst = new Vista.Ventanas_DialogBoxes_ABMS.GestionLaboratoriosMarcas();
            gst.ShowDialog();
        }

        private void nuevaDonacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.NuevaDonacion dona = new Vista.Ventanas_DialogBoxes_ABMS.NuevaDonacion();
            dona.ShowDialog();
        }

        private void listarDonacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.GestorDonaciones don2 = new Vista.Ventanas_DialogBoxes_ABMS.GestorDonaciones();
            don2.ShowDialog();
        }

        private void nomencladorNacionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.GestorNomenclador nvonome = new Vista.Ventanas_DialogBoxes_ABMS.GestorNomenclador();
            nvonome.ShowDialog();
        }

        private void facturacionPorObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.GestorNomenclador nmc = new Vista.Ventanas_DialogBoxes_ABMS.GestorNomenclador();
            nmc.ShowDialog();
        }

        private void gestorExtraccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.GestorExtracciones gexq = new Vista.Ventanas_DialogBoxes_ABMS.GestorExtracciones();
            gexq.ShowDialog();
        }

        private void gestionAnalisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.GestionAnalisisTodos anto = new Vista.Ventanas_DialogBoxes_ABMS.GestionAnalisisTodos();
            anto.ShowDialog();
        }
    }
}
