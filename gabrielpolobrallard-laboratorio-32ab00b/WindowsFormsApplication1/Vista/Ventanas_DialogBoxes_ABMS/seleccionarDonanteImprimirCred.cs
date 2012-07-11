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
    public partial class seleccionarDonanteImprimirCred : Form
    {
        public seleccionarDonanteImprimirCred()
        {
            InitializeComponent();
            cargarcombo();
        }

        private void cargarcombo()
        {
            using (var ctx = new LabDBEntities())
            {
                var query = from v in ctx.tb_Donantes.Where(easd => easd.borrado == 0)
                            select new
                            {
                                id = v.id_donante,
                                nombre = v.nombre + " " + v.apellido
                            };
                comboBox1.DisplayMember = "nombre";
                comboBox1.ValueMember = "id";
                comboBox1.DataSource = query.ToList();
                comboBox1.SelectedIndex = -1;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportesLaboratorio.ReporteImprimirCredencial nvdr =new  ReportesLaboratorio.ReporteImprimirCredencial(Convert.ToInt16(comboBox1.SelectedValue));
            nvdr.Show();
        }
    }
}
