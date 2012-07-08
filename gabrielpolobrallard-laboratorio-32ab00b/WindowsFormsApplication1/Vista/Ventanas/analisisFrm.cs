using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Modelo;
using System.Collections;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.Vista.Ventanas
{
    public partial class analisisFrm : Form
    {
        private Modelo.LabDBEntities labctx = new Modelo.LabDBEntities();
        private Modelo.tb_Analisis analis1 = new Modelo.tb_Analisis();

        public analisisFrm()
        {
            InitializeComponent();
            esconderTabs();
            //limpiarCheckBoxes();
            cargarComboPacientes();

            MessageBox.Show("Seleccione Fecha y Paciente y Guarde antes de cargar analisis");

        }

        ////  private void limpiarCheckBoxes()
        //  {
        //      foreach (System.Windows.Forms.Control c in groupBox1.Controls)
        //      {

        //          if (c.GetType() == typeof(CheckBox))
        //          {
        //              ((CheckBox)c).Checked = false;
        //          }

        //          //limpiarTextBoxTabs(tabControlAnalisis);

        //      }
        //  }

        //private void limpiarTextBoxTabs(TabControl cs)
        //{
        //    foreach (TabPage tab in cs.Controls)
        //        if (tab.GetType() == typeof(TabPage))
        //        {
        //            foreach (System.Windows.Forms.Control c in tab.Controls)
        //            {

        //                if (c.GetType() == typeof(TextBox))
        //                {
        //                    ((TextBox)c).ResetText();
        //                }
        //            }
        //        }

        //}

        private void cargarComboPacientes()
        {
            using (LabDBEntities ctx = new LabDBEntities())
            {



                var querypa = from lp in ctx.tb_Pacientes.Where(pa => pa.borrado == 0)
                              select new
                              {
                                  id = lp.id_paciente,
                                  nombre = lp.nombre + " " + lp.apellido
                              };
                comboBoxPacientes.ValueMember = "id";
                comboBoxPacientes.DisplayMember = "nombre";
                comboBoxPacientes.DataSource = querypa.ToList();
                comboBoxPacientes.SelectedIndex = -1;


                //CARGO MEDICOS TMB

                var queryp = from lm in ctx.tb_Medicos.Where(med => med.borrado == 0)
                             select new
                             {
                                 id = lm.id_medico,
                                 nombre = lm.nombre + " " + lm.apellido

                             };
                comboBoxMedicos.ValueMember = "id";
                comboBoxMedicos.DisplayMember = "nombre";
                comboBoxMedicos.DataSource = queryp.ToList();
                comboBoxMedicos.SelectedIndex = -1;




            }
        }

        private void esconderTabs()
        {
            foreach (TabPage c in tabControlAnalisis.TabPages)
            {
                tabControlAnalisis.TabPages.Remove(c);
            }
        }

        private void cargaComboEstados()
        {



        }



        private void analisisFrm_Load(object sender, EventArgs e)
        {
            cargaComboEstados();
            tabControlAnalisis.TabPages.Clear();

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

        //Hormonas
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHormonas.Checked == true)
            {
                if (!tabControlAnalisis.TabPages.Contains(tabPageHormonas))
                {
                    tabControlAnalisis.TabPages.Add(tabPageHormonas);
                }
            }
            else
            {
                {
                    tabControlAnalisis.TabPages.Remove(tabPageHormonas);
                }

            }
        }

        private void btnHormonaGuardar_Click(object sender, EventArgs e)
        {

            tb_Analisis_Hormonas ah = new tb_Analisis_Hormonas();
            ah.alfa_fetoproteina = Convert.ToDecimal(alfa_fetoproteinaTextBox.Text);
            ah.cea = Convert.ToDecimal(ceaTextBox.Text);
            ah.cetoesteroides_neutros_urinarios = cetoesteroides_neutros_urinariosTextBox.Text;
            ah.cortisol_am = Convert.ToDecimal(cortisol_amTextBox.Text);
            ah.cortisol_pm = Convert.ToDecimal(cortisol_pmTextBox.Text);
            ah.estriadol = Convert.ToDecimal(estriadolTextBox.Text);
            ah.estriol = Convert.ToDecimal(estriolTextBox.Text);
            ah.estrogenos_totales = Convert.ToDecimal(estrogenos_totalesTextBox.Text);
            ah.estrona = Convert.ToDecimal(estronaTextBox.Text);
            ah.fsh = Convert.ToDecimal(fshTextBox.Text);
            ah.helicobacter_pilori = Convert.ToDecimal(helicobacter_piloriTextBox.Text);
            ah.hs_pcr = hs_pcrTextBox.Text;
            ah.lh = Convert.ToDecimal(lhTextBox.Text);
            ah.pregnandriol = Convert.ToDecimal(pregnandriolTextBox.Text);
            ah.pregnantriol = Convert.ToDecimal(pregnantriolTextBox.Text);
            ah.progesterona = Convert.ToDecimal(progesteronaTextBox.Text);
            ah.prolactina = Convert.ToDecimal(prolactinaTextBox.Text);
            ah.psa = Convert.ToDecimal(psaTextBox.Text);
            ah.shbg = Convert.ToDecimal(shbgTextBox.Text);
            ah.t3 = Convert.ToDecimal(t3TextBox.Text);
            ah.t4_libre = Convert.ToDouble(t4_libreTextBox.Text);
            ah.t4_total = Convert.ToDecimal(t4_totalTextBox.Text);
            ah.testosterona_libre = Convert.ToDecimal(testosterona_libreTextBox.Text);
            ah.testosterona_total = Convert.ToDecimal(testosterona_totalTextBox.Text);
            ah.test_tolerancia_glucosa_v1 = Convert.ToDecimal(test_tolerancia_glucosa_v1TextBox.Text);
            ah.test_tolerancia_glucosa_v2 = Convert.ToDecimal(test_tolerancia_glucosa_v2TextBox.Text);
            ah.test_tolerancia_glucosa_v3 = Convert.ToDecimal(test_tolerancia_glucosa_v3TextBox.Text);
            ah.test_tolerancia_glucosa_v4 = Convert.ToDecimal(test_tolerancia_glucosa_v4TextBox.Text);
            ah.testosterona = Convert.ToDecimal(testosteronaTextBox.Text);
            ah.tsh = Convert.ToDecimal(tshTextBox.Text);
            analis1.paciente_id = Convert.ToInt16(comboBoxPacientes.SelectedValue);
            ah.observacion = HormObstextBox.Text;
            if (analis1.id_analisis != 0)
            {
                ah.analisis_id = analis1.id_analisis;

                using (var ctx = new LabDBEntities())
                {

                    ctx.tb_Analisis_Hormonas.Add(ah);

                    if (ctx.SaveChanges() != 0)
                    {
                        ctx.tb_Analisis.Where(an=>an.id_analisis==analis1.id_analisis).First().hormonas_id = ah.id_hormonas;
                        ctx.SaveChanges();

                        MessageBox.Show("Analisis de Hormonas guardado. ID: " + ah.id_hormonas.ToString());

                    }
                }

            }
            else
            {
                MessageBox.Show("Debe guardar el analisis con fecha y paciente para guardar.");

            }

            //PROBAR O REEMPLAZAR POR ESTO
            //analis1.tb_Analisis_Hormonas.

        }
        //Buscar Paciente
        private void button3_Click(object sender, EventArgs e)
        {
            Vista.mayoRediseño.PacientesNewForm pacfrm = new mayoRediseño.PacientesNewForm();
            pacfrm.ShowDialog();
            cargarComboPacientes();
            esconderTabs();
           limpiarCheckBoxes();
        }

        private void btnGuardarEnzimolog_Click(object sender, EventArgs e)
        {
            tb_Analisis_Enzimologia enziman = new tb_Analisis_Enzimologia();
            enziman.amilasa = Convert.ToDecimal(amilasaTextBox.Text);
            enziman.cpk = Convert.ToDecimal(cpkTextBox.Text);
            enziman.fosfatasa_acida_prostatica = Convert.ToDecimal(fosfatasa_acida_prostaticaTextBox.Text);
            enziman.fosfatasa_acida_total = Convert.ToDecimal(fosfatasa_acida_totalTextBox.Text);
            enziman.fosfatasa_alcalina = Convert.ToDecimal(fosfatasa_alcalinaTextBox.Text);
            enziman.gamma_gt = Convert.ToDecimal(gamma_gtTextBox.Text);
            enziman.got = Convert.ToDecimal(gotTextBox.Text);
            enziman.gpt = Convert.ToDecimal(gptTextBox.Text);
            enziman.ldh = Convert.ToDecimal(ldhTextBox.Text);
            enziman.lipasa = Convert.ToDecimal(lipasaTextBox.Text);
            enziman.snt = Convert.ToDecimal(sntTextBox.Text);

        
        }

        private void btnHormonaReset_Click(object sender, EventArgs e)
        {
            limpiarTextBoxes(tabPageHormonas);
        }
        //FUNCIONA
        private void limpiarTextBoxes(TabPage tabPageHormonas)
        {

            foreach (System.Windows.Forms.Control t in tabPageHormonas.Controls)
            {
                if (t.GetType() == typeof(TableLayoutPanel))
                    foreach (System.Windows.Forms.Control e in t.Controls)
                    {
                        if (e.GetType() == typeof(TextBox))
                        {
                            ((TextBox)e).ResetText();
                        }
                    }
            }
        }

        private void btnLimpiarAnalisis_Click(object sender, EventArgs e)
        {
            limpiarCheckBoxes();
        }

        private void limpiarCheckBoxes()
        {
            foreach (System.Windows.Forms.Control t in flowLayoutPanel2.Controls)
            {
                if (t.GetType() == typeof(CheckBox))
                {

                    ((CheckBox)t).Checked = false;
                }
                checkBox1.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                comboBoxPacientes.SelectedIndex = -1;
                dateTimePicker1.ResetText();
            }
        }

        private void btnGuardarAnalisis_Click(object sender, EventArgs e)
        {
            using (var ctx = new LabDBEntities())
            {
                analis1.fecha_solicitud = dateTimePicker1.Value;
                analis1.paciente_id = Convert.ToInt16(comboBoxPacientes.SelectedValue);
                analis1.medico_id = Convert.ToInt16(comboBoxMedicos.SelectedValue);
                analis1.estado_id = 1;
                ctx.tb_Analisis.Add(analis1);
                if (ctx.SaveChanges() != 0)
                {

                    MessageBox.Show("Analisis Guardado Correctamente");
                }
            }
        }

        private void btnBuscarMedico_Click(object sender, EventArgs e)
        {
            Vista.Ventanas.MedicosForm pacfrm = new Vista.Ventanas.MedicosForm();
            pacfrm.ShowDialog();
            cargarComboPacientes();
            esconderTabs();
            limpiarCheckBoxes();
        }




    }
}
