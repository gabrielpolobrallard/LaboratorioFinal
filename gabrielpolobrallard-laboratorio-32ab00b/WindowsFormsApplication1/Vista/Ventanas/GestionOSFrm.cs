using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Modelo;
namespace WindowsFormsApplication1.Vista.Ventanas
{
    public partial class GestionOSFrm : Form
    {
        public GestionOSFrm()
        {
            InitializeComponent();
            cargarDatagridOS();
        }

        private void cargarDatagridOS()
        {
            
            using (var ctx = new LabDBEntities())
            {

                var query = from v in ctx.tb_ObraSocial.Where(borr=>borr.borrado==0)
                            select new
                            {
                                id = v.id_obra_social,
                                Razon_Social = v.razon_social,
                                website1 = v.website1,
                                website2 = v.website2

                            };
                dgvOS.DataSource = query.ToList();


            }
        }

        private void cargarContactos(int idx)
        {
            using (var ctx = new LabDBEntities())
            {

                var query2 = from v in ctx.tb_Contacto_ObraSocial.Where(sd=>sd.obra_social_id ==idx)
                             select new
                             {
                                 ID=v.id_contacto,
                                 Nombre=v.nombre,
                                 Apellido=v.apellido,
                                 Cargo=v.cargo,
                                 Telefono_1=v.telefono1,
                                 Telefono_2=v.telefono2,
                                 Celular=v.celular,
                                 Email_1=v.email1,
                                 Email_2=v.email2
                             };
                dgvContacto.DataSource = query2.ToList();
            }

        }

        private void dgvOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void btnNuevoContacto_Click(object sender, EventArgs e)
        {
            Ventanas_DialogBoxes_ABMS.NuevoContactoOSFrm asdd= new Ventanas_DialogBoxes_ABMS.NuevoContactoOSFrm();
            asdd.osid = Convert.ToInt16(dgvOS.CurrentRow.Cells[0].Value);
            if (asdd.ShowDialog() == DialogResult.OK)
            {
                dgvContacto.DataSource = null;
                cargarDatagridOS();

            }
        }

        private void dgvOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

                cargarContactos(Convert.ToInt16(dgvOS.CurrentRow.Cells[0].Value));
            
        }

        private void dgvContacto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Ventanas_DialogBoxes_ABMS.NuevoContactoOSFrm asdd = new Ventanas_DialogBoxes_ABMS.NuevoContactoOSFrm(Convert.ToInt16(dgvContacto.CurrentRow.Cells[0].Value));
            asdd.osid = Convert.ToInt16(dgvOS.CurrentRow.Cells[0].Value);
            if (asdd.ShowDialog() == DialogResult.OK)
            {
                dgvContacto.DataSource = null;
                cargarDatagridOS();

            }
        }

        private void btnEliminarOs_Click(object sender, EventArgs e)
        {
            if (dgvOS.SelectedRows.Count >0)
            {
                using (var ctx = new LabDBEntities())
                {
                    ctx.tb_ObraSocial.Find(Convert.ToInt16(dgvOS.CurrentRow.Cells[0].Value)).borrado = 1 ;
                    if (ctx.SaveChanges() != 0)
                    {
                        MessageBox.Show("Eliminado con exito");
                        cargarDatagridOS();
                    }
                }

            }
        }

        private void btnNuevaOs_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.NvaOSFrm osnva = new Ventanas_DialogBoxes_ABMS.NvaOSFrm();
            if (osnva.ShowDialog() == DialogResult.OK)
            {
                cargarDatagridOS();
            }
        }

        private void dgvOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.NvaOSFrm osnva = new Ventanas_DialogBoxes_ABMS.NvaOSFrm(Convert.ToInt32(dgvOS.CurrentRow.Cells[0].Value));
            if (osnva.ShowDialog() == DialogResult.OK)
            {
                cargarDatagridOS();
            }
        }

      


    }
}
