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
    public partial class GestorExtracciones : Form
    {
        public GestorExtracciones()
        {
            InitializeComponent();
            cargarDatagrid();
        }

        private void cargarDatagrid()
        {
            using (var ctx = new LabDBEntities())
            {
                var query = from v in ctx.tb_Muestras.Where(borr => borr.borrado == 0)
                            select new
                            {
                                Id = v.id_muestra,
                                Fecha = v.fecha_extraccion,
                                Paciente = v.tb_Pacientes.nombre + " " + v.tb_Pacientes.apellido,
                                Tipo_de_Muestra = v.tb_Muestras_Tipo.descripcion,
                                Analisis_ID = v.analisis_id
                            };
                dgvExtracciones.DataSource = query.ToList();


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventanas.NvaExtraccion nvaex = new Ventanas.NvaExtraccion();
            if (nvaex.ShowDialog() == DialogResult.OK)
            {
                cargarDatagrid();
            }

        }


        //eliminar
        private void button2_Click(object sender, EventArgs e)
        {
            using (var ctx = new LabDBEntities())
            {
                if (dgvExtracciones.CurrentRow.Cells[0].Value != null)
                {
                    ctx.tb_Muestras.Find(dgvExtracciones.CurrentRow.Cells[0].Value).borrado = 1;
                    if (ctx.SaveChanges() != 0)
                    {
                        MessageBox.Show("Extraccion Eliminada con exito!");
                        cargarDatagrid();
                    }
                }
            }
        }
        //imprimir
        private void button3_Click(object sender, EventArgs e)
        {
            ReportesLaboratorio.ImprimirExtraccionesTodasFrm extodas = new ReportesLaboratorio.ImprimirExtraccionesTodasFrm();
            extodas.Show();
        }



    }
}
