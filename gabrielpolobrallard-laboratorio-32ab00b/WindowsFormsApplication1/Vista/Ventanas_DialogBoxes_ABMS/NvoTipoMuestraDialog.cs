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
    public partial class NvoTipoMuestraDialog : Form
    {
        public NvoTipoMuestraDialog()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new LabDBEntities())
            {

                tb_Muestras_Tipo m = new tb_Muestras_Tipo();
                m.descripcion = textBox1.Text;
                ctx.tb_Muestras_Tipo.Add(m);
                if (ctx.SaveChanges() != 0)
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Tipo de muestra agregado con exito");
                
                }
            }
        }
    }
}
