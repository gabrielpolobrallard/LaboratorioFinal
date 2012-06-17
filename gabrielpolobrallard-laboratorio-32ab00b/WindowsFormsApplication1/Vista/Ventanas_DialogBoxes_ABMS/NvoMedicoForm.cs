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
    public partial class NvoMedicoForm : Form
    {
        private int modificacion = 0;
        private tb_Medicos med;
        public NvoMedicoForm(int mod=0)
        {
            switch (mod)
            {
                case 0:
                    {
                        this.modificacion = 0;
                        break;
                    }
                default:
                    {
                        this.modificacion = 1;
                        using (var ctx = new LabDBEntities())
                        {
                            this.med = ctx.tb_Medicos.Find(mod);
                        }

                        break;
                    }
            }

            InitializeComponent();
            cargarComboboxes();
            if (this.modificacion != 0) { cargarTextoUpdate(); }
        }

        private void cargarTextoUpdate()
        {
            tbNombre.Text = this.med.nombre;
            tbApellido.Text = this.med.apellido;
            tbDNI.Text = this.med.dni.ToString();
            cbEspecialidad.Text = this.med.tb_Medico_Tipo.detalle;
            try
            {
                tbEmail1.Text = this.med.email1;
                tbEmail2.Text = this.med.email1;
            }
            catch (Exception epx) { }

        }

        private void cargarComboboxes()
        {
            using (var ctx = new LabDBEntities()) 
            {
                cbEspecialidad.SelectedIndex = -1;
                cbEspecialidad.DataSource = ctx.tb_Medico_Tipo.ToList();
                cbEspecialidad.DisplayMember = "detalle";
                cbEspecialidad.ValueMember = "id_tipo_medico"; 
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var ctx = new LabDBEntities())
            {
                if (this.modificacion == 0)
                {
                    this.med = new tb_Medicos();
                }

                else
                {
                    med = ctx.tb_Medicos.Find(this.med.id_medico);
                }
                this.med.nombre = tbNombre.Text;
                this.med.apellido = tbApellido.Text;

                this.med.dni = Convert.ToInt32(tbDNI.Text);
                this.med.especialidad = Convert.ToInt32(cbEspecialidad.SelectedValue);
                try
                {
                    this.med.email1 = tbEmail1.Text;
                    this.med.email2 = tbEmail2.Text;
                }
                catch (Exception ex) { }
                
                this.med.borrado = 0;

                if (this.modificacion == 0)
                {
                    ctx.tb_Medicos.Add(this.med);
                }
                if (ctx.SaveChanges() != 0)
                {
                    if (modificacion == 0)
                    {
                        MessageBox.Show("Medico Guardado Correctamente");
                    }
                    if (modificacion != 0)
                    {
                        MessageBox.Show("Medico Actualizado Correctamente");
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

      
    }
}
