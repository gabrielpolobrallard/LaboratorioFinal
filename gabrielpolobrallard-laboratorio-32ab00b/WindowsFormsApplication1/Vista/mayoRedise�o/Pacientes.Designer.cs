namespace WindowsFormsApplication1.Vista.mayoRediseño
{
    partial class Pacientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label fecha_altaLabel;
            System.Windows.Forms.Label fecha_nacimientoLabel;
            System.Windows.Forms.Label grupo_sanguineoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label id_obra_socialLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxDonante = new System.Windows.Forms.CheckBox();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.comboBoxMedic = new System.Windows.Forms.ComboBox();
            this.comboBoxOs = new System.Windows.Forms.ComboBox();
            this.comboBoxGrupsang = new System.Windows.Forms.ComboBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.textBoxdni = new System.Windows.Forms.TextBox();
            this.fecha_altaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fecha_nacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvEmails = new System.Windows.Forms.DataGridView();
            this.btnrmEmail = new System.Windows.Forms.Button();
            this.btnAddEmail = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTelefonos = new System.Windows.Forms.DataGridView();
            this.btnrmTel = new System.Windows.Forms.Button();
            this.btnAddTel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnrmDir = new System.Windows.Forms.Button();
            this.btnAddDir = new System.Windows.Forms.Button();
            this.dgvDirecciones = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonImprimirAnalisisEspecif = new System.Windows.Forms.Button();
            this.dgvDetallesAnalisisEspecif = new System.Windows.Forms.DataGridView();
            this.dgvAnalisxFechaTodos = new System.Windows.Forms.DataGridView();
            this.fechasolicitudDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idanalisisDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analisisxFechaDetalles2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labDBDataSet = new WindowsFormsApplication1.LabDBDataSet();
            this.dgvHistorialFechas = new System.Windows.Forms.DataGridView();
            this.idanalisisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechasolicitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaentregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getHistorialPacientexidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDiagGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxDiagDetalle = new System.Windows.Forms.TextBox();
            this.textBoxDiagDescrip = new System.Windows.Forms.TextBox();
            this.btnEliminarDiag = new System.Windows.Forms.Button();
            this.btnNuevoDiag = new System.Windows.Forms.Button();
            this.dgvDiagnosticosFechas = new System.Windows.Forms.DataGridView();
            this.spAnalisisSelectBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.spAnalisisSelectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.spAnalisisSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_DireccionTodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_PacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analisisxFechaDetalles1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sp_AnalisisSelectTableAdapter = new WindowsFormsApplication1.LabDBDataSetTableAdapters.sp_AnalisisSelectTableAdapter();
            this.analisis_x_Fecha_Detalles_2TableAdapter = new WindowsFormsApplication1.LabDBDataSetTableAdapters.Analisis_x_Fecha_Detalles_2TableAdapter();
            apellidoLabel = new System.Windows.Forms.Label();
            dniLabel = new System.Windows.Forms.Label();
            fecha_altaLabel = new System.Windows.Forms.Label();
            fecha_nacimientoLabel = new System.Windows.Forms.Label();
            grupo_sanguineoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            id_obra_socialLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmails)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirecciones)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesAnalisisEspecif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisxFechaTodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analisisxFechaDetalles2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialFechas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getHistorialPacientexidBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosticosFechas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAnalisisSelectBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAnalisisSelectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAnalisisSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_DireccionTodosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_PacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analisisxFechaDetalles1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(25, 77);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(46, 13);
            apellidoLabel.TabIndex = 0;
            apellidoLabel.Text = "apellido:";
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(26, 309);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(32, 13);
            dniLabel.TabIndex = 2;
            dniLabel.Text = "sexo:";
            // 
            // fecha_altaLabel
            // 
            fecha_altaLabel.AutoSize = true;
            fecha_altaLabel.Location = new System.Drawing.Point(26, 180);
            fecha_altaLabel.Name = "fecha_altaLabel";
            fecha_altaLabel.Size = new System.Drawing.Size(57, 13);
            fecha_altaLabel.TabIndex = 4;
            fecha_altaLabel.Text = "fecha alta:";
            // 
            // fecha_nacimientoLabel
            // 
            fecha_nacimientoLabel.AutoSize = true;
            fecha_nacimientoLabel.Location = new System.Drawing.Point(26, 141);
            fecha_nacimientoLabel.Name = "fecha_nacimientoLabel";
            fecha_nacimientoLabel.Size = new System.Drawing.Size(91, 13);
            fecha_nacimientoLabel.TabIndex = 6;
            fecha_nacimientoLabel.Text = "fecha nacimiento:";
            // 
            // grupo_sanguineoLabel
            // 
            grupo_sanguineoLabel.AutoSize = true;
            grupo_sanguineoLabel.Location = new System.Drawing.Point(25, 212);
            grupo_sanguineoLabel.Name = "grupo_sanguineoLabel";
            grupo_sanguineoLabel.Size = new System.Drawing.Size(89, 13);
            grupo_sanguineoLabel.TabIndex = 8;
            grupo_sanguineoLabel.Text = "grupo sanguineo:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(26, 40);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 10;
            nombreLabel.Text = "nombre:";
            // 
            // id_obra_socialLabel
            // 
            id_obra_socialLabel.AutoSize = true;
            id_obra_socialLabel.Location = new System.Drawing.Point(26, 252);
            id_obra_socialLabel.Name = "id_obra_socialLabel";
            id_obra_socialLabel.Size = new System.Drawing.Size(58, 13);
            id_obra_socialLabel.TabIndex = 12;
            id_obra_socialLabel.Text = "obra social";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(25, 282);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 13);
            label1.TabIndex = 12;
            label1.Text = "medico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(26, 107);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(24, 13);
            label2.TabIndex = 2;
            label2.Text = "dni:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 615);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.btnGuardarDatos);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1008, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Location = new System.Drawing.Point(627, 331);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(363, 143);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Observaciones";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 81);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Location = new System.Drawing.Point(627, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(363, 303);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Foto";
            // 
            // button1
            // 
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.Zoom_in24;
            this.button1.Location = new System.Drawing.Point(129, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Fredflintstone;
            this.pictureBox1.Location = new System.Drawing.Point(23, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 235);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDatos.Image = global::WindowsFormsApplication1.Properties.Resources.Save48;
            this.btnGuardarDatos.Location = new System.Drawing.Point(450, 492);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(108, 77);
            this.btnGuardarDatos.TabIndex = 2;
            this.btnGuardarDatos.Text = "Guardar";
            this.btnGuardarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardarDatos.UseVisualStyleBackColor = true;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox4.Controls.Add(this.checkBoxDonante);
            this.groupBox4.Controls.Add(this.comboBoxSexo);
            this.groupBox4.Controls.Add(this.comboBoxMedic);
            this.groupBox4.Controls.Add(this.comboBoxOs);
            this.groupBox4.Controls.Add(this.comboBoxGrupsang);
            this.groupBox4.Controls.Add(nombreLabel);
            this.groupBox4.Controls.Add(this.apellidoTextBox);
            this.groupBox4.Controls.Add(apellidoLabel);
            this.groupBox4.Controls.Add(label1);
            this.groupBox4.Controls.Add(this.textBoxdni);
            this.groupBox4.Controls.Add(label2);
            this.groupBox4.Controls.Add(id_obra_socialLabel);
            this.groupBox4.Controls.Add(dniLabel);
            this.groupBox4.Controls.Add(this.fecha_altaDateTimePicker);
            this.groupBox4.Controls.Add(fecha_altaLabel);
            this.groupBox4.Controls.Add(this.nombreTextBox);
            this.groupBox4.Controls.Add(this.fecha_nacimientoDateTimePicker);
            this.groupBox4.Controls.Add(grupo_sanguineoLabel);
            this.groupBox4.Controls.Add(fecha_nacimientoLabel);
            this.groupBox4.Location = new System.Drawing.Point(30, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 452);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Generales";
            // 
            // checkBoxDonante
            // 
            this.checkBoxDonante.AutoSize = true;
            this.checkBoxDonante.Location = new System.Drawing.Point(117, 341);
            this.checkBoxDonante.Name = "checkBoxDonante";
            this.checkBoxDonante.Size = new System.Drawing.Size(65, 17);
            this.checkBoxDonante.TabIndex = 15;
            this.checkBoxDonante.Text = "donante";
            this.checkBoxDonante.UseVisualStyleBackColor = true;
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Location = new System.Drawing.Point(117, 301);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSexo.TabIndex = 16;
            // 
            // comboBoxMedic
            // 
            this.comboBoxMedic.FormattingEnabled = true;
            this.comboBoxMedic.Location = new System.Drawing.Point(117, 274);
            this.comboBoxMedic.Name = "comboBoxMedic";
            this.comboBoxMedic.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMedic.TabIndex = 15;
            // 
            // comboBoxOs
            // 
            this.comboBoxOs.FormattingEnabled = true;
            this.comboBoxOs.Location = new System.Drawing.Point(117, 244);
            this.comboBoxOs.Name = "comboBoxOs";
            this.comboBoxOs.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOs.TabIndex = 14;
            // 
            // comboBoxGrupsang
            // 
            this.comboBoxGrupsang.FormattingEnabled = true;
            this.comboBoxGrupsang.Location = new System.Drawing.Point(117, 209);
            this.comboBoxGrupsang.Name = "comboBoxGrupsang";
            this.comboBoxGrupsang.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGrupsang.TabIndex = 13;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(117, 74);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoTextBox.TabIndex = 9;
            // 
            // textBoxdni
            // 
            this.textBoxdni.Location = new System.Drawing.Point(117, 100);
            this.textBoxdni.Name = "textBoxdni";
            this.textBoxdni.Size = new System.Drawing.Size(100, 20);
            this.textBoxdni.TabIndex = 10;
            // 
            // fecha_altaDateTimePicker
            // 
            this.fecha_altaDateTimePicker.Location = new System.Drawing.Point(117, 174);
            this.fecha_altaDateTimePicker.Name = "fecha_altaDateTimePicker";
            this.fecha_altaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_altaDateTimePicker.TabIndex = 12;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(117, 33);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 8;
            // 
            // fecha_nacimientoDateTimePicker
            // 
            this.fecha_nacimientoDateTimePicker.Location = new System.Drawing.Point(117, 135);
            this.fecha_nacimientoDateTimePicker.Name = "fecha_nacimientoDateTimePicker";
            this.fecha_nacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_nacimientoDateTimePicker.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvEmails);
            this.groupBox3.Controls.Add(this.btnrmEmail);
            this.groupBox3.Controls.Add(this.btnAddEmail);
            this.groupBox3.Location = new System.Drawing.Point(360, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 143);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Email";
            // 
            // dgvEmails
            // 
            this.dgvEmails.AllowUserToAddRows = false;
            this.dgvEmails.AllowUserToDeleteRows = false;
            this.dgvEmails.AllowUserToOrderColumns = true;
            this.dgvEmails.AllowUserToResizeRows = false;
            this.dgvEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmails.Location = new System.Drawing.Point(10, 19);
            this.dgvEmails.Name = "dgvEmails";
            this.dgvEmails.ReadOnly = true;
            this.dgvEmails.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEmails.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmails.Size = new System.Drawing.Size(240, 89);
            this.dgvEmails.TabIndex = 17;
            this.dgvEmails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmails_CellContentClick);
            // 
            // btnrmEmail
            // 
            this.btnrmEmail.Image = global::WindowsFormsApplication1.Properties.Resources.Delete16;
            this.btnrmEmail.Location = new System.Drawing.Point(143, 114);
            this.btnrmEmail.Name = "btnrmEmail";
            this.btnrmEmail.Size = new System.Drawing.Size(75, 23);
            this.btnrmEmail.TabIndex = 1;
            this.btnrmEmail.Text = "-";
            this.btnrmEmail.UseVisualStyleBackColor = true;
            this.btnrmEmail.Click += new System.EventHandler(this.btnrmEmail_Click);
            // 
            // btnAddEmail
            // 
            this.btnAddEmail.Image = global::WindowsFormsApplication1.Properties.Resources.Add16;
            this.btnAddEmail.Location = new System.Drawing.Point(43, 114);
            this.btnAddEmail.Name = "btnAddEmail";
            this.btnAddEmail.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmail.TabIndex = 0;
            this.btnAddEmail.Text = "+";
            this.btnAddEmail.UseVisualStyleBackColor = true;
            this.btnAddEmail.Click += new System.EventHandler(this.btnAddEmail_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTelefonos);
            this.groupBox2.Controls.Add(this.btnrmTel);
            this.groupBox2.Controls.Add(this.btnAddTel);
            this.groupBox2.Location = new System.Drawing.Point(360, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 143);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Telefonos";
            // 
            // dgvTelefonos
            // 
            this.dgvTelefonos.AllowUserToAddRows = false;
            this.dgvTelefonos.AllowUserToDeleteRows = false;
            this.dgvTelefonos.AllowUserToOrderColumns = true;
            this.dgvTelefonos.AllowUserToResizeRows = false;
            this.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonos.Location = new System.Drawing.Point(10, 16);
            this.dgvTelefonos.Name = "dgvTelefonos";
            this.dgvTelefonos.ReadOnly = true;
            this.dgvTelefonos.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTelefonos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefonos.Size = new System.Drawing.Size(240, 89);
            this.dgvTelefonos.TabIndex = 16;
            // 
            // btnrmTel
            // 
            this.btnrmTel.Image = global::WindowsFormsApplication1.Properties.Resources.Delete16;
            this.btnrmTel.Location = new System.Drawing.Point(143, 112);
            this.btnrmTel.Name = "btnrmTel";
            this.btnrmTel.Size = new System.Drawing.Size(75, 23);
            this.btnrmTel.TabIndex = 1;
            this.btnrmTel.Text = "-";
            this.btnrmTel.UseVisualStyleBackColor = true;
            // 
            // btnAddTel
            // 
            this.btnAddTel.Image = global::WindowsFormsApplication1.Properties.Resources.Add16;
            this.btnAddTel.Location = new System.Drawing.Point(43, 112);
            this.btnAddTel.Name = "btnAddTel";
            this.btnAddTel.Size = new System.Drawing.Size(75, 23);
            this.btnAddTel.TabIndex = 0;
            this.btnAddTel.Text = "+";
            this.btnAddTel.UseVisualStyleBackColor = true;
            this.btnAddTel.Click += new System.EventHandler(this.btnAddTel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnrmDir);
            this.groupBox1.Controls.Add(this.btnAddDir);
            this.groupBox1.Controls.Add(this.dgvDirecciones);
            this.groupBox1.Location = new System.Drawing.Point(360, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 143);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direcciones";
            // 
            // btnrmDir
            // 
            this.btnrmDir.Image = ((System.Drawing.Image)(resources.GetObject("btnrmDir.Image")));
            this.btnrmDir.Location = new System.Drawing.Point(143, 111);
            this.btnrmDir.Name = "btnrmDir";
            this.btnrmDir.Size = new System.Drawing.Size(75, 23);
            this.btnrmDir.TabIndex = 1;
            this.btnrmDir.Text = "-";
            this.btnrmDir.UseVisualStyleBackColor = true;
            this.btnrmDir.Click += new System.EventHandler(this.btnrmDir_Click);
            // 
            // btnAddDir
            // 
            this.btnAddDir.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDir.Image")));
            this.btnAddDir.Location = new System.Drawing.Point(43, 111);
            this.btnAddDir.Name = "btnAddDir";
            this.btnAddDir.Size = new System.Drawing.Size(75, 23);
            this.btnAddDir.TabIndex = 0;
            this.btnAddDir.Text = "+";
            this.btnAddDir.UseVisualStyleBackColor = true;
            this.btnAddDir.Click += new System.EventHandler(this.btnAddDir_Click);
            // 
            // dgvDirecciones
            // 
            this.dgvDirecciones.AllowUserToAddRows = false;
            this.dgvDirecciones.AllowUserToDeleteRows = false;
            this.dgvDirecciones.AllowUserToOrderColumns = true;
            this.dgvDirecciones.AllowUserToResizeRows = false;
            this.dgvDirecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirecciones.Location = new System.Drawing.Point(10, 16);
            this.dgvDirecciones.Name = "dgvDirecciones";
            this.dgvDirecciones.ReadOnly = true;
            this.dgvDirecciones.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDirecciones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDirecciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDirecciones.Size = new System.Drawing.Size(240, 89);
            this.dgvDirecciones.TabIndex = 14;
            this.dgvDirecciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDirecciones_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonImprimirAnalisisEspecif);
            this.tabPage2.Controls.Add(this.dgvDetallesAnalisisEspecif);
            this.tabPage2.Controls.Add(this.dgvAnalisxFechaTodos);
            this.tabPage2.Controls.Add(this.dgvHistorialFechas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1008, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historial";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // buttonImprimirAnalisisEspecif
            // 
            this.buttonImprimirAnalisisEspecif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimirAnalisisEspecif.Image = ((System.Drawing.Image)(resources.GetObject("buttonImprimirAnalisisEspecif.Image")));
            this.buttonImprimirAnalisisEspecif.Location = new System.Drawing.Point(439, 425);
            this.buttonImprimirAnalisisEspecif.Name = "buttonImprimirAnalisisEspecif";
            this.buttonImprimirAnalisisEspecif.Size = new System.Drawing.Size(130, 106);
            this.buttonImprimirAnalisisEspecif.TabIndex = 16;
            this.buttonImprimirAnalisisEspecif.Text = "Imprimir";
            this.buttonImprimirAnalisisEspecif.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonImprimirAnalisisEspecif.UseVisualStyleBackColor = true;
            this.buttonImprimirAnalisisEspecif.Click += new System.EventHandler(this.buttonImprimirAnalisisEspecif_Click);
            // 
            // dgvDetallesAnalisisEspecif
            // 
            this.dgvDetallesAnalisisEspecif.AllowUserToAddRows = false;
            this.dgvDetallesAnalisisEspecif.AllowUserToDeleteRows = false;
            this.dgvDetallesAnalisisEspecif.AllowUserToOrderColumns = true;
            this.dgvDetallesAnalisisEspecif.AllowUserToResizeRows = false;
            this.dgvDetallesAnalisisEspecif.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDetallesAnalisisEspecif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesAnalisisEspecif.Location = new System.Drawing.Point(37, 242);
            this.dgvDetallesAnalisisEspecif.MultiSelect = false;
            this.dgvDetallesAnalisisEspecif.Name = "dgvDetallesAnalisisEspecif";
            this.dgvDetallesAnalisisEspecif.ReadOnly = true;
            this.dgvDetallesAnalisisEspecif.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDetallesAnalisisEspecif.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetallesAnalisisEspecif.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetallesAnalisisEspecif.Size = new System.Drawing.Size(963, 175);
            this.dgvDetallesAnalisisEspecif.TabIndex = 15;
            // 
            // dgvAnalisxFechaTodos
            // 
            this.dgvAnalisxFechaTodos.AllowUserToAddRows = false;
            this.dgvAnalisxFechaTodos.AllowUserToDeleteRows = false;
            this.dgvAnalisxFechaTodos.AllowUserToOrderColumns = true;
            this.dgvAnalisxFechaTodos.AllowUserToResizeRows = false;
            this.dgvAnalisxFechaTodos.AutoGenerateColumns = false;
            this.dgvAnalisxFechaTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalisxFechaTodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechasolicitudDataGridViewTextBoxColumn2,
            this.idanalisisDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvAnalisxFechaTodos.DataSource = this.analisisxFechaDetalles2BindingSource;
            this.dgvAnalisxFechaTodos.Location = new System.Drawing.Point(568, 26);
            this.dgvAnalisxFechaTodos.Name = "dgvAnalisxFechaTodos";
            this.dgvAnalisxFechaTodos.ReadOnly = true;
            this.dgvAnalisxFechaTodos.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAnalisxFechaTodos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAnalisxFechaTodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnalisxFechaTodos.Size = new System.Drawing.Size(437, 175);
            this.dgvAnalisxFechaTodos.TabIndex = 15;
            this.dgvAnalisxFechaTodos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnalisxFechaTodos_CellContentClick);
            // 
            // fechasolicitudDataGridViewTextBoxColumn2
            // 
            this.fechasolicitudDataGridViewTextBoxColumn2.DataPropertyName = "fecha_solicitud";
            this.fechasolicitudDataGridViewTextBoxColumn2.HeaderText = "fecha_solicitud";
            this.fechasolicitudDataGridViewTextBoxColumn2.Name = "fechasolicitudDataGridViewTextBoxColumn2";
            this.fechasolicitudDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // idanalisisDataGridViewTextBoxColumn2
            // 
            this.idanalisisDataGridViewTextBoxColumn2.DataPropertyName = "id_analisis";
            this.idanalisisDataGridViewTextBoxColumn2.HeaderText = "id_analisis";
            this.idanalisisDataGridViewTextBoxColumn2.Name = "idanalisisDataGridViewTextBoxColumn2";
            this.idanalisisDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Analisis";
            this.dataGridViewTextBoxColumn2.HeaderText = "Analisis";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tabla";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tabla";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idcampo";
            this.dataGridViewTextBoxColumn4.HeaderText = "idcampo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // analisisxFechaDetalles2BindingSource
            // 
            this.analisisxFechaDetalles2BindingSource.DataMember = "Analisis_x_Fecha_Detalles_2";
            this.analisisxFechaDetalles2BindingSource.DataSource = this.labDBDataSet;
            // 
            // labDBDataSet
            // 
            this.labDBDataSet.DataSetName = "LabDBDataSet";
            this.labDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvHistorialFechas
            // 
            this.dgvHistorialFechas.AllowUserToAddRows = false;
            this.dgvHistorialFechas.AllowUserToDeleteRows = false;
            this.dgvHistorialFechas.AllowUserToOrderColumns = true;
            this.dgvHistorialFechas.AllowUserToResizeRows = false;
            this.dgvHistorialFechas.AutoGenerateColumns = false;
            this.dgvHistorialFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialFechas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idanalisisDataGridViewTextBoxColumn,
            this.fechasolicitudDataGridViewTextBoxColumn,
            this.fechaentregaDataGridViewTextBoxColumn,
            this.detallesDataGridViewTextBoxColumn,
            this.medicoDataGridViewTextBoxColumn});
            this.dgvHistorialFechas.DataSource = this.getHistorialPacientexidBindingSource;
            this.dgvHistorialFechas.Location = new System.Drawing.Point(37, 26);
            this.dgvHistorialFechas.Name = "dgvHistorialFechas";
            this.dgvHistorialFechas.ReadOnly = true;
            this.dgvHistorialFechas.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvHistorialFechas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHistorialFechas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialFechas.Size = new System.Drawing.Size(505, 175);
            this.dgvHistorialFechas.TabIndex = 0;
            this.dgvHistorialFechas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialFechas_CellContentClick);
            // 
            // idanalisisDataGridViewTextBoxColumn
            // 
            this.idanalisisDataGridViewTextBoxColumn.DataPropertyName = "id_analisis";
            this.idanalisisDataGridViewTextBoxColumn.HeaderText = "id_analisis";
            this.idanalisisDataGridViewTextBoxColumn.Name = "idanalisisDataGridViewTextBoxColumn";
            this.idanalisisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechasolicitudDataGridViewTextBoxColumn
            // 
            this.fechasolicitudDataGridViewTextBoxColumn.DataPropertyName = "fecha_solicitud";
            this.fechasolicitudDataGridViewTextBoxColumn.HeaderText = "fecha_solicitud";
            this.fechasolicitudDataGridViewTextBoxColumn.Name = "fechasolicitudDataGridViewTextBoxColumn";
            this.fechasolicitudDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaentregaDataGridViewTextBoxColumn
            // 
            this.fechaentregaDataGridViewTextBoxColumn.DataPropertyName = "fecha_entrega";
            this.fechaentregaDataGridViewTextBoxColumn.HeaderText = "fecha_entrega";
            this.fechaentregaDataGridViewTextBoxColumn.Name = "fechaentregaDataGridViewTextBoxColumn";
            this.fechaentregaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detallesDataGridViewTextBoxColumn
            // 
            this.detallesDataGridViewTextBoxColumn.DataPropertyName = "detalles";
            this.detallesDataGridViewTextBoxColumn.HeaderText = "detalles";
            this.detallesDataGridViewTextBoxColumn.Name = "detallesDataGridViewTextBoxColumn";
            this.detallesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicoDataGridViewTextBoxColumn
            // 
            this.medicoDataGridViewTextBoxColumn.DataPropertyName = "Medico";
            this.medicoDataGridViewTextBoxColumn.HeaderText = "Medico";
            this.medicoDataGridViewTextBoxColumn.Name = "medicoDataGridViewTextBoxColumn";
            this.medicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getHistorialPacientexidBindingSource
            // 
            this.getHistorialPacientexidBindingSource.DataMember = "GetHistorialPaciente_x_id";
            this.getHistorialPacientexidBindingSource.DataSource = this.labDBDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDiagGuardar);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Controls.Add(this.textBoxDiagDetalle);
            this.tabPage3.Controls.Add(this.textBoxDiagDescrip);
            this.tabPage3.Controls.Add(this.btnEliminarDiag);
            this.tabPage3.Controls.Add(this.btnNuevoDiag);
            this.tabPage3.Controls.Add(this.dgvDiagnosticosFechas);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1008, 589);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Diagnosticos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDiagGuardar
            // 
            this.btnDiagGuardar.Location = new System.Drawing.Point(587, 525);
            this.btnDiagGuardar.Name = "btnDiagGuardar";
            this.btnDiagGuardar.Size = new System.Drawing.Size(116, 23);
            this.btnDiagGuardar.TabIndex = 6;
            this.btnDiagGuardar.Text = "Guardar Cambios";
            this.btnDiagGuardar.UseVisualStyleBackColor = true;
            this.btnDiagGuardar.Click += new System.EventHandler(this.btnDiagGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Detalle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(530, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // textBoxDiagDetalle
            // 
            this.textBoxDiagDetalle.Location = new System.Drawing.Point(458, 221);
            this.textBoxDiagDetalle.Multiline = true;
            this.textBoxDiagDetalle.Name = "textBoxDiagDetalle";
            this.textBoxDiagDetalle.Size = new System.Drawing.Size(381, 298);
            this.textBoxDiagDetalle.TabIndex = 3;
            // 
            // textBoxDiagDescrip
            // 
            this.textBoxDiagDescrip.Location = new System.Drawing.Point(530, 150);
            this.textBoxDiagDescrip.Name = "textBoxDiagDescrip";
            this.textBoxDiagDescrip.Size = new System.Drawing.Size(200, 20);
            this.textBoxDiagDescrip.TabIndex = 3;
            // 
            // btnEliminarDiag
            // 
            this.btnEliminarDiag.Image = global::WindowsFormsApplication1.Properties.Resources.Delete16;
            this.btnEliminarDiag.Location = new System.Drawing.Point(514, 16);
            this.btnEliminarDiag.Name = "btnEliminarDiag";
            this.btnEliminarDiag.Size = new System.Drawing.Size(75, 63);
            this.btnEliminarDiag.TabIndex = 2;
            this.btnEliminarDiag.Text = "Eliminar Diagnostico";
            this.btnEliminarDiag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminarDiag.UseVisualStyleBackColor = true;
            this.btnEliminarDiag.Click += new System.EventHandler(this.btnEliminarDiag_Click);
            // 
            // btnNuevoDiag
            // 
            this.btnNuevoDiag.Image = global::WindowsFormsApplication1.Properties.Resources.Add16;
            this.btnNuevoDiag.Location = new System.Drawing.Point(419, 16);
            this.btnNuevoDiag.Name = "btnNuevoDiag";
            this.btnNuevoDiag.Size = new System.Drawing.Size(75, 63);
            this.btnNuevoDiag.TabIndex = 2;
            this.btnNuevoDiag.Text = "Nuevo Diagnostico";
            this.btnNuevoDiag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevoDiag.UseVisualStyleBackColor = true;
            this.btnNuevoDiag.Click += new System.EventHandler(this.btnNuevoDiag_Click);
            // 
            // dgvDiagnosticosFechas
            // 
            this.dgvDiagnosticosFechas.AllowUserToAddRows = false;
            this.dgvDiagnosticosFechas.AllowUserToDeleteRows = false;
            this.dgvDiagnosticosFechas.AllowUserToOrderColumns = true;
            this.dgvDiagnosticosFechas.AllowUserToResizeRows = false;
            this.dgvDiagnosticosFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnosticosFechas.Location = new System.Drawing.Point(28, 16);
            this.dgvDiagnosticosFechas.MultiSelect = false;
            this.dgvDiagnosticosFechas.Name = "dgvDiagnosticosFechas";
            this.dgvDiagnosticosFechas.ReadOnly = true;
            this.dgvDiagnosticosFechas.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDiagnosticosFechas.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDiagnosticosFechas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiagnosticosFechas.Size = new System.Drawing.Size(348, 503);
            this.dgvDiagnosticosFechas.TabIndex = 1;
            this.dgvDiagnosticosFechas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnosticosFechas_CellClick);
            // 
            // spAnalisisSelectBindingSource2
            // 
            this.spAnalisisSelectBindingSource2.DataMember = "sp_AnalisisSelect";
            this.spAnalisisSelectBindingSource2.DataSource = this.labDBDataSet;
            // 
            // spAnalisisSelectBindingSource1
            // 
            this.spAnalisisSelectBindingSource1.DataMember = "sp_AnalisisSelect";
            this.spAnalisisSelectBindingSource1.DataSource = this.labDBDataSet;
            // 
            // spAnalisisSelectBindingSource
            // 
            this.spAnalisisSelectBindingSource.DataMember = "sp_AnalisisSelect";
            this.spAnalisisSelectBindingSource.DataSource = this.labDBDataSet;
            // 
            // tb_DireccionTodosBindingSource
            // 
            this.tb_DireccionTodosBindingSource.DataMember = "tb_DireccionTodos";
            this.tb_DireccionTodosBindingSource.DataSource = this.tb_PacientesBindingSource;
            // 
            // tb_PacientesBindingSource
            // 
            this.tb_PacientesBindingSource.DataSource = typeof(WindowsFormsApplication1.Modelo.tb_Pacientes);
            // 
            // analisisxFechaDetalles1BindingSource1
            // 
            this.analisisxFechaDetalles1BindingSource1.DataMember = "Analisis_x_Fecha_Detalles_1";
            this.analisisxFechaDetalles1BindingSource1.DataSource = this.labDBDataSet;
            // 
            // sp_AnalisisSelectTableAdapter
            // 
            this.sp_AnalisisSelectTableAdapter.ClearBeforeFill = true;
            // 
            // analisis_x_Fecha_Detalles_2TableAdapter
            // 
            this.analisis_x_Fecha_Detalles_2TableAdapter.ClearBeforeFill = true;
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 615);
            this.Controls.Add(this.tabControl1);
            this.Name = "Pacientes";
            this.Text = "Pacientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pacientes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmails)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirecciones)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesAnalisisEspecif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisxFechaTodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analisisxFechaDetalles2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialFechas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getHistorialPacientexidBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosticosFechas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAnalisisSelectBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAnalisisSelectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAnalisisSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_DireccionTodosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_PacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analisisxFechaDetalles1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tb_PacientesBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DateTimePicker fecha_nacimientoDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_altaDateTimePicker;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingSource tb_DireccionTodosBindingSource;
        private System.Windows.Forms.Button btnGuardarDatos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnrmEmail;
        private System.Windows.Forms.Button btnAddEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnrmTel;
        private System.Windows.Forms.Button btnAddTel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnrmDir;
        private System.Windows.Forms.Button btnAddDir;
        private System.Windows.Forms.DataGridView dgvDirecciones;
        private System.Windows.Forms.CheckBox checkBoxDonante;
        private System.Windows.Forms.ComboBox comboBoxMedic;
        private System.Windows.Forms.ComboBox comboBoxOs;
        private System.Windows.Forms.ComboBox comboBoxGrupsang;
        private System.Windows.Forms.DataGridView dgvTelefonos;
        private System.Windows.Forms.DataGridView dgvEmails;
        private System.Windows.Forms.TextBox textBoxdni;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.DataGridView dgvDetallesAnalisisEspecif;
        private System.Windows.Forms.DataGridView dgvAnalisxFechaTodos;
        private System.Windows.Forms.DataGridView dgvHistorialFechas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idanalisisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechasolicitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaentregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detallesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getHistorialPacientexidBindingSource;
        private LabDBDataSet labDBDataSet;
    
        private System.Windows.Forms.DataGridViewTextBoxColumn fechasolicitudDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idanalisisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn analisisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcampoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource analisisxFechaDetalles1BindingSource1;
        private System.Windows.Forms.BindingSource spAnalisisSelectBindingSource;
        private LabDBDataSetTableAdapters.sp_AnalisisSelectTableAdapter sp_AnalisisSelectTableAdapter;
        private System.Windows.Forms.BindingSource spAnalisisSelectBindingSource1;
        private System.Windows.Forms.BindingSource spAnalisisSelectBindingSource2;
        private System.Windows.Forms.Button buttonImprimirAnalisisEspecif;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechasolicitudDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idanalisisDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource analisisxFechaDetalles2BindingSource;
        private LabDBDataSetTableAdapters.Analisis_x_Fecha_Detalles_2TableAdapter analisis_x_Fecha_Detalles_2TableAdapter;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvDiagnosticosFechas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxDiagDetalle;
        private System.Windows.Forms.TextBox textBoxDiagDescrip;
        private System.Windows.Forms.Button btnEliminarDiag;
        private System.Windows.Forms.Button btnNuevoDiag;
        private System.Windows.Forms.Button btnDiagGuardar;

    }
}