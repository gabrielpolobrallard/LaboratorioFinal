using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.Vista.Ventanas_DialogBoxes_ABMS
{
    public partial class GestionAnalisisTodos : Form
    {
        DataSet ds=new DataSet();
        public GestionAnalisisTodos()
        {
            InitializeComponent();
            cargarDatagrid();
        }

        private void cargarDatagrid()
        {
            dataGridView2.DataSource = null;
            string conStr = "Data Source=JAVA-NOTEBOOK\\JAVASQLSERVER;Initial Catalog=LabDB;Integrated Security=yeS;User id=sa;Password=admin";
            SqlConnection conn = new SqlConnection(conStr);
            // Open the connection
            conn.Open();


            SqlCommand command = new SqlCommand("dbo.ListarUltimosAnalisis", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@cantidad", SqlDbType.Int).Value =10000;
            SqlDataAdapter adapters = new SqlDataAdapter(command);
            // ds = new DataSet();
            adapters.Fill(ds, "GSTmp");
            conn.Close();
            ds.Tables["GSTmp"].Columns[0].ColumnName = "Fecha Solicitud";
            ds.Tables["GSTmp"].Columns[1].ColumnName = "ID de Analisis";
            ds.Tables["GSTmp"].Columns[2].ColumnName = "Paciente";
            ds.Tables["GSTmp"].Columns[3].ColumnName = "Tipo/Categoria";
            

            dataGridView1.DataSource = ds.Tables["GSTmp"];
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {


                string conStr = "Data Source=JAVA-NOTEBOOK\\JAVASQLSERVER;Initial Catalog=LabDB;Integrated Security=yeS;User id=sa;Password=admin";
                SqlConnection conn = new SqlConnection(conStr);
                // Open the connection
                conn.Open();

                DataTable dt = new DataTable();


                SqlCommand command = new SqlCommand("sp_AnalisisSelectGESTIONANALISIS", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@tipoAnalisisCampo", SqlDbType.NVarChar);
                command.Parameters["@tipoAnalisisCampo"].Value = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                command.Parameters.Add("@idAnalisis", SqlDbType.Int);
                command.Parameters["@idAnalisis"].Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);

                command.Parameters.Add("@TablaNombre", SqlDbType.NVarChar);
                command.Parameters["@TablaNombre"].Value = dataGridView1.CurrentRow.Cells[5].Value;

                command.Parameters.Add("@idAnalisisEspecifico", SqlDbType.Int);
                command.Parameters["@idAnalisisEspecifico"].Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);

              
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);


                this.dataGridView2.DataSource = dt;
                conn.Close();

                ////selecciono el datagrid. Le doy focus por si aprietan imprimir.
                //if (dgvDetallesAnalisisEspecif.Rows.Count > 0)
                //{
                //    buttonImprimirAnalisisEspecif.Enabled = true;
                //    dgvDetallesAnalisisEspecif.Select();
                //}
            }
        }

        private void btnNuevoAnalisis_Click(object sender, EventArgs e)
        {
            Ventanas.analisisFrm anfrm = new Ventanas.analisisFrm();
            if (anfrm.ShowDialog() == DialogResult.OK)
            {
                cargarDatagrid();

            }
        }

        private void btnImprimirAnalisis_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Columns[0].Name.Equals("id_hormonas"))
            {
                ReportesLaboratorio.reporteHormonasAnalisis rptHormFrm = new ReportesLaboratorio.reporteHormonasAnalisis(Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value));
                rptHormFrm.ShowDialog();
            }
            if (dataGridView2.Columns[0].Name.Equals("id_enzimologia"))
            {
                ReportesLaboratorio.ReporteEnzimologiaAnalisis rptHormFrm = new ReportesLaboratorio.ReporteEnzimologiaAnalisis(Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value));
                rptHormFrm.ShowDialog();
            }
        }
    }
}
