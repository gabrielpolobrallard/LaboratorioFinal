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
    public partial class GestionLaboratoriosMarcas : Form
    {
        public GestionLaboratoriosMarcas()
        {
            InitializeComponent();
            cargarMarcas();
        }

        private void cargarMarcas()
        {
            using (var ctx = new LabDBEntities()){

                var query = from v in ctx.tb_Insumo_Marca.Where(borr=>borr.borrado==0)
                            select new 
                            {
                                ID=v.id_marca,
                                Marca=v.descripcion
                            };

                dgvMarcas.DataSource=query.ToList();

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new LabDBEntities())
            {
                tb_Insumo_Marca nm= new tb_Insumo_Marca();
                nm.descripcion=textBox1.Text;
                nm.borrado=0;
                ctx.tb_Insumo_Marca.Add(nm);
                if(ctx.SaveChanges()!=0)
                {
                    
                    
                    cargarMarcas();
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dgvMarcas.SelectedRows.Count>0)
            {
                using(var ctx= new LabDBEntities())
                {

                    ctx.tb_Insumo_Marca.Find(Convert.ToInt32(dgvMarcas.CurrentRow.Cells[0].Value)).borrado=1;
                    if(ctx.SaveChanges()!=0)
                    {
                    cargarMarcas();
                    }
                }

            }
        }
    }
}
