using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Modelo;

namespace WindowsFormsApplication1.Vista.mayoRediseño
{
    public partial class DonantesA : Form
    {
        Boolean modificar = false;
        int idAModif = 0;
        Boolean YaEstaGuardado = false;
        tb_Donantes donante = new tb_Donantes();
        public DonantesA()
        {
            InitializeComponent();
            comboBoxPaciente.Enabled = false;
            cargarComboGrupoSang();
        }
        public DonantesA(int id = 0)
        {

            InitializeComponent();
            comboBoxPaciente.Enabled = false;
            cargarComboGrupoSang();
            switch (id)
            {
                case 0:

                    modificar = false;
                    break;

                default: modificar = true;
                    this.idAModif = id;
                    break;
            }
        }


        private void cargarComboGrupoSang()
        {
            using (var ctx = new LabDBEntities())
            {
                var query = from v in ctx.tb_GrupoSanguineo select v;
                comboBoxGrupoSang.DisplayMember = "descripcion";
                comboBoxGrupoSang.ValueMember = "id_grupo";
                comboBoxGrupoSang.DataSource = query.ToList();
                comboBoxGrupoSang.SelectedIndex = -1;

            }
        }

        private void btnGuardarTodo_Click(object sender, EventArgs e)
        {
            if (modificar == false)
            {

                donante.nombre = textBoxNombre.Text;
                donante.apellido = textBoxApellido.Text;
                donante.dni = Convert.ToInt32(textBoxDni.Text);
                donante.fecha_alta = dateTimePickerFechaAlta.Value;
                donante.fecha_nacimiento = dateTimePickerFechaNac.Value;
                donante.grupo_sanguineo_id = Convert.ToInt16(comboBoxGrupoSang.SelectedValue);
                donante.borrado = 0;//No esta borrado
                if (checkBox1.Checked == true)
                {
                    donante.paciente_id = Convert.ToInt16(comboBoxPaciente.SelectedValue);
                    using (var ctx = new LabDBEntities())
                    {
                        ctx.tb_Donantes.Add(donante);
                        if (ctx.SaveChanges() != 0)
                        {
                            ctx.tb_Pacientes.Find(donante.paciente_id).donante_id = donante.id_donante;
                            MessageBox.Show("Donante Guardado con exito.\n Paciente modificado");
                            YaEstaGuardado = true;
                        }
                    }
                }
                else
                {
                    using (var ctx = new LabDBEntities())
                    {
                        ctx.tb_Donantes.Add(donante);
                        if (ctx.SaveChanges() != 0)
                        {
                            MessageBox.Show("Donante Guardado con exito!");
                            YaEstaGuardado = true;
                        }
                    }
                }

            }
            //SI MODIFICAR ES TRUE - MODIFICACION
            else
            {
                using (var ctx = new LabDBEntities())
                {
                    ctx.tb_Donantes.Find(this.idAModif).nombre = textBoxNombre.Text;
                    ctx.tb_Donantes.Find(this.idAModif).apellido = textBoxApellido.Text;
                    ctx.tb_Donantes.Find(this.idAModif).dni = Convert.ToInt32(textBoxDni.Text);
                    ctx.tb_Donantes.Find(this.idAModif).fecha_alta = dateTimePickerFechaAlta.Value;
                    ctx.tb_Donantes.Find(this.idAModif).fecha_nacimiento = dateTimePickerFechaNac.Value;
                    ctx.tb_Donantes.Find(this.idAModif).grupo_sanguineo_id = Convert.ToInt16(comboBoxGrupoSang.SelectedValue);
                    if (checkBox1.Checked == true)
                    {
                        ctx.tb_Donantes.Find(this.idAModif).paciente_id = Convert.ToInt16(comboBoxPaciente.SelectedValue);
                    }
                    if (ctx.SaveChanges() != 0)
                    {

                        MessageBox.Show("Donante Modificado con exito!");
                    }
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                //Cargo combo pacientes
                comboBoxPaciente.Enabled = true;
                using (var ctx = new LabDBEntities())
                {
                    var query = from v in ctx.tb_Pacientes
                                select new
                                {
                                    id = v.id_paciente,
                                    nombre = v.nombre + " " + v.apellido
                                }
                    ;
                    comboBoxPaciente.DisplayMember = "nombre";
                    comboBoxPaciente.ValueMember = "id";
                    comboBoxPaciente.DataSource = query.ToList();
                    comboBoxPaciente.SelectedIndex = -1;
                }

            }
            else
            {

            }
        }

        private void btnGuardarDir_Click(object sender, EventArgs e)
        {
            if (YaEstaGuardado)
            {
                Ventanas_DialogBoxes_ABMS.CargarDireccion dir = new Ventanas_DialogBoxes_ABMS.CargarDireccion(2);
                dir.pacienteId = donante.id_donante;
                if (dir.ShowDialog() == DialogResult.OK)
                {
                    cargarDirecciones();

                }
            }
            else
            {
                MessageBox.Show("Primero Guarde el Donante");
            }

        }

        private void cargarDirecciones()
        {

            if (donante.id_donante != 0)
            {
                dgvDirs.DataSource = donante.tb_DireccionTodos.ToList();

            }
        }

        private void btnGuardarEmail_Click(object sender, EventArgs e)
        {
            if (YaEstaGuardado)
            {
                Vista.Ventanas_DialogBoxes_ABMS.CargarEmailFrm emf = new Ventanas_DialogBoxes_ABMS.CargarEmailFrm(2);
                emf.pacienteSelId = this.donante.id_donante;
                if (emf.ShowDialog() == DialogResult.OK)
                {
                    cargarEmails();
                }
            }
            else
            {
                MessageBox.Show("Primero Guarde el Donante");
            }
        }

        private void cargarEmails()
        {
            if (donante.id_donante != 0)
            {
                dgvEmails.DataSource = donante.tb_EmailsTodos.ToList();

            }
        }

        private void btnGuardarTel_Click(object sender, EventArgs e)
        {
            if (YaEstaGuardado)
            {
                Ventanas_DialogBoxes_ABMS.CargarTelefonoFrm telfm = new Ventanas_DialogBoxes_ABMS.CargarTelefonoFrm(2);
                telfm.pacienteSelId = this.donante.id_donante;
                if (telfm.ShowDialog() == DialogResult.OK)
                {
                    cargarTelefonos();
                }
            }
            else
            {
                MessageBox.Show("Primero Guarde el Donante");
            }
        }

        private void cargarTelefonos()
        {
            if (donante.id_donante != 0)
            {
                dgvTelefonos.DataSource = donante.tb_TelefonosTodos.ToList();

            }
        }
    }
}
