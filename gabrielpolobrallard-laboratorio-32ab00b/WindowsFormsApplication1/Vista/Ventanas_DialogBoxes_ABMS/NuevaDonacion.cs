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
        public NuevaDonacion()
        {
            InitializeComponent();
            comboBoxGrupoSang.Enabled = false;
            cargarCombodonante();
            cargarUsuarios();
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
                                id=v.id_donante,
                                nombre=v.nombre+" "+v.apellido
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
            Donaciones donacion = new Donaciones();
            donacion.donante_id = Convert.ToInt16(comboBoxDonante.SelectedValue);
            donacion.fecha_donacion = dateTimePicker1.Value;
            donacion.bioquimica = Convert.ToInt16(comboBoxBioqui.SelectedValue);
            donacion.grupo_id = Convert.ToInt16(comboBoxGrupoSang.SelectedValue);
            donacion.comentario = textBoxComent.Text;
            using (var ctx = new LabDBEntities())
            {
                ctx.Donaciones.Add(donacion);
                if (ctx.SaveChanges() != 0)
                {
                    MessageBox.Show("Donacion guardada con exito!");
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
