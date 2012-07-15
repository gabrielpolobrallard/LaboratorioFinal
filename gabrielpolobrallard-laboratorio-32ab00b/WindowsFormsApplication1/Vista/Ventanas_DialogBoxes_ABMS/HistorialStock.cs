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
    public partial class HistorialStock : Form
    {
        public HistorialStock()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cargarDatagrid(dateTimePicker1.Value);
        }

        private void cargarDatagrid(DateTime dateTime)
        {
            using (var ctx= new LabDBEntities())
            {
                var query = from v in ctx.Historial_Insumo.Where(esx=>esx.fecha==dateTime.Date)
                            select v;
                dataGridView1.DataSource = query.ToList();
            }
            
        }
    }
}
