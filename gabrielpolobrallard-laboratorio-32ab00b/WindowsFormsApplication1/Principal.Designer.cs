namespace WindowsFormsApplication1
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoDonanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDonanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirCredencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarDonantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.listarDonacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaDonacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionMedicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.análisisClinicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoAnalisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionAnalisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarUltimosAnálisisRealizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gestorExtraccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarInformeDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenadoPorDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenadoPorPrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenadoPorTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoInsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarInsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoInsumoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionPorObraSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialRemitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obraSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaObraSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.laboratoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelStatusPrincipal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.historialNotasDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.donantesToolStripMenuItem,
            this.medicosToolStripMenuItem,
            this.análisisClinicosToolStripMenuItem,
            this.controlInventarioToolStripMenuItem,
            this.facturacionToolStripMenuItem,
            this.administracionToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.nuevoPacienteToolStripMenuItem,
            this.listarPacientesToolStripMenuItem});
            this.pacientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pacientesToolStripMenuItem.Image")));
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("principalToolStripMenuItem.Image")));
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.principalToolStripMenuItem.Text = "Gestion Pacientes";
            this.principalToolStripMenuItem.Click += new System.EventHandler(this.principalToolStripMenuItem_Click);
            // 
            // nuevoPacienteToolStripMenuItem
            // 
            this.nuevoPacienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoPacienteToolStripMenuItem.Image")));
            this.nuevoPacienteToolStripMenuItem.Name = "nuevoPacienteToolStripMenuItem";
            this.nuevoPacienteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.nuevoPacienteToolStripMenuItem.Text = "Nuevo Paciente...";
            this.nuevoPacienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoPacienteToolStripMenuItem_Click);
            // 
            // listarPacientesToolStripMenuItem
            // 
            this.listarPacientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarPacientesToolStripMenuItem.Image")));
            this.listarPacientesToolStripMenuItem.Name = "listarPacientesToolStripMenuItem";
            this.listarPacientesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.listarPacientesToolStripMenuItem.Text = "Listado de Pacientes";
            this.listarPacientesToolStripMenuItem.Click += new System.EventHandler(this.listarPacientesToolStripMenuItem_Click);
            // 
            // donantesToolStripMenuItem
            // 
            this.donantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDonanteToolStripMenuItem,
            this.actualizarDonanteToolStripMenuItem,
            this.imprimirCredencialToolStripMenuItem,
            this.listarDonantesToolStripMenuItem,
            this.toolStripSeparator1,
            this.listarDonacionesToolStripMenuItem,
            this.nuevaDonacionToolStripMenuItem});
            this.donantesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donantesToolStripMenuItem.Image")));
            this.donantesToolStripMenuItem.Name = "donantesToolStripMenuItem";
            this.donantesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.donantesToolStripMenuItem.Text = "Donantes";
            // 
            // nuevoDonanteToolStripMenuItem
            // 
            this.nuevoDonanteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoDonanteToolStripMenuItem.Image")));
            this.nuevoDonanteToolStripMenuItem.Name = "nuevoDonanteToolStripMenuItem";
            this.nuevoDonanteToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.nuevoDonanteToolStripMenuItem.Text = "Nuevo Donante";
            this.nuevoDonanteToolStripMenuItem.Click += new System.EventHandler(this.nuevoDonanteToolStripMenuItem_Click);
            // 
            // actualizarDonanteToolStripMenuItem
            // 
            this.actualizarDonanteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actualizarDonanteToolStripMenuItem.Image")));
            this.actualizarDonanteToolStripMenuItem.Name = "actualizarDonanteToolStripMenuItem";
            this.actualizarDonanteToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.actualizarDonanteToolStripMenuItem.Text = "Gestion Donantes";
            this.actualizarDonanteToolStripMenuItem.Click += new System.EventHandler(this.actualizarDonanteToolStripMenuItem_Click);
            // 
            // imprimirCredencialToolStripMenuItem
            // 
            this.imprimirCredencialToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirCredencialToolStripMenuItem.Image")));
            this.imprimirCredencialToolStripMenuItem.Name = "imprimirCredencialToolStripMenuItem";
            this.imprimirCredencialToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.imprimirCredencialToolStripMenuItem.Text = "Imprimir Credencial";
            this.imprimirCredencialToolStripMenuItem.Click += new System.EventHandler(this.imprimirCredencialToolStripMenuItem_Click);
            // 
            // listarDonantesToolStripMenuItem
            // 
            this.listarDonantesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarDonantesToolStripMenuItem.Image")));
            this.listarDonantesToolStripMenuItem.Name = "listarDonantesToolStripMenuItem";
            this.listarDonantesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.listarDonantesToolStripMenuItem.Text = "Listar Donantes";
            this.listarDonantesToolStripMenuItem.Click += new System.EventHandler(this.listarDonantesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // listarDonacionesToolStripMenuItem
            // 
            this.listarDonacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarDonacionesToolStripMenuItem.Image")));
            this.listarDonacionesToolStripMenuItem.Name = "listarDonacionesToolStripMenuItem";
            this.listarDonacionesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.listarDonacionesToolStripMenuItem.Text = "Gestion Donaciones";
            this.listarDonacionesToolStripMenuItem.Click += new System.EventHandler(this.listarDonacionesToolStripMenuItem_Click);
            // 
            // nuevaDonacionToolStripMenuItem
            // 
            this.nuevaDonacionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevaDonacionToolStripMenuItem.Image")));
            this.nuevaDonacionToolStripMenuItem.Name = "nuevaDonacionToolStripMenuItem";
            this.nuevaDonacionToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.nuevaDonacionToolStripMenuItem.Text = "Nueva Donacion";
            this.nuevaDonacionToolStripMenuItem.Click += new System.EventHandler(this.nuevaDonacionToolStripMenuItem_Click);
            // 
            // medicosToolStripMenuItem
            // 
            this.medicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionMedicosToolStripMenuItem,
            this.nuevoMedicoToolStripMenuItem});
            this.medicosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("medicosToolStripMenuItem.Image")));
            this.medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            this.medicosToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.medicosToolStripMenuItem.Text = "Medicos";
            // 
            // gestionMedicosToolStripMenuItem
            // 
            this.gestionMedicosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionMedicosToolStripMenuItem.Image")));
            this.gestionMedicosToolStripMenuItem.Name = "gestionMedicosToolStripMenuItem";
            this.gestionMedicosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.gestionMedicosToolStripMenuItem.Text = "Gestion Medicos";
            this.gestionMedicosToolStripMenuItem.Click += new System.EventHandler(this.gestionMedicosToolStripMenuItem_Click);
            // 
            // nuevoMedicoToolStripMenuItem
            // 
            this.nuevoMedicoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoMedicoToolStripMenuItem.Image")));
            this.nuevoMedicoToolStripMenuItem.Name = "nuevoMedicoToolStripMenuItem";
            this.nuevoMedicoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.nuevoMedicoToolStripMenuItem.Text = "Nuevo Medico";
            this.nuevoMedicoToolStripMenuItem.Click += new System.EventHandler(this.nuevoMedicoToolStripMenuItem_Click);
            // 
            // análisisClinicosToolStripMenuItem
            // 
            this.análisisClinicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoAnalisisToolStripMenuItem,
            this.gestionAnalisisToolStripMenuItem,
            this.listarUltimosAnálisisRealizadosToolStripMenuItem,
            this.toolStripSeparator2,
            this.gestorExtraccionesToolStripMenuItem,
            this.extraccionesToolStripMenuItem});
            this.análisisClinicosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("análisisClinicosToolStripMenuItem.Image")));
            this.análisisClinicosToolStripMenuItem.Name = "análisisClinicosToolStripMenuItem";
            this.análisisClinicosToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.análisisClinicosToolStripMenuItem.Text = "Análisis Clinicos";
            // 
            // nuevoAnalisisToolStripMenuItem
            // 
            this.nuevoAnalisisToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoAnalisisToolStripMenuItem.Image")));
            this.nuevoAnalisisToolStripMenuItem.Name = "nuevoAnalisisToolStripMenuItem";
            this.nuevoAnalisisToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.nuevoAnalisisToolStripMenuItem.Text = "Nuevo Análisis";
            this.nuevoAnalisisToolStripMenuItem.Click += new System.EventHandler(this.nuevoAnalisisToolStripMenuItem_Click);
            // 
            // gestionAnalisisToolStripMenuItem
            // 
            this.gestionAnalisisToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionAnalisisToolStripMenuItem.Image")));
            this.gestionAnalisisToolStripMenuItem.Name = "gestionAnalisisToolStripMenuItem";
            this.gestionAnalisisToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.gestionAnalisisToolStripMenuItem.Text = "Gestion Analisis";
            this.gestionAnalisisToolStripMenuItem.Click += new System.EventHandler(this.gestionAnalisisToolStripMenuItem_Click);
            // 
            // listarUltimosAnálisisRealizadosToolStripMenuItem
            // 
            this.listarUltimosAnálisisRealizadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarUltimosAnálisisRealizadosToolStripMenuItem.Image")));
            this.listarUltimosAnálisisRealizadosToolStripMenuItem.Name = "listarUltimosAnálisisRealizadosToolStripMenuItem";
            this.listarUltimosAnálisisRealizadosToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.listarUltimosAnálisisRealizadosToolStripMenuItem.Text = "Listar ultimos análisis realizados";
            this.listarUltimosAnálisisRealizadosToolStripMenuItem.Click += new System.EventHandler(this.listarUltimosAnálisisRealizadosToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(238, 6);
            // 
            // gestorExtraccionesToolStripMenuItem
            // 
            this.gestorExtraccionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestorExtraccionesToolStripMenuItem.Image")));
            this.gestorExtraccionesToolStripMenuItem.Name = "gestorExtraccionesToolStripMenuItem";
            this.gestorExtraccionesToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.gestorExtraccionesToolStripMenuItem.Text = "Gestor Extracciones";
            this.gestorExtraccionesToolStripMenuItem.Click += new System.EventHandler(this.gestorExtraccionesToolStripMenuItem_Click);
            // 
            // extraccionesToolStripMenuItem
            // 
            this.extraccionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("extraccionesToolStripMenuItem.Image")));
            this.extraccionesToolStripMenuItem.Name = "extraccionesToolStripMenuItem";
            this.extraccionesToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.extraccionesToolStripMenuItem.Text = "Nueva Extraccion";
            this.extraccionesToolStripMenuItem.Click += new System.EventHandler(this.extraccionesToolStripMenuItem_Click);
            // 
            // controlInventarioToolStripMenuItem
            // 
            this.controlInventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarInformeDeStockToolStripMenuItem,
            this.nuevoInsumoToolStripMenuItem,
            this.historialDeStockToolStripMenuItem});
            this.controlInventarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("controlInventarioToolStripMenuItem.Image")));
            this.controlInventarioToolStripMenuItem.Name = "controlInventarioToolStripMenuItem";
            this.controlInventarioToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.controlInventarioToolStripMenuItem.Text = "Control Inventario";
            // 
            // generarInformeDeStockToolStripMenuItem
            // 
            this.generarInformeDeStockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenadoPorDetalleToolStripMenuItem,
            this.ordenadoPorPrecioToolStripMenuItem,
            this.ordenadoPorTipoToolStripMenuItem,
            this.ordenadoToolStripMenuItem});
            this.generarInformeDeStockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("generarInformeDeStockToolStripMenuItem.Image")));
            this.generarInformeDeStockToolStripMenuItem.Name = "generarInformeDeStockToolStripMenuItem";
            this.generarInformeDeStockToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.generarInformeDeStockToolStripMenuItem.Text = "Generar Informe de Stock";
            // 
            // ordenadoPorDetalleToolStripMenuItem
            // 
            this.ordenadoPorDetalleToolStripMenuItem.Name = "ordenadoPorDetalleToolStripMenuItem";
            this.ordenadoPorDetalleToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ordenadoPorDetalleToolStripMenuItem.Text = "Ordenado por detalle";
            this.ordenadoPorDetalleToolStripMenuItem.Click += new System.EventHandler(this.ordenadoPorDetalleToolStripMenuItem_Click);
            // 
            // ordenadoPorPrecioToolStripMenuItem
            // 
            this.ordenadoPorPrecioToolStripMenuItem.Name = "ordenadoPorPrecioToolStripMenuItem";
            this.ordenadoPorPrecioToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ordenadoPorPrecioToolStripMenuItem.Text = "Ordenado por precio";
            this.ordenadoPorPrecioToolStripMenuItem.Click += new System.EventHandler(this.ordenadoPorPrecioToolStripMenuItem_Click);
            // 
            // ordenadoPorTipoToolStripMenuItem
            // 
            this.ordenadoPorTipoToolStripMenuItem.Name = "ordenadoPorTipoToolStripMenuItem";
            this.ordenadoPorTipoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ordenadoPorTipoToolStripMenuItem.Text = "Ordenado por tipo";
            this.ordenadoPorTipoToolStripMenuItem.Click += new System.EventHandler(this.ordenadoPorTipoToolStripMenuItem_Click);
            // 
            // ordenadoToolStripMenuItem
            // 
            this.ordenadoToolStripMenuItem.Name = "ordenadoToolStripMenuItem";
            this.ordenadoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ordenadoToolStripMenuItem.Text = "Ordenado por marca";
            this.ordenadoToolStripMenuItem.Click += new System.EventHandler(this.ordenadoToolStripMenuItem_Click);
            // 
            // nuevoInsumoToolStripMenuItem
            // 
            this.nuevoInsumoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarInsumoToolStripMenuItem,
            this.nuevoInsumoToolStripMenuItem1});
            this.nuevoInsumoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoInsumoToolStripMenuItem.Image")));
            this.nuevoInsumoToolStripMenuItem.Name = "nuevoInsumoToolStripMenuItem";
            this.nuevoInsumoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.nuevoInsumoToolStripMenuItem.Text = "Insumos";
            this.nuevoInsumoToolStripMenuItem.Click += new System.EventHandler(this.nuevoInsumoToolStripMenuItem_Click);
            // 
            // modificarInsumoToolStripMenuItem
            // 
            this.modificarInsumoToolStripMenuItem.Name = "modificarInsumoToolStripMenuItem";
            this.modificarInsumoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.modificarInsumoToolStripMenuItem.Text = "Gestion Insumos";
            this.modificarInsumoToolStripMenuItem.Click += new System.EventHandler(this.modificarInsumoToolStripMenuItem_Click);
            // 
            // nuevoInsumoToolStripMenuItem1
            // 
            this.nuevoInsumoToolStripMenuItem1.Name = "nuevoInsumoToolStripMenuItem1";
            this.nuevoInsumoToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.nuevoInsumoToolStripMenuItem1.Text = "Nuevo Insumo";
            this.nuevoInsumoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoInsumoToolStripMenuItem1_Click);
            // 
            // historialDeStockToolStripMenuItem
            // 
            this.historialDeStockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("historialDeStockToolStripMenuItem.Image")));
            this.historialDeStockToolStripMenuItem.Name = "historialDeStockToolStripMenuItem";
            this.historialDeStockToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.historialDeStockToolStripMenuItem.Text = "Historial de Stock";
            this.historialDeStockToolStripMenuItem.Click += new System.EventHandler(this.historialDeStockToolStripMenuItem_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emitirFacturaToolStripMenuItem,
            this.facturacionPorObraSocialToolStripMenuItem,
            this.historialRemitosToolStripMenuItem});
            this.facturacionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facturacionToolStripMenuItem.Image")));
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.facturacionToolStripMenuItem.Text = "Facturación";
            // 
            // emitirFacturaToolStripMenuItem
            // 
            this.emitirFacturaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("emitirFacturaToolStripMenuItem.Image")));
            this.emitirFacturaToolStripMenuItem.Name = "emitirFacturaToolStripMenuItem";
            this.emitirFacturaToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.emitirFacturaToolStripMenuItem.Text = "Emitir Remito";
            this.emitirFacturaToolStripMenuItem.Click += new System.EventHandler(this.emitirFacturaToolStripMenuItem_Click);
            // 
            // facturacionPorObraSocialToolStripMenuItem
            // 
            this.facturacionPorObraSocialToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facturacionPorObraSocialToolStripMenuItem.Image")));
            this.facturacionPorObraSocialToolStripMenuItem.Name = "facturacionPorObraSocialToolStripMenuItem";
            this.facturacionPorObraSocialToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.facturacionPorObraSocialToolStripMenuItem.Text = "Registro Facturacion Obra Social";
            this.facturacionPorObraSocialToolStripMenuItem.Click += new System.EventHandler(this.facturacionPorObraSocialToolStripMenuItem_Click);
            // 
            // historialRemitosToolStripMenuItem
            // 
            this.historialRemitosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("historialRemitosToolStripMenuItem.Image")));
            this.historialRemitosToolStripMenuItem.Name = "historialRemitosToolStripMenuItem";
            this.historialRemitosToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.historialRemitosToolStripMenuItem.Text = "Historial Remitos";
            this.historialRemitosToolStripMenuItem.Click += new System.EventHandler(this.historialRemitosToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obraSocialToolStripMenuItem,
            this.toolStripSeparator4,
            this.laboratoriosToolStripMenuItem,
            this.toolStripSeparator3,
            this.comprasToolStripMenuItem,
            this.historialComprasToolStripMenuItem,
            this.historialNotasDePedidoToolStripMenuItem});
            this.administracionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("administracionToolStripMenuItem.Image")));
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // obraSocialToolStripMenuItem
            // 
            this.obraSocialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaObraSocialToolStripMenuItem});
            this.obraSocialToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("obraSocialToolStripMenuItem.Image")));
            this.obraSocialToolStripMenuItem.Name = "obraSocialToolStripMenuItem";
            this.obraSocialToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.obraSocialToolStripMenuItem.Text = "Obra Social";
            // 
            // nuevaObraSocialToolStripMenuItem
            // 
            this.nuevaObraSocialToolStripMenuItem.Name = "nuevaObraSocialToolStripMenuItem";
            this.nuevaObraSocialToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.nuevaObraSocialToolStripMenuItem.Text = "Gestion Obra Social";
            this.nuevaObraSocialToolStripMenuItem.Click += new System.EventHandler(this.nuevaObraSocialToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(226, 6);
            // 
            // laboratoriosToolStripMenuItem
            // 
            this.laboratoriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("laboratoriosToolStripMenuItem.Image")));
            this.laboratoriosToolStripMenuItem.Name = "laboratoriosToolStripMenuItem";
            this.laboratoriosToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.laboratoriosToolStripMenuItem.Text = "Gestion Laboratorios(Marcas)";
            this.laboratoriosToolStripMenuItem.Click += new System.EventHandler(this.laboratoriosToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(226, 6);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("comprasToolStripMenuItem.Image")));
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // historialComprasToolStripMenuItem
            // 
            this.historialComprasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("historialComprasToolStripMenuItem.Image")));
            this.historialComprasToolStripMenuItem.Name = "historialComprasToolStripMenuItem";
            this.historialComprasToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.historialComprasToolStripMenuItem.Text = "Historial Compras";
            this.historialComprasToolStripMenuItem.Click += new System.EventHandler(this.historialComprasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indiceToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // indiceToolStripMenuItem
            // 
            this.indiceToolStripMenuItem.Name = "indiceToolStripMenuItem";
            this.indiceToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.indiceToolStripMenuItem.Text = "Indice";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ...";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.logoutToolStripMenuItem.Text = "Log out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatusPrincipal,
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 712);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelStatusPrincipal
            // 
            this.labelStatusPrincipal.Name = "labelStatusPrincipal";
            this.labelStatusPrincipal.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.labelStatusPrincipal.Size = new System.Drawing.Size(61, 17);
            this.labelStatusPrincipal.Text = "Estado : ";
            this.labelStatusPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 150, 0);
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(150, 17);
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // historialNotasDePedidoToolStripMenuItem
            // 
            this.historialNotasDePedidoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("historialNotasDePedidoToolStripMenuItem.Image")));
            this.historialNotasDePedidoToolStripMenuItem.Name = "historialNotasDePedidoToolStripMenuItem";
            this.historialNotasDePedidoToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.historialNotasDePedidoToolStripMenuItem.Text = "Historial Notas de Pedido";
            this.historialNotasDePedidoToolStripMenuItem.Click += new System.EventHandler(this.historialNotasDePedidoToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoDonanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarDonanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarDonantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirCredencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem análisisClinicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoAnalisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarUltimosAnálisisRealizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarInformeDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoInsumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoInsumoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarInsumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionPorObraSocialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obraSocialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaObraSocialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        protected System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatusPrincipal;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenadoPorDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenadoPorPrecioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenadoPorTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionMedicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoMedicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaDonacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarDonacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem gestorExtraccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionAnalisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialRemitosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem historialNotasDePedidoToolStripMenuItem;

    }
}

