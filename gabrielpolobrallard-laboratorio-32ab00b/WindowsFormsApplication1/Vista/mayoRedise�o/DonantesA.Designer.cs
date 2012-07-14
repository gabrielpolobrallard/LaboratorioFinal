namespace WindowsFormsApplication1.Vista.mayoRediseño
{
    partial class DonantesA
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiarTodo = new System.Windows.Forms.Button();
            this.btnGuardarTodo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.dgvTelefonos = new System.Windows.Forms.DataGridView();
            this.dgvEmails = new System.Windows.Forms.DataGridView();
            this.dgvDirs = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBorrarTel = new System.Windows.Forms.Button();
            this.btnBorrarEmail = new System.Windows.Forms.Button();
            this.btnBorrarDir = new System.Windows.Forms.Button();
            this.btnGuardarTel = new System.Windows.Forms.Button();
            this.btnGuardarEmail = new System.Windows.Forms.Button();
            this.btnGuardarDir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxGrupoSang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNac = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnImprimirHistorial = new System.Windows.Forms.Button();
            this.dgvHistorialDonaciones = new System.Windows.Forms.DataGridView();
            this.opf = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirs)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialDonaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 514);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnLimpiarTodo);
            this.tabPage1.Controls.Add(this.btnGuardarTodo);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(596, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Imprimir Credencial";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiarTodo
            // 
            this.btnLimpiarTodo.Location = new System.Drawing.Point(243, 453);
            this.btnLimpiarTodo.Name = "btnLimpiarTodo";
            this.btnLimpiarTodo.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarTodo.TabIndex = 2;
            this.btnLimpiarTodo.Text = "Limpiar";
            this.btnLimpiarTodo.UseVisualStyleBackColor = true;
            // 
            // btnGuardarTodo
            // 
            this.btnGuardarTodo.Location = new System.Drawing.Point(162, 453);
            this.btnGuardarTodo.Name = "btnGuardarTodo";
            this.btnGuardarTodo.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarTodo.TabIndex = 1;
            this.btnGuardarTodo.Text = "Guardar";
            this.btnGuardarTodo.UseVisualStyleBackColor = true;
            this.btnGuardarTodo.Click += new System.EventHandler(this.btnGuardarTodo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxFoto);
            this.groupBox1.Controls.Add(this.dgvTelefonos);
            this.groupBox1.Controls.Add(this.dgvEmails);
            this.groupBox1.Controls.Add(this.dgvDirs);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnBorrarTel);
            this.groupBox1.Controls.Add(this.btnBorrarEmail);
            this.groupBox1.Controls.Add(this.btnBorrarDir);
            this.groupBox1.Controls.Add(this.btnGuardarTel);
            this.groupBox1.Controls.Add(this.btnGuardarEmail);
            this.groupBox1.Controls.Add(this.btnGuardarDir);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 440);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Donante";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.InitialImage = null;
            this.pictureBoxFoto.Location = new System.Drawing.Point(336, 17);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(152, 177);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 5;
            this.pictureBoxFoto.TabStop = false;
            // 
            // dgvTelefonos
            // 
            this.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonos.Location = new System.Drawing.Point(350, 213);
            this.dgvTelefonos.Name = "dgvTelefonos";
            this.dgvTelefonos.Size = new System.Drawing.Size(138, 187);
            this.dgvTelefonos.TabIndex = 4;
            // 
            // dgvEmails
            // 
            this.dgvEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmails.Location = new System.Drawing.Point(206, 213);
            this.dgvEmails.Name = "dgvEmails";
            this.dgvEmails.Size = new System.Drawing.Size(138, 187);
            this.dgvEmails.TabIndex = 4;
            // 
            // dgvDirs
            // 
            this.dgvDirs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirs.Location = new System.Drawing.Point(62, 213);
            this.dgvDirs.Name = "dgvDirs";
            this.dgvDirs.Size = new System.Drawing.Size(138, 187);
            this.dgvDirs.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Telefonos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Emails";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Direcciones";
            // 
            // btnBorrarTel
            // 
            this.btnBorrarTel.Image = global::WindowsFormsApplication1.Properties.Resources.Delete16;
            this.btnBorrarTel.Location = new System.Drawing.Point(425, 406);
            this.btnBorrarTel.Name = "btnBorrarTel";
            this.btnBorrarTel.Size = new System.Drawing.Size(41, 23);
            this.btnBorrarTel.TabIndex = 2;
            this.btnBorrarTel.UseVisualStyleBackColor = true;
            // 
            // btnBorrarEmail
            // 
            this.btnBorrarEmail.Image = global::WindowsFormsApplication1.Properties.Resources.Delete16;
            this.btnBorrarEmail.Location = new System.Drawing.Point(277, 406);
            this.btnBorrarEmail.Name = "btnBorrarEmail";
            this.btnBorrarEmail.Size = new System.Drawing.Size(41, 23);
            this.btnBorrarEmail.TabIndex = 2;
            this.btnBorrarEmail.UseVisualStyleBackColor = true;
            // 
            // btnBorrarDir
            // 
            this.btnBorrarDir.Image = global::WindowsFormsApplication1.Properties.Resources.Delete16;
            this.btnBorrarDir.Location = new System.Drawing.Point(127, 406);
            this.btnBorrarDir.Name = "btnBorrarDir";
            this.btnBorrarDir.Size = new System.Drawing.Size(41, 23);
            this.btnBorrarDir.TabIndex = 2;
            this.btnBorrarDir.UseVisualStyleBackColor = true;
            // 
            // btnGuardarTel
            // 
            this.btnGuardarTel.Image = global::WindowsFormsApplication1.Properties.Resources.Add16;
            this.btnGuardarTel.Location = new System.Drawing.Point(378, 406);
            this.btnGuardarTel.Name = "btnGuardarTel";
            this.btnGuardarTel.Size = new System.Drawing.Size(41, 23);
            this.btnGuardarTel.TabIndex = 2;
            this.btnGuardarTel.UseVisualStyleBackColor = true;
            this.btnGuardarTel.Click += new System.EventHandler(this.btnGuardarTel_Click);
            // 
            // btnGuardarEmail
            // 
            this.btnGuardarEmail.Image = global::WindowsFormsApplication1.Properties.Resources.Add16;
            this.btnGuardarEmail.Location = new System.Drawing.Point(230, 406);
            this.btnGuardarEmail.Name = "btnGuardarEmail";
            this.btnGuardarEmail.Size = new System.Drawing.Size(41, 23);
            this.btnGuardarEmail.TabIndex = 2;
            this.btnGuardarEmail.UseVisualStyleBackColor = true;
            this.btnGuardarEmail.Click += new System.EventHandler(this.btnGuardarEmail_Click);
            // 
            // btnGuardarDir
            // 
            this.btnGuardarDir.Image = global::WindowsFormsApplication1.Properties.Resources.Add16;
            this.btnGuardarDir.Location = new System.Drawing.Point(80, 406);
            this.btnGuardarDir.Name = "btnGuardarDir";
            this.btnGuardarDir.Size = new System.Drawing.Size(41, 23);
            this.btnGuardarDir.TabIndex = 2;
            this.btnGuardarDir.UseVisualStyleBackColor = true;
            this.btnGuardarDir.Click += new System.EventHandler(this.btnGuardarDir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.89286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.10714F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNombre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxApellido, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDni, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxGrupoSang, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerFechaNac, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerFechaAlta, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxPaciente, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnCargarFoto, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(62, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(271, 177);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(73, 3);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(195, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(73, 23);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(195, 20);
            this.textBoxApellido.TabIndex = 1;
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(73, 43);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(195, 20);
            this.textBoxDni.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Grupo Sanguineo";
            // 
            // comboBoxGrupoSang
            // 
            this.comboBoxGrupoSang.FormattingEnabled = true;
            this.comboBoxGrupoSang.Location = new System.Drawing.Point(73, 83);
            this.comboBoxGrupoSang.Name = "comboBoxGrupoSang";
            this.comboBoxGrupoSang.Size = new System.Drawing.Size(195, 21);
            this.comboBoxGrupoSang.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha de Alta";
            // 
            // dateTimePickerFechaNac
            // 
            this.dateTimePickerFechaNac.Location = new System.Drawing.Point(73, 63);
            this.dateTimePickerFechaNac.Name = "dateTimePickerFechaNac";
            this.dateTimePickerFechaNac.Size = new System.Drawing.Size(195, 20);
            this.dateTimePickerFechaNac.TabIndex = 3;
            // 
            // dateTimePickerFechaAlta
            // 
            this.dateTimePickerFechaAlta.Location = new System.Drawing.Point(73, 103);
            this.dateTimePickerFechaAlta.Name = "dateTimePickerFechaAlta";
            this.dateTimePickerFechaAlta.Size = new System.Drawing.Size(195, 20);
            this.dateTimePickerFechaAlta.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Es Paciente?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point(73, 123);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(195, 21);
            this.comboBoxPaciente.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Foto";
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCargarFoto.Location = new System.Drawing.Point(102, 145);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(136, 23);
            this.btnCargarFoto.TabIndex = 8;
            this.btnCargarFoto.Text = "Cargar Foto";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnImprimirHistorial);
            this.tabPage2.Controls.Add(this.dgvHistorialDonaciones);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(596, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historial de Donaciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // btnImprimirHistorial
            // 
            this.btnImprimirHistorial.Location = new System.Drawing.Point(261, 424);
            this.btnImprimirHistorial.Name = "btnImprimirHistorial";
            this.btnImprimirHistorial.Size = new System.Drawing.Size(75, 23);
            this.btnImprimirHistorial.TabIndex = 1;
            this.btnImprimirHistorial.Text = "Imprimir";
            this.btnImprimirHistorial.UseVisualStyleBackColor = true;
            this.btnImprimirHistorial.Click += new System.EventHandler(this.btnImprimirHistorial_Click);
            // 
            // dgvHistorialDonaciones
            // 
            this.dgvHistorialDonaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorialDonaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialDonaciones.Location = new System.Drawing.Point(47, 39);
            this.dgvHistorialDonaciones.Name = "dgvHistorialDonaciones";
            this.dgvHistorialDonaciones.Size = new System.Drawing.Size(502, 379);
            this.dgvHistorialDonaciones.TabIndex = 0;
            // 
            // opf
            // 
            this.opf.FileName = "openFileDialog1";
            // 
            // DonantesA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 514);
            this.Controls.Add(this.tabControl1);
            this.Name = "DonantesA";
            this.Text = "DonantesA";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirs)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialDonaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBorrarTel;
        private System.Windows.Forms.Button btnBorrarEmail;
        private System.Windows.Forms.Button btnBorrarDir;
        private System.Windows.Forms.Button btnGuardarTel;
        private System.Windows.Forms.Button btnGuardarEmail;
        private System.Windows.Forms.Button btnGuardarDir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxGrupoSang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNac;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaAlta;
        private System.Windows.Forms.Button btnLimpiarTodo;
        private System.Windows.Forms.Button btnGuardarTodo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBoxPaciente;
        private System.Windows.Forms.DataGridView dgvTelefonos;
        private System.Windows.Forms.DataGridView dgvEmails;
        private System.Windows.Forms.DataGridView dgvDirs;
        private System.Windows.Forms.DataGridView dgvHistorialDonaciones;
        private System.Windows.Forms.Button btnImprimirHistorial;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.OpenFileDialog opf;
        private System.Windows.Forms.Button button1;
    }
}