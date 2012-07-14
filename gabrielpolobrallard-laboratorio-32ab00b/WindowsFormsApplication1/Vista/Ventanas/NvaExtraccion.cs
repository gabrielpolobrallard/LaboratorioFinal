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

namespace WindowsFormsApplication1.Vista.Ventanas
{
    public partial class NvaExtraccion : Form
    {
        DataSet ds = new DataSet();
        Boolean iniciando = true;
        public NvaExtraccion()
        {
            InitializeComponent();
            cargarComboPacientes();

        }

        private void cargarComboPacientes()
        {
            this.SuspendLayout();
            using (var ctx = new LabDBEntities())
            {
                var query = from v in ctx.tb_Pacientes.Where(esw => esw.borrado == 0)
                            select new
                            {
                                id = v.id_paciente,
                                nombre = v.nombre + " " + v.apellido
                            };
                comboBoxPaciente.DisplayMember = "nombre";
                comboBoxPaciente.ValueMember = "id";
                comboBoxPaciente.DataSource = query.ToList();
                comboBoxPaciente.SelectedIndex = -1;

                //cargo TIpo MUestra

                var query3 = from v in ctx.tb_Muestras_Tipo
                             select new
                             {
                                 id = v.id_muestras_tipo,
                                 nombre = v.descripcion
                             };
                comboBoxTipoMuestra.DisplayMember = "nombre";
                comboBoxTipoMuestra.ValueMember = "id";
                comboBoxTipoMuestra.DataSource = query3.ToList();
                comboBoxTipoMuestra.SelectedIndex = -1;


            }
            this.ResumeLayout();
        }

        private void comboBoxPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBoxPaciente_SelectionChangeCommitted(object sender, EventArgs e)
        {

            comboBoxAnalisis.SuspendLayout();
            comboBoxAnalisis.DataSource = null;
            string conStr = "Data Source=JAVA-NOTEBOOK\\JAVASQLSERVER;Initial Catalog=LabDB;Integrated Security=yeS;User id=sa;Password=admin";
            SqlConnection conn = new SqlConnection(conStr);
            // Open the connection
            conn.Open();


            SqlCommand command = new SqlCommand("dbo.llenarComboAnalisisPacienteEspecificoMuestras", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt16(this.comboBoxPaciente.SelectedValue);
            SqlDataAdapter adapters = new SqlDataAdapter(command);
            // ds = new DataSet();
            ds = new DataSet();
            adapters.Fill(ds, "GSTmp");
            conn.Close();
            //LLENO EL COMBO
            comboBoxAnalisis.DropDownStyle = ComboBoxStyle.DropDown;

            comboBoxAnalisis.DataSource = ds.Tables["GSTmp"];
            comboBoxAnalisis.ValueMember = "id_analisis";
            comboBoxAnalisis.DisplayMember = "fecha2";
            comboBoxAnalisis.SelectedIndex = -1;
            comboBoxAnalisis.ResumeLayout();
        }
        //editar Tipo Muestra
        private void button3_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.NvoTipoMuestraDialog nvames = new Ventanas_DialogBoxes_ABMS.NvoTipoMuestraDialog();
            if (nvames.ShowDialog() == DialogResult.OK)
            {
                cargarComboPacientes();
            }
        }
        //GUARDAR EXTRACCION
        private void button1_Click(object sender, EventArgs e)
        {
            tb_Muestras nvaMuestra = new tb_Muestras();
            nvaMuestra.descripcion = textBoxdescripcion.Text;
            nvaMuestra.fecha_extraccion = dateTimePicker1.Value;
            nvaMuestra.paciente_id = Convert.ToInt16(comboBoxPaciente.SelectedValue);
            nvaMuestra.tipo_id = Convert.ToInt16(comboBoxTipoMuestra.SelectedValue);
            nvaMuestra.analisis_id = Convert.ToInt16(comboBoxAnalisis.SelectedValue);
            nvaMuestra.borrado = 0;
            using (var ctx = new LabDBEntities())
            {
                ctx.tb_Muestras.Add(nvaMuestra);
                if (ctx.SaveChanges() != 0)
                {
                    MessageBox.Show("Extraccion guardada con exito");
                }
                this.DialogResult = DialogResult.OK;

            }
        }


    }
}
