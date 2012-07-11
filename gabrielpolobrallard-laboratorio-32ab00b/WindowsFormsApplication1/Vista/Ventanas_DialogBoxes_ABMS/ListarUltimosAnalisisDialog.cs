using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Vista.Ventanas_DialogBoxes_ABMS
{
    public partial class ListarUltimosAnalisisDialog : Form
    {
        public ListarUltimosAnalisisDialog()
        {
            InitializeComponent();
            cargarCombo();
        }

        private void cargarCombo()
        {
            int p =10;
            comboBox1.Items.Add(1);
            for (int i = 0; i < 10; i++)
            {
                comboBox1.Items.Add(p);
                p+= 10;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportesLaboratorio.ListarUltimosAnalisisForm nuevoUlt = new ReportesLaboratorio.ListarUltimosAnalisisForm(Convert.ToInt16(comboBox1.SelectedItem));
            nuevoUlt.Show();
        }
    }
}
