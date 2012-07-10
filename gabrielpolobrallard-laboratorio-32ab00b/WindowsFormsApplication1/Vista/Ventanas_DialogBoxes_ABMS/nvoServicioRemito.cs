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
    public partial class nvoServicioRemito : Form
    {
        public nvoServicioRemito()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var ctx = new LabDBEntities())
            {
                Aux_Precio_Remito aur = new Aux_Precio_Remito();
                aur.detalle = textBoxDetalle.Text;
                aur.precio = Convert.ToDecimal(textBoxPrecio.Text);
                ctx.Aux_Precio_Remito.Add(aur);
                if (ctx.SaveChanges() != 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
            
            }
        }
    }
}
