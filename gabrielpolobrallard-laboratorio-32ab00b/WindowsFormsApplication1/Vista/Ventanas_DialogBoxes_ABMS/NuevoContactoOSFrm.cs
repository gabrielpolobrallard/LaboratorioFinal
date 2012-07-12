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
    public partial class NuevoContactoOSFrm : Form
    {
        Boolean modificar = false;
        public int osid = 0;
        private int amodif=0;
        public NuevoContactoOSFrm(int id = 0)
        {
            InitializeComponent();
            amodif = id;
            switch (id)
            {

                case 0:
                    {
                        modificar = false;
                        break;
                    }
                default:
                    {
                        modificar = true;
                        cargardatos(amodif);
                        break;
                    };
            }




        }

        private void cargardatos(int osidx)
        {
            using (var ctx = new LabDBEntities())
            {
                textBoxNombre.Text = ctx.tb_Contacto_ObraSocial.Find(osidx).nombre.ToString();
                textBoxApe.Text = ctx.tb_Contacto_ObraSocial.Find(osidx).apellido;
                textBoxCargo.Text = ctx.tb_Contacto_ObraSocial.Find(osidx).cargo;
                textBoxTel1.Text = ctx.tb_Contacto_ObraSocial.Find(osidx).telefono1;
                textBoxTel2.Text = ctx.tb_Contacto_ObraSocial.Find(osidx).telefono2;
                textBoxCel.Text = ctx.tb_Contacto_ObraSocial.Find(osidx).celular;
                textBoxEmail1.Text = ctx.tb_Contacto_ObraSocial.Find(osidx).email1;
                textBoxEmail1.Text = ctx.tb_Contacto_ObraSocial.Find(osidx).email1;
                textBoxEmail2.Text = ctx.tb_Contacto_ObraSocial.Find(osidx).email2;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new LabDBEntities())
            {
                if (modificar)
                {
                    ctx.tb_Contacto_ObraSocial.Find(amodif).nombre = textBoxNombre.Text;
                    ctx.tb_Contacto_ObraSocial.Find(amodif).apellido = textBoxApe.Text;
                    ctx.tb_Contacto_ObraSocial.Find(amodif).cargo = textBoxCargo.Text;
                    ctx.tb_Contacto_ObraSocial.Find(amodif).telefono1 = textBoxTel1.Text;
                    ctx.tb_Contacto_ObraSocial.Find(amodif).telefono2 = textBoxTel2.Text;
                    ctx.tb_Contacto_ObraSocial.Find(amodif).celular = textBoxCel.Text;
                    ctx.tb_Contacto_ObraSocial.Find(amodif).email1 = textBoxEmail1.Text;
                    ctx.tb_Contacto_ObraSocial.Find(amodif).email1 = textBoxEmail1.Text;
                    ctx.tb_Contacto_ObraSocial.Find(amodif).email2 = textBoxEmail2.Text;

                    if (ctx.SaveChanges() != 0)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    tb_Contacto_ObraSocial cont = new tb_Contacto_ObraSocial();
                    cont.nombre = textBoxNombre.Text;
                    cont.apellido = textBoxApe.Text;
                    cont.cargo = textBoxCargo.Text;
                    cont.telefono1 = textBoxTel1.Text;
                    cont.telefono2 = textBoxTel2.Text;
                    cont.celular = textBoxCel.Text;
                    cont.email1 = textBoxEmail1.Text;
                    cont.email2 = textBoxEmail2.Text;
                    cont.obra_social_id = osid;

                    ctx.tb_Contacto_ObraSocial.Add(cont);
                    if (ctx.SaveChanges() != 0)
                    {
                        this.DialogResult = DialogResult.OK;
                    }


                }
            }
        }
    }
}
