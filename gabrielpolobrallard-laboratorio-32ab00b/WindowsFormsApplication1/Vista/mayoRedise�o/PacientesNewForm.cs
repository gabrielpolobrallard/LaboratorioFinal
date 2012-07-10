using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Modelo;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.Vista.mayoRediseño
{
    public partial class PacientesNewForm : Form
    {
        DataSet ds = new DataSet();
        private int iniciando;
        public PacientesNewForm()
        {
            InitializeComponent();
            iniciando = 1;
            this.SuspendLayout();
            cargarDataGrid();

            cargarComboSang();

            btnEliminarPac.Enabled = false;
            this.ResumeLayout();

            //  cargarComboSang();
        }

        private void cargarComboSang()
        {
            string conStr = "Data Source=JAVA-NOTEBOOK\\JAVASQLSERVER;Initial Catalog=LabDB;Integrated Security=yeS;User id=sa;Password=admin";
            SqlConnection conn = new SqlConnection(conStr);
            // Open the connection
            conn.Open();


            SqlCommand command = new SqlCommand("dbo.getGruposSanguineosAll", conn);
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.Add("@Nocontrol", SqlDbType.NVarChar).Value = this.txt_nocontrol.Text;
            SqlDataAdapter adapters = new SqlDataAdapter(command);
            // ds = new DataSet();
            adapters.Fill(ds, "GSTmp");
            conn.Close();
            //LLENO EL COMBO
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;

            comboBox1.DataSource = ds.Tables["GSTmp"];
            comboBox1.ValueMember = "id_grupo";
            comboBox1.DisplayMember = "descripcion";
            comboBox1.SelectedIndex = -1;
            this.iniciando = 0;

        }

        private void cargarDataGrid()
        {
            if (ds.Tables["PacTmp"] != null) { ds.Tables["PacTmp"].Clear(); }
            cargarDataSetPacientes();

      
           
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true; //ESTO PERMITE ORDENAR <-!
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;


            //formato columna
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Set the selection background color for all the cells.
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Set the background color for all rows and for alternating rows. 
            // The value for alternating rows overrides the value for all rows. 
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;
            // Set the row and column header styles.
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            // Set the Format property on the "Last Prepared" column to cause
            // the DateTime to be formatted as "Month, Year".
            //  dataGridView1.Columns["fecha_alta"].DefaultCellStyle.Format = "y";

            dataGridView1.DataSource = ds.Tables["PacTmp"];
            dataGridView1.Columns[0].Visible = false;
        }

        private void cargarDataSetPacientes()
        {
            //JAVA-B2S1EMXNU5
            string conStr = "Data Source=JAVA-NOTEBOOK\\JAVASQLSERVER;Initial Catalog=LabDB;Integrated Security=yeS;User id=sa;Password=admin";
            SqlConnection conn = new SqlConnection(conStr);
            // Open the connection
            conn.Open();


            SqlCommand command = new SqlCommand("dbo.getPacientesTodos", conn);
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.Add("@Nocontrol", SqlDbType.NVarChar).Value = this.txt_nocontrol.Text;
            SqlDataAdapter adapters = new SqlDataAdapter(command);
            //  ds = new DataSet();
            adapters.Fill(ds, "PacTmp");
            conn.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ds.Tables["PacTmp"].DefaultView.RowFilter = ("nombre like '%" + textBox1.Text + "%' OR apellido like '%" + textBox1.Text + "%' ");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            ds.Tables["PacTmp"].DefaultView.RowFilter = (" Convert(dni,System.String) like '%" + maskedTextBox1.Text + "%' ");
        }

        //
        //*** ARREGLAR
        ///
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (iniciando == 1) { }
            else
            {

                ds.Tables["PacTmp"].DefaultView.RowFilter = ("grupo_sanguineo like '%" + comboBox1.Text + "%' ");
            }
        }

        private void PacientesNewForm_Load(object sender, EventArgs e)
        {

            //
        }

        private void btnGSReset_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            ds.Tables["PacTmp"].DefaultView.RowFilter = "";
            textBox1.Text = "";
            maskedTextBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            this.ResumeLayout();
        }

        //Modificar
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            Pacientes abmp = new Pacientes(id);
            if (abmp.ShowDialog() == DialogResult.OK)
            {
                cargarDataGrid();
            }



        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
         
        }

        private void PacientesNewForm_Load_1(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                Pacientes abmp = new Pacientes(id);
                abmp.MdiParent = this.MdiParent ;
                abmp.Show();
                cargarDataGrid();
                //if (abmp.ShowDialog() == DialogResult.OK)
                //{
                //    cargarDataGrid();
                //}
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null) {
                btnEliminarPac.Enabled = true;
            
            }
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            btnEliminarPac.Enabled = false;
        }

        private void btnNuevoPac_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Vista.mayoRediseño.Pacientes pac = new Vista.mayoRediseño.Pacientes();
            pac.Show();
        }








    }
}
