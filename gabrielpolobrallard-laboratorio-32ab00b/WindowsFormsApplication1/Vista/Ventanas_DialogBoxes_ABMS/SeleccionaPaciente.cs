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
    public partial class SeleccionaPaciente : Form
    {

        tb_Pacientes pacienteSel;
        public SeleccionaPaciente()
        {
            InitializeComponent();
            button1.Enabled = false;
            recagarPaciente();
        }

        private void recagarPaciente()
        {
            listViewPacientesPacientesLV.Items.Clear();
            Control.TabControlTodos.ControladorPacientes.CargaPacienteTodos(listViewPacientesPacientesLV);
           

            
        }

        private void listViewPacientesPacientesLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacienteSel = Control.TabControlTodos.ControladorPacientes.CargaPaciente(listViewPacientesPacientesLV.FocusedItem.Text);
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
