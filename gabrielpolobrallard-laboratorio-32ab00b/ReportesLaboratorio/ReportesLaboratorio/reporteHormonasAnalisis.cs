﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReportesLaboratorio
{
    public partial class reporteHormonasAnalisis : Form
    {
        int id;
        public reporteHormonasAnalisis(int id =0)
        {
            InitializeComponent();
            this.id = id;
        }

        private void reporteHormonasAnalisis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LabDBDataSet.sp_reporte_hormona_x_id_Reporte' table. You can move, or remove it, as needed.
            this.sp_reporte_hormona_x_id_ReporteTableAdapter.Fill(this.LabDBDataSet.sp_reporte_hormona_x_id_Reporte,this.id);
          
    
            this.reportViewer1.RefreshReport();
        }
    }
}
