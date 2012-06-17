using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReportesLaboratorio
{
    public partial class Form1 : Form
    {
        int id = 0;
        public Form1(int id=0)
        {
            if (id != 0) {
                this.id = id;
            }
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LabDBDataSet1.sp_reporte_hormona_x_id_Reporte' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'LabDBDataSet.sp_reporte_hormona_x_id' table. You can move, or remove it, as needed.
            //this.sp_reporte_hormona_x_idTableAdapter.Fill(this.LabDBDataSet.sp_reporte_hormona_x_id,1);
            MessageBox.Show(""+this.id+"");
            this.sp_reporte_hormona_x_id_ReporteTableAdapter.Fill(this.labDBDataSet.sp_reporte_hormona_x_id_Reporte, this.id);
            this.reportViewer1.RefreshReport();
        }
    }
}