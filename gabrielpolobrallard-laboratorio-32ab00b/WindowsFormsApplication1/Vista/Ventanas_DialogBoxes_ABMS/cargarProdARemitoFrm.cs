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
    public partial class cargarProdARemitoFrm : Form
    {
        List<Aux_Precio_Remito> query2 = null;
        public int codigo = 0;
        public string detalle = string.Empty;
        public decimal precio = 0;
        public decimal descuento = 0;
        public int cantidad = 0;
        Boolean primera_carga = true;
        public cargarProdARemitoFrm()
        {
            InitializeComponent();
            cargarComboCodigos();
            primera_carga = false;
        }

        private void cargarComboCodigos()
        {
            using (var ctx = new LabDBEntities())
            {
                var query = from c in ctx.Aux_Precio_Remito select c;
                comboBoxCodigo.DisplayMember = "id_codigo";
                comboBoxCodigo.ValueMember = "id_codigo";
                query2 = query.ToList();
                comboBoxCodigo.DataSource = query2;
                comboBoxCodigo.SelectedIndex = -1;
            }
        }

        private void comboBoxCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCodigo.SelectedIndex != -1 && primera_carga==false)
            {
               var q = from v in query2.Where(eef => eef.id_codigo == Convert.ToInt16(comboBoxCodigo.SelectedValue))
                        select v;
                textBoxDetalle.Text = q.FirstOrDefault().detalle;
                PreciotextBox.Text = q.FirstOrDefault().precio.ToString();
                textBox1.Text = descuento.ToString();
                precio = Convert.ToDecimal(PreciotextBox.Text);
                detalle = textBoxDetalle.Text;
                
                codigo = Convert.ToInt16(comboBoxCodigo.SelectedValue);

            }
        }
        //BOTON AGREGAR
        private void button1_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
        //Descuento
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            descuento = Convert.ToDecimal(textBox1.Text);
        }

        private void CantidadtextBox_TextChanged(object sender, EventArgs e)
        {
            this.cantidad = Convert.ToInt16(CantidadtextBox.Text);
        }

        private void btnNvo_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.nvoServicioRemito nvoserv = new nvoServicioRemito();
            if (nvoserv.ShowDialog() == DialogResult.OK)
            {
                cargarComboCodigos();

            }
        }
    }
}
