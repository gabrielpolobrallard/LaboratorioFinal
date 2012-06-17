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

namespace WindowsFormsApplication1.Vista.Ventanas
{
    public partial class MedicosForm : Form
    {
        private IList query;
        BindingSource bs = new BindingSource();
        public MedicosForm()
        {
            InitializeComponent();
            cargarDatagridMedicos();
        }


        private void cargarDatagridMedicos()
        {
            using (var ctx = new LabDBEntities())
            {
                query = (from prod in ctx.tb_Medicos.Where(ins => ins.borrado == 0)
                         orderby prod.nombre
                         select new
                         {
                             ID = prod.id_medico,
                             NOMBRE = prod.nombre,
                             APELLIDO = prod.apellido,
                             DNI = prod.dni,
                             ESPECIALIDAD = prod.tb_Medico_Tipo.detalle

                         }).ToList();


                bs.DataSource = query;
                dgvMedicos.DataSource = bs;
                dgvMedicos.Columns[0].Visible = false;
                cbEspecialidad.DataSource = ctx.tb_Medico_Tipo.ToList();
                cbEspecialidad.DisplayMember = "detalle";
                cbEspecialidad.ValueMember = "id_tipo_medico";
                cbEspecialidad.SelectedValue = 1;

            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Ventanas_DialogBoxes_ABMS.NvoMedicoForm medFrm = new Ventanas_DialogBoxes_ABMS.NvoMedicoForm();
            if (medFrm.ShowDialog() == DialogResult.OK)
            {
                cargarDatagridMedicos();
            }
        }

        private void textBoxBuscarProdStock_TextChanged(object sender, EventArgs e)
        {
            dgvMedicos.Columns[0].Visible = false;
            using (var ctx = new LabDBEntities())
            {
                var resultado = from prod in ctx.tb_Medicos.Where(ins => ins.borrado == 0)
                                orderby prod.nombre
                                select new
                                {
                                    ID = prod.id_medico,
                                    NOMBRE = prod.nombre,
                                    APELLIDO = prod.apellido,
                                    DNI = prod.dni,
                                    ESPECIALIDAD = prod.tb_Medico_Tipo.detalle

                                };
                if (textBoxBuscarProdStock.Text != string.Empty)
                {
                    resultado = resultado.Where(ins => ins.NOMBRE.ToLower().
                    Contains(textBoxBuscarProdStock.Text.ToLower()) || ins.APELLIDO.ToLower().Contains(textBoxBuscarProdStock.Text));
                }
                if (cbEspecialidad.SelectedValue.ToString() != "1")
                {
                    resultado = resultado.Where(ins => ins.ESPECIALIDAD.ToLower().Contains(cbEspecialidad.Text.Trim().ToLower()));
                }

                bs.DataSource = resultado.ToList();




            }
        }

        private void btnResetDgv_Click(object sender, EventArgs e)
        {
            cargarDatagridMedicos();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Seguro que desea eliminar el Medico: " + dgvMedicos.CurrentRow.Cells[1].Value.ToString() + " ?", "Si", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var ctx = new LabDBEntities())
                    {
                        ctx.tb_Medicos.Find(dgvMedicos.CurrentRow.Cells[0].Value).borrado = 1;
                        if (ctx.SaveChanges() != 0)
                        {
                            MessageBox.Show("Producto Borrado");
                        }
                    }
                    this.cargarDatagridMedicos();
                }
            }
        }

        private void dgvMedicos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Ventanas_DialogBoxes_ABMS.NvoMedicoForm prodFrm = new Ventanas_DialogBoxes_ABMS.NvoMedicoForm(Convert.ToInt32(dgvMedicos.CurrentRow.Cells[0].Value));
            if (prodFrm.ShowDialog() == DialogResult.OK)
            {
                cargarDatagridMedicos();
            }
        }

        //private void cbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (textBoxBuscarProdStock.Text == string.Empty)
        //    {

        //        using (var ctx = new LabDBEntities())
        //        {
        //            var result = from res in ctx.tb_Medicos.Where(ins => ins.borrado == 0)
        //                         select new
        //                         {
        //                             ID = res.id_medico,
        //                             NOMBRE = res.nombre,
        //                             APELLIDO = res.apellido,
        //                             DNI = res.dni,
        //                             ESPECIALIDAD = res.tb_Medico_Tipo.detalle


        //                         };

        //            if (cbEspecialidad.SelectedValue.ToString() == "1")
        //            {

        //            }
        //            if (cbEspecialidad.SelectedValue.ToString() != "1")
        //            {

        //                result = result.Where(ins => ins.ESPECIALIDAD.Trim() == ctx.tb_Medico_Tipo.Where(tipo => tipo.id_tipo_medico.ToString() == cbEspecialidad.SelectedValue.ToString()).Single().detalle);
        //            }
        //            bs.DataSource = result.ToList();
        //            //dvgControlStock.Update();

        //        }
        //    }

        //}


    }
}
