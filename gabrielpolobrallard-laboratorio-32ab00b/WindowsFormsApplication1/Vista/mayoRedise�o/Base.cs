using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Vista.mayoRediseño
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        private void btnMenuPaciente_Click(object sender, EventArgs e)
        {
           PacientesNewForm pform = new PacientesNewForm();
            pform.Show();
            this.Hide();
        }
    }
}
