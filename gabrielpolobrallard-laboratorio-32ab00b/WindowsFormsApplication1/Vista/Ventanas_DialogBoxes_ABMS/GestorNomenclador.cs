using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Modelo;
using System.Data.SqlClient;
using System.Collections;

namespace WindowsFormsApplication1.Vista.Ventanas_DialogBoxes_ABMS
{
    public partial class GestorNomenclador : Form
    {

        DataTable dt;
        IList lista2;
        Remito_Obra_Social ros = new Remito_Obra_Social();
        public GestorNomenclador()
        {
            InitializeComponent();
            cargarDatagrid();
            cargarcombos();
        }

        private void cargarcombos()
        {
            using (var ctx = new LabDBEntities())
            {
                var q1 = from v in ctx.tb_Pacientes.Where(bo => bo.borrado == 0)
                         select new
                         {
                             id = v.id_paciente,
                             nombre = v.nombre + " " + v.apellido
                         };
                comboBoxPaciente.DisplayMember = "nombre";
                comboBoxPaciente.ValueMember = "id";
                comboBoxPaciente.DataSource = q1.ToList();
                comboBoxPaciente.SelectedIndex = -1;

                var q2 = from v in ctx.tb_ObraSocial.Where(bobo => bobo.borrado == 0)
                         select new
                         {
                             id = v.id_obra_social,
                             nombre = v.razon_social
                         };
                comboBoxOs.DisplayMember = "nombre";
                comboBoxOs.ValueMember = "id";
                comboBoxOs.DataSource = q2.ToList();
                comboBoxOs.SelectedIndex = -1;



            }
        }

        private void cargarDatagrid()
        {
            using (var ctx = new LabDBEntities())
            {
                var query = (from v in ctx.Nomenclador.AsEnumerable()
                             select new
                             {
                                 Codigo = v.Codigo,
                                 Determinacion = v.Determinacion,
                                 N_I = v.N_I,
                                 Unidad_Bioquimica = v.Unidad_Bioquimica,
                                 Valor = v.Valor,
                                 Frecuencia = v.Frecuencia,
                                 UB = v.UB
                             }


                             );
                dgvPracticasBioquimicas.DataSource = query.ToList();


            }

        }
        //boton agregar
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvPracticasBioquimicas.SelectedRows.Count > 0)
            {

                dgvAnalisisActual.Rows.Add(dgvPracticasBioquimicas.CurrentRow.Cells[0].Value,
                    dgvPracticasBioquimicas.CurrentRow.Cells[1].Value,
                    dgvPracticasBioquimicas.CurrentRow.Cells[2].Value,
                    dgvPracticasBioquimicas.CurrentRow.Cells[3].Value,
                    dgvPracticasBioquimicas.CurrentRow.Cells[4].Value,
                    dgvPracticasBioquimicas.CurrentRow.Cells[5].Value,
                    dgvPracticasBioquimicas.CurrentRow.Cells[6].Value);

                CalcularTotal();
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow dt in dgvAnalisisActual.Rows)
            {
                total = total + Convert.ToDecimal(dt.Cells[4].Value);

            }
            textBoxTotal.Text = total.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            using (var ctx = new LabDBEntities())
            {
                ros.fecha = dateTimePicker1.Value;
                ros.paciente_id = Convert.ToInt32(comboBoxPaciente.SelectedValue);
                ros.obrasocial_id = Convert.ToInt32(comboBoxOs.SelectedValue);
                ros.total = Convert.ToDecimal(textBoxTotal.Text);
                Remito_Obra_Social_Detalle rosd = new Remito_Obra_Social_Detalle();
                ctx.Remito_Obra_Social.Add(ros);
                ctx.SaveChanges();
                foreach (DataGridViewRow dr in dgvAnalisisActual.Rows)
                {
                    if (dr.Cells[0].Value != null)
                    {
                        rosd.nomenclador_id = Convert.ToInt32(dr.Cells[0].Value);
                        rosd.codigo = Convert.ToInt32(dr.Cells[0].Value);
                        rosd.determinaciones = Convert.ToString(dr.Cells[1].Value);
                        rosd.NI = Convert.ToString(dr.Cells[2].Value);
                        rosd.Unidad_Bioquimica = Convert.ToDecimal(dr.Cells[3].Value);
                        rosd.Valor = Convert.ToDecimal(dr.Cells[4].Value);
                        rosd.remito_os_id = ros.remito_os_id;
                        rosd.UB = Convert.ToDecimal(dr.Cells[6].Value);
                        rosd.fecha = dateTimePicker1.Value;
                        rosd.total = Convert.ToDecimal(textBoxTotal.Text);
                        ros.Remito_Obra_Social_Detalle.Add(rosd);
                        //
                        ctx.Remito_Obra_Social_Detalle.Add(rosd);
                        if (ctx.SaveChanges() != 0)
                        {
                            
                            //IMPRIMIR REPORTE
                        }
                    }

                }
                ReportesLaboratorio.ComprobanteOS gnom = new ReportesLaboratorio.ComprobanteOS(ros.remito_os_id);
                gnom.Show();

            }
        }





    }
}
