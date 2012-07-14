using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Modelo;
using WindowsFormsApplication1.LabDBDataSetTableAdapters;
using System.Data.SqlClient;
using ReportesLaboratorio;

namespace WindowsFormsApplication1.Vista.mayoRediseño
{
    public partial class Pacientes : Form
    {
        private Boolean nuevo;
        private int pCargado;
        private int modificado = 0;
        private int diagidSelected = 0;


        public Pacientes(int id = 0)
        {
            InitializeComponent();
            cargarCombos();

            switch (id)
            {
                case 0:
                    {
                        nuevo = true;
                        tabPage2.Hide();
                        tabPage2.SuspendLayout();
                        btnImprimir.Enabled = false;
                        break;
                    }
                default:
                    {
                        nuevo = false;
                        break;
                    }
            }
            if (nuevo)
            {

            }
            else
            {
                cargarDatosPaciente(id);
                modificado = 1;
                //CARGO DATAGRID HISTORIAL MOVER A TABPAGE



            }

        }

        private void cargarCombos()
        {
            buttonImprimirAnalisisEspecif.Enabled = false;
            using (var ctx = new LabDBEntities())
            {
                //grupo sanguineo
                var gs = from grupos in ctx.tb_GrupoSanguineo
                         select
                             new { id = grupos.id_grupo, descripcion = grupos.descripcion };


                comboBoxGrupsang.DataSource = gs.ToList();
                comboBoxGrupsang.ValueMember = "id";
                comboBoxGrupsang.DisplayMember = "descripcion";

                //OS
                var osCombo = from osc in ctx.tb_ObraSocial
                              select new { id = osc.id_obra_social, nombre = osc.razon_social };
                comboBoxOs.DataSource = osCombo.ToList();
                comboBoxOs.ValueMember = "id";
                comboBoxOs.DisplayMember = "nombre";


                //medico
                var medicComb = from med in ctx.tb_Medicos
                                select new { id = med.id_medico, nombre = med.nombre + " " + med.apellido };
                comboBoxMedic.DataSource = medicComb.ToList();
                comboBoxMedic.ValueMember = "id";
                comboBoxMedic.DisplayMember = "nombre";

                //SEXO
                var SexoComb = from med in ctx.tb_Sexo
                               select new { id = med.id_sexo, nombre = med.descripcion };
                comboBoxSexo.DataSource = SexoComb.ToList();
                comboBoxSexo.ValueMember = "id";
                comboBoxSexo.DisplayMember = "nombre";

            }


        }

        private void cargarDatosPaciente(int idp)
        {
            using (var ctx = new LabDBEntities())
            {
                tb_Pacientes p1 = ctx.tb_Pacientes.Find(idp);
                nombreTextBox.Text = p1.nombre;
                apellidoTextBox.Text = p1.apellido;
                textBoxdni.Text = p1.dni.ToString();
                fecha_nacimientoDateTimePicker.Value = p1.fecha_nacimiento.Value;
                fecha_altaDateTimePicker.Value = p1.fecha_alta.Value;

                comboBoxOs.SelectedValue = p1.tb_ObraSocial.id_obra_social;
                comboBoxMedic.Text = ctx.tb_Medicos.Find(p1.tb_Medicos.id_medico).nombre + " " + ctx.tb_Medicos.Find(p1.tb_Medicos.id_medico).apellido;
                if (p1.es_donante == 1) { checkBoxDonante.Checked = true; }
                comboBoxSexo.SelectedValue = p1.tb_Sexo.id_sexo;
                //cargo direcciones

                var dirs = from di in p1.tb_DireccionTodos.Where(dirw => dirw.borrado == 0)
                           select new
                           {
                               id = di.id_dir,
                               calle = di.calle.ToString(),
                               Descripcion_Departamento = "Dep: " + di.desc_dep + " Nro: " + di.numero_dep,
                               Barrio = di.barrio,
                               Departamento = di.Localidad.Departamento.Nombre,
                               Provincia = di.Localidad.Departamento.Provincia.Nombre
                           };


                dgvDirecciones.DataSource = dirs.OrderBy(ae => ae.calle).ToList();
                dgvDirecciones.Columns[0].Visible = false;
                //Cargo Emails
                //var emails = from di in p1.tb_DireccionTodos
                //           select new
                //           {
                //               calle = di.calle.ToString(),
                //               departamento = di.desc_dep + " " + di.numero_dep,
                //               Barrio = di.barrio,
                //               Departamento = di.Localidad.Departamento,
                //               Provincia = di.Localidad.Departamento.Provincia.Nombre
                //           };


                //dgvDirecciones.DataSource = dirs.OrderBy(ae => ae.calle).ToList();


                var tels = from di in p1.tb_TelefonosTodos
                           select new
                           {
                               di.id_telefono,
                               di.telefono,
                               di.descripcion
                           };


                dgvTelefonos.DataSource = tels.OrderBy(ae => ae.telefono).ToList();
                dgvTelefonos.Columns[0].Visible = false;
                //dgvTelefonos.DataSource = p1.tb_TelefonosTodos;


                //CARGO DGV EMAILS

                var mails = from di in p1.tb_EmailsTodos.Where(em => em.borrado == 0)
                            select new
                            {
                                id = di.id_email,
                                Email = di.email
                            };


                dgvEmails.DataSource = mails.OrderBy(ae => ae.Email).ToList();
                dgvEmails.Columns[0].Visible = false;

                //seteo el id en PCARGADO para usarlo despues
                this.pCargado = idp;






                this.recargarDiagnosticos();



            }
        }


        private void tb_AnalisisBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDirecciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            int id = Convert.ToInt32(this.dgvDirecciones.CurrentRow.Cells[0].Value);
            Vista.Ventanas_DialogBoxes_ABMS.CargarDireccion abmp = new Vista.Ventanas_DialogBoxes_ABMS.CargarDireccion(1, id);
            if (abmp.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnAddDir_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.CargarDireccion nvadir = new Vista.Ventanas_DialogBoxes_ABMS.CargarDireccion(1);

            nvadir.pacienteId = this.pCargado;
            if (nvadir.ShowDialog() == DialogResult.OK)
            {
                cargarDatosPaciente(pCargado);

            }
        }

        private void btnrmDir_Click(object sender, EventArgs e)
        {
            if (dgvDirecciones.SelectedRows.Count == 1)
            {
                using (var ctx = new LabDBEntities())
                {
                    ctx.tb_DireccionTodos.Find(dgvDirecciones.CurrentRow.Cells[0].Value).borrado = 1;
                    if (ctx.SaveChanges() != 0)
                    {
                        cargarDatosPaciente(pCargado);

                    }


                }

            }
        }

        private void btnAddTel_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.CargarTelefonoFrm telfrm = new Vista.Ventanas_DialogBoxes_ABMS.CargarTelefonoFrm(1);
            telfrm.pacienteSelId = pCargado;
            if (telfrm.ShowDialog() == DialogResult.OK)
            {
                cargarDatosPaciente(pCargado);
            }
        }

        private void btnAddEmail_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.CargarEmailFrm emFrm = new Vista.Ventanas_DialogBoxes_ABMS.CargarEmailFrm(1);
            emFrm.pacienteSelId = pCargado;
            if (emFrm.ShowDialog() == DialogResult.OK)
            {
                cargarDatosPaciente(pCargado);
            }

        }

        private void dgvEmails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(this.dgvEmails.CurrentRow.Cells[0].Value);
            Vista.Ventanas_DialogBoxes_ABMS.CargarEmailFrm abmp = new Vista.Ventanas_DialogBoxes_ABMS.CargarEmailFrm(1, id);
            abmp.pacienteSelId = pCargado;
            if (abmp.ShowDialog() == DialogResult.OK)
            {
                cargarDatosPaciente(pCargado);
            }

        }

        private void btnrmEmail_Click(object sender, EventArgs e)
        {
            if (dgvEmails.SelectedRows.Count == 1)
            {
                using (var ctx = new LabDBEntities())
                {
                    ctx.tb_EmailsTodos.Find(dgvEmails.CurrentRow.Cells[0].Value).borrado = 1;
                    if (ctx.SaveChanges() != 0)
                    {
                        cargarDatosPaciente(pCargado);

                    }


                }

            }
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            if (!nuevo)
            {
                using (var ctx = new LabDBEntities())
                {
                    ctx.tb_Pacientes.Find(pCargado).nombre = nombreTextBox.Text;
                    ctx.tb_Pacientes.Find(pCargado).apellido = apellidoTextBox.Text;
                    ctx.tb_Pacientes.Find(pCargado).dni = Convert.ToInt32(textBoxdni.Text);
                    ctx.tb_Pacientes.Find(pCargado).fecha_alta = fecha_altaDateTimePicker.Value;
                    ctx.tb_Pacientes.Find(pCargado).fecha_nacimiento = fecha_nacimientoDateTimePicker.Value;
                    ctx.tb_Pacientes.Find(pCargado).grupo_sanguineo = Convert.ToInt32(comboBoxGrupsang.SelectedValue);
                    ctx.tb_Pacientes.Find(pCargado).medico_id = Convert.ToInt32(comboBoxMedic.SelectedValue);
                    ctx.tb_Pacientes.Find(pCargado).obra_social_id = Convert.ToInt32(comboBoxOs.SelectedValue);
                    ctx.tb_Pacientes.Find(pCargado).es_donante = checkBoxDonante.Checked ? 1 : 0;
                    ctx.tb_Pacientes.Find(pCargado).sexo = Convert.ToInt32(comboBoxSexo.SelectedValue);
                    if (ctx.SaveChanges() != 0)
                    {
                        this.DialogResult = DialogResult.OK;

                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //HISTORIAL
        private void tabPage2_Enter(object sender, EventArgs e)
        {

           
                //CARGO DATAGRID HISTORIAL MOVER A TABPAGE
                buttonImprimirAnalisisEspecif.Enabled = false;
                LabDBDataSet.GetHistorialPaciente_x_idDataTable dataTableHistorialPAciente = new LabDBDataSet.GetHistorialPaciente_x_idDataTable();
                GetHistorialPaciente_x_idTableAdapter da = new GetHistorialPaciente_x_idTableAdapter();
                da.Fill(dataTableHistorialPAciente, pCargado);
                dgvHistorialFechas.DataSource = dataTableHistorialPAciente;
            

        }

        //private void dataGridView1_Click(object sender, EventArgs e)
        //{


        //}

        private void dgvHistorialFechas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDetallesAnalisisEspecif.DataSource = "";
            LabDBDataSet.Analisis_x_Fecha_Detalles_2DataTable dx = new LabDBDataSet.Analisis_x_Fecha_Detalles_2DataTable();
            Analisis_x_Fecha_Detalles_2TableAdapter daxx = new Analisis_x_Fecha_Detalles_2TableAdapter();
            daxx.Fill(dx, Convert.ToInt32(dgvHistorialFechas.CurrentRow.Cells[0].Value), Convert.ToDateTime(dgvHistorialFechas.CurrentRow.Cells[1].Value));
            dgvAnalisxFechaTodos.DataSource = dx;

        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'labDBDataSet.Analisis_x_Fecha_Detalles_1' table. You can move, or remove it, as needed.
            // this.analisis_x_Fecha_Detalles_1TableAdapter.Fill(this.labDBDataSet.Analisis_x_Fecha_Detalles_1);

        }

    

        private void dgvAnalisxFechaTodos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            string conStr = "Data Source=JAVA-NOTEBOOK\\JAVASQLSERVER;Initial Catalog=LabDB;Integrated Security=yeS;User id=sa;Password=admin";
            SqlConnection conn = new SqlConnection(conStr);
            // Open the connection
            conn.Open();

            DataTable dt = new DataTable();


            SqlCommand command = new SqlCommand("sp_AnalisisSelect", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@tipoAnalisisCampo", SqlDbType.NVarChar);
            command.Parameters["@tipoAnalisisCampo"].Value = Convert.ToString(dgvAnalisxFechaTodos.CurrentRow.Cells[3].Value);
            command.Parameters.Add("@idAnalisis", SqlDbType.Int);
            command.Parameters["@idAnalisis"].Value = Convert.ToInt32(dgvAnalisxFechaTodos.CurrentRow.Cells[1].Value);

            command.Parameters.Add("@TablaNombre", SqlDbType.NVarChar);
            command.Parameters["@TablaNombre"].Value = dgvAnalisxFechaTodos.CurrentRow.Cells[4].Value;

            command.Parameters.Add("@idAnalisisEspecifico", SqlDbType.Int);
            command.Parameters["@idAnalisisEspecifico"].Value = Convert.ToInt32(dgvAnalisxFechaTodos.CurrentRow.Cells[5].Value);

            command.Parameters.Add("@fechaAnalisis", SqlDbType.DateTime);
            command.Parameters["@fechaAnalisis"].Value = Convert.ToDateTime(dgvAnalisxFechaTodos.CurrentRow.Cells[0].Value);

            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);


            this.dgvDetallesAnalisisEspecif.DataSource = dt;
            conn.Close();

            //selecciono el datagrid. Le doy focus por si aprietan imprimir.
            if (dgvDetallesAnalisisEspecif.Rows.Count > 0)
            {
                buttonImprimirAnalisisEspecif.Enabled = true;
                dgvDetallesAnalisisEspecif.Select();
            }


        }

        private void buttonImprimirAnalisisEspecif_Click(object sender, EventArgs e)
        {
            if (dgvDetallesAnalisisEspecif.Columns[0].Name.Equals("id_hormonas"))
            {
                ReportesLaboratorio.reporteHormonasAnalisis rptHormFrm = new ReportesLaboratorio.reporteHormonasAnalisis(Convert.ToInt16(dgvDetallesAnalisisEspecif.CurrentRow.Cells[0].Value));
                rptHormFrm.ShowDialog();
            }
            if (dgvDetallesAnalisisEspecif.Columns[0].Name.Equals("id_enzimologia"))
            {
                ReportesLaboratorio.ReporteEnzimologiaAnalisis rptHormFrm = new ReportesLaboratorio.ReporteEnzimologiaAnalisis(Convert.ToInt16(dgvDetallesAnalisisEspecif.CurrentRow.Cells[0].Value));
                rptHormFrm.ShowDialog();
            }
        }

        private void btnNuevoDiag_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.CargarDiagnosticoFrm diagfrm = new Ventanas_DialogBoxes_ABMS.CargarDiagnosticoFrm();
            diagfrm.paciente_id_sel = this.pCargado;
            if (diagfrm.ShowDialog() == DialogResult.OK)
            {
                this.recargarDiagnosticos();
            }
        }

        private void recargarDiagnosticos()
        {
            using (var ctx = new LabDBEntities())
            {
                var diags = from ver in ctx.tb_Diagnosticos.Where(ex => ex.borrado == 0).Where(exed => exed.paciente_id == pCargado).OrderBy(eee => eee.fecha)
                            select new
                            {
                                id = ver.id_diagnostico,
                                Fecha = ver.fecha,
                                Descripcion = ver.descripcion,
                                Detalle = ver.detalle

                            };
                dgvDiagnosticosFechas.DataSource = diags.ToList();
            }
        }

 

        private void btnDiagGuardar_Click(object sender, EventArgs e)
        {
            if (dgvDiagnosticosFechas.SelectedRows.Count > 0)
            {
                if (diagidSelected != 0)
                {
                    using (var ctx = new LabDBEntities())
                    {
                        ctx.tb_Diagnosticos.Find(this.diagidSelected).fecha = dateTimePicker1.Value;
                        ctx.tb_Diagnosticos.Find(this.diagidSelected).descripcion = textBoxDiagDescrip.Text;
                        ctx.tb_Diagnosticos.Find(this.diagidSelected).detalle = textBoxDiagDetalle.Text;
                        if (ctx.SaveChanges() != 0)
                        {
                            MessageBox.Show("Diagnostico Modificado");
                            this.recargarDiagnosticos();
                        
                        }
                    }
                }
            }
        }

        private void dgvDiagnosticosFechas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDiagnosticosFechas.SelectedRows.Count > 0)
            {
                using (var ctx = new LabDBEntities())
                {
                    this.diagidSelected = Convert.ToInt32(dgvDiagnosticosFechas.CurrentRow.Cells[0].Value);
                    dateTimePicker1.Value = ctx.tb_Diagnosticos.Find(Convert.ToInt32(dgvDiagnosticosFechas.CurrentRow.Cells[0].Value)).fecha.Value;
                    textBoxDiagDescrip.Text = ctx.tb_Diagnosticos.Find(Convert.ToInt32(dgvDiagnosticosFechas.CurrentRow.Cells[0].Value)).descripcion;
                    textBoxDiagDetalle.Text = ctx.tb_Diagnosticos.Find(Convert.ToInt32(dgvDiagnosticosFechas.CurrentRow.Cells[0].Value)).detalle;

                }
            }
        }

        private void btnEliminarDiag_Click(object sender, EventArgs e)
        {
            if (dgvDiagnosticosFechas.SelectedRows.Count > 0)
            {
                if (this.diagidSelected != 0)
                {
                    using (var ctx = new LabDBEntities())
                    {

                        ctx.tb_Diagnosticos.Find(this.diagidSelected).borrado = 1;
                        if (ctx.SaveChanges() != 0)
                        {
                            MessageBox.Show("Diagnostico Borrado");
                            this.recargarDiagnosticos();
                        }

                    }
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirUnPacienteFrm frmpa = new ImprimirUnPacienteFrm(pCargado);
            frmpa.Show();
        }



    }
}