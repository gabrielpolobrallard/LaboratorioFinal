using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Modelo;

namespace WindowsFormsApplication1.Vista.Ventanas_DialogBoxes_ABMS
{
    public partial class NuevaDonacion : Form
    {
        Boolean modificar = false;
        int idamodif = 0;
        public NuevaDonacion(int id = 0)
        {
            switch (id)
            {
                case 0:
                    {
                        InitializeComponent();
                        comboBoxGrupoSang.Enabled = false;
                        cargarCombodonante();
                        cargarUsuarios();
                        break;
                    }
                default:
                    {
                        this.idamodif = id;
                        this.modificar = true;
                        InitializeComponent();
                        comboBoxGrupoSang.Enabled = true;
                        cargarCombodonante();
                        cargarUsuarios();
                        cargarDatos();
                        cargarcomboGrupo();
                        break;
                    }
            }
        }

        private void cargarDatos()
        {
            using (var ctx = new LabDBEntities())
            {
                comboBoxGrupoSang.Enabled = true;
                textBoxComent.Text = ctx.Donaciones.Find(idamodif).comentario;
                comboBoxBioqui.SelectedValue = ctx.Donaciones.Find(idamodif).bioquimica;
                comboBoxDonante.SelectedValue = ctx.Donaciones.Find(idamodif).donante_id;
                comboBoxGrupoSang.SelectedValue = ctx.Donaciones.Find(idamodif).grupo_id;
                dateTimePicker1.Value = ctx.Donaciones.Find(idamodif).fecha_donacion.Value;
                textBoxLitros.Text = ctx.Donaciones.Find(idamodif).litros.ToString();
            }
        }

        private void cargarUsuarios()
        {
            using (var ctx = new LabDBEntities())
            {
                SuspendLayout();
                var query2 = from v in ctx.tb_Usuarios
                             select new
                             {
                                 id = v.id_usuario,
                                 nombre = v.nombre + " " + v.apellido
                             };
                comboBoxBioqui.DisplayMember = "nombre";
                comboBoxBioqui.ValueMember = "id";
                comboBoxBioqui.DataSource = query2.ToList();
                comboBoxBioqui.SelectedIndex = -1;
                ResumeLayout();
            }

        }

        private void cargarCombodonante()
        {
            using (var ctx = new LabDBEntities())
            {
                SuspendLayout();
                var query = from v in ctx.tb_Donantes.Where(rew => rew.borrado == 0)
                            select new
                            {
                                id = v.id_donante,
                                nombre = v.nombre + " " + v.apellido
                            };
                comboBoxDonante.DisplayMember = "nombre";
                comboBoxDonante.ValueMember = "id";
                comboBoxDonante.DataSource = query.ToList();
                comboBoxDonante.SelectedIndex = -1;
                ResumeLayout();
            }
        }

        private void comboBoxDonante_SelectionChangeCommitted(object sender, EventArgs e)
        {

            cargarcomboGrupo();
        }

        private void cargarcomboGrupo()
        {

            using (var ctx = new LabDBEntities())
            {
                SuspendLayout();

                int gpid = Convert.ToInt16(ctx.tb_Donantes.Find(Convert.ToInt16(comboBoxDonante.SelectedValue)).grupo_sanguineo_id);


                var query3 = from v in ctx.tb_GrupoSanguineo
                             select new
                             {
                                 id = v.id_grupo,
                                 nombre = v.descripcion
                             };
                comboBoxGrupoSang.DisplayMember = "nombre";
                comboBoxGrupoSang.ValueMember = "id";
                comboBoxGrupoSang.DataSource = query3.ToList();
                comboBoxGrupoSang.SelectedIndex = gpid;
                ResumeLayout();
            }
            comboBoxGrupoSang.Enabled = true;
        }
        //GUARDAR
        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validaciones.Validation.hasValidationErrors(this.Controls))
            {
                using (var ctx = new LabDBEntities())
                {
                    if (!modificar)
                    {
                        Donaciones donacion = new Donaciones();
                        donacion.donante_id = Convert.ToInt16(comboBoxDonante.SelectedValue);
                        donacion.fecha_donacion = dateTimePicker1.Value;
                        donacion.bioquimica = Convert.ToInt16(comboBoxBioqui.SelectedValue);
                        donacion.grupo_id = Convert.ToInt16(comboBoxGrupoSang.SelectedValue);
                        donacion.comentario = textBoxComent.Text;
                        donacion.litros = Convert.ToDecimal(textBoxLitros.Text);
                        donacion.borrado = 0;

                        ctx.Donaciones.Add(donacion);


                    }
                    else
                    {
                        ctx.Donaciones.Find(idamodif).comentario = textBoxComent.Text;
                        ctx.Donaciones.Find(idamodif).bioquimica = Convert.ToInt16(comboBoxBioqui.SelectedValue);
                        ctx.Donaciones.Find(idamodif).donante_id = Convert.ToInt16(comboBoxDonante.SelectedValue);

                        ctx.Donaciones.Find(idamodif).grupo_id = Convert.ToInt16(comboBoxGrupoSang.SelectedValue);
                        ctx.Donaciones.Find(idamodif).fecha_donacion = dateTimePicker1.Value;
                        ctx.Donaciones.Find(idamodif).litros = Convert.ToDecimal(textBoxLitros.Text);
                    }
                    if (ctx.SaveChanges() != 0)
                    {
                        MessageBox.Show("Donacion guardada con exito!");
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void comboBoxDonante_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxDonante.Text == "")
            {
                errorProvider1.SetError(comboBoxDonante, "Campo Requerido!");
                e.Cancel = true;
                return;
            }
        }

        private void comboBoxBioqui_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxBioqui.Text == "")
            {
                errorProvider1.SetError(comboBoxBioqui, "Campo Requerido!");
                e.Cancel = true;
                return;
            }
        }

        private void comboBoxGrupoSang_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxGrupoSang.Text == "")
            {
                errorProvider1.SetError(comboBoxGrupoSang, "Campo Requerido!");
                e.Cancel = true;
                return;
            }
        }

        private void textBoxLitros_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxLitros.Text == "")
            {
                errorProvider1.SetError(textBoxLitros, "Campo Requerido!");
                e.Cancel = true;
                return;
            }
        }

        private void textBoxComent_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxComent.Text == "")
            {
                errorProvider1.SetError(textBoxComent, "Campo Requerido!");
                e.Cancel = true;
                return;
            }
        }
    }
}
