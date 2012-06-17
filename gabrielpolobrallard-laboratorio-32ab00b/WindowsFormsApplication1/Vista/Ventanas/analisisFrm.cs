using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Vista.Ventanas
{
    public partial class analisisFrm : Form
    {
        private Modelo.LabDBEntities labctx = new Modelo.LabDBEntities();
        private Modelo.tb_Analisis analis1 = new Modelo.tb_Analisis();
        public analisisFrm()
        {
            InitializeComponent();
           

        }

        private void cargaComboEstados()
        {

            detallesComboBox.DataSource = labctx.tb_Estado_Analisis.ToList();
            detallesComboBox.DisplayMember = "detalles";
            detallesComboBox.ValueMember = "id_estado";

        }

        private void tb_Analisis_EnzimologiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_Analisis_EnzimologiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.labDBDataSet);


        }

        private void analisisFrm_Load(object sender, EventArgs e)
        {
            cargaComboEstados();
            tabControlAnalisis.TabPages.Clear();

        }

        private void enzimGuardarBtn_Click(object sender, EventArgs e)
        {
            Modelo.tb_Analisis_Enzimologia enzim = new Modelo.tb_Analisis_Enzimologia();
            enzim.amilasa = Convert.ToInt32(amilasaTextBox.Text);
            enzim.cpk = Convert.ToInt32(cpkTextBox.Text);
            enzim.estado_id = Convert.ToInt32(detallesComboBox.SelectedValue.ToString());
            enzim.fosfatasa_acida_prostatica = Convert.ToInt32(fosfatasa_acida_prostaticaTextBox.Text);
            enzim.fosfatasa_acida_total = Convert.ToInt32(fosfatasa_acida_totalTextBox.Text);
            enzim.fosfatasa_alcalina = Convert.ToInt32(fosfatasa_alcalinaTextBox.Text);
            enzim.gamma_gt = Convert.ToInt32(gamma_gtTextBox.Text);
            enzim.got = Convert.ToInt32(gotTextBox.Text);
            enzim.gpt = Convert.ToInt32(gptTextBox.Text);
            enzim.ldh = Convert.ToInt32(ldhTextBox.Text);
            enzim.lipasa = Convert.ToInt32(lipasaTextBox.Text);
            enzim.snt = Convert.ToInt32(sntTextBox.Text);
            enzim.analisis_id = analis1.id_analisis;
           
            MessageBox.Show("Cambios: " + labctx.SaveChanges());
        }


        //checkboxenzimologia
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (!tabControlAnalisis.TabPages.Contains(EnzimTabPage))
                {
                    tabControlAnalisis.TabPages.Add(EnzimTabPage);
                }
               

            }
            else
            {
                tabControlAnalisis.TabPages.Remove(EnzimTabPage);
            }
        }

        private void checkBoxInmunolog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInmunolog.Checked)
            {
                if (!tabControlAnalisis.TabPages.Contains(InmunTabPage))
                {
                    tabControlAnalisis.TabPages.Add(InmunTabPage);
                }


            }
            else
            {
                tabControlAnalisis.TabPages.Remove(InmunTabPage);
            }
        }

        private void checkBoxHemog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHemog.Checked)
            {
                if (!tabControlAnalisis.TabPages.Contains(HemogTabPage))
                {
                    tabControlAnalisis.TabPages.Add(HemogTabPage);
                }


            }
            else
            {
                tabControlAnalisis.TabPages.Remove(HemogTabPage);
            }

        }

        private void checkBoxHyCoag_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHemog.Checked)
            {
                if (!tabControlAnalisis.TabPages.Contains(HemostaciaYCoagTabPage))
                {
                    tabControlAnalisis.TabPages.Add(HemostaciaYCoagTabPage);
                }


            }
            else
            {
                tabControlAnalisis.TabPages.Remove(HemostaciaYCoagTabPage);
            }

        }


    }
}
