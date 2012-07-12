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
    public partial class NvaOSFrm : Form
    {
        int idAmodif = 0;
        Boolean modificar = false;
        public NvaOSFrm(int amod = 0)
        {
            InitializeComponent();
            switch (amod)
            {
                case 0:
                    {
                        modificar = false;
                        break;
                    }
                default:
                    {
                        this.idAmodif = amod;
                        modificar = true;
                        cargarDatos();
                        break;
                    }
            }
        }

        private void cargarDatos()
        {
            using (var ctx = new LabDBEntities())
            {
                textBoxRazonSocial.Text = ctx.tb_ObraSocial.Find(idAmodif).razon_social;
                textBoxweb1.Text = ctx.tb_ObraSocial.Find(idAmodif).website1;
                textBoxweb2.Text = ctx.tb_ObraSocial.Find(idAmodif).website2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new LabDBEntities())
            {
                if (!modificar)
                {
                    tb_ObraSocial nvaos = new tb_ObraSocial();
                    nvaos.razon_social = textBoxRazonSocial.Text;
                    nvaos.website1 = textBoxweb1.Text;
                    nvaos.website2 = textBoxweb2.Text;
                    nvaos.borrado = 0;
                    ctx.tb_ObraSocial.Add(nvaos);
                }
                else
                {
                    ctx.tb_ObraSocial.Find(idAmodif).razon_social = textBoxRazonSocial.Text;
                    ctx.tb_ObraSocial.Find(idAmodif).website1 = textBoxweb1.Text;
                    ctx.tb_ObraSocial.Find(idAmodif).website2 = textBoxweb2.Text;
                    ctx.tb_ObraSocial.Find(idAmodif).borrado = 0;
                }
                if (ctx.SaveChanges() != 0)
                {
                    MessageBox.Show("Guardado con exito!");
                    this.DialogResult = DialogResult.OK;

                }
            }
        }
    }
}
