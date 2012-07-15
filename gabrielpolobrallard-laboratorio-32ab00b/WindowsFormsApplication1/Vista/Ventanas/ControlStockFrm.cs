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
    public partial class ControlStockFrm : Form
    {
        private IList query;
        BindingSource bs = new BindingSource();
        Boolean iniciando = true;
        public ControlStockFrm()
        {
            InitializeComponent();
            cargarCombo();
            cargarDatagridProductos();

        }

        private void cargarCombo()
        {
            using (var ctx = new LabDBEntities())
            {
                comboCategorias.DisplayMember = "detalles";
                comboCategorias.ValueMember = "id_tipo_insumo";
                comboCategorias.DataSource = ctx.tb_Tipo_Insumo.ToList();
                comboCategorias.SelectedValue = -1;
                iniciando = false;
            }
        }

        private void cargarDatagridProductos()
        {
            this.SuspendLayout();
            using (var ctx = new LabDBEntities())
            {
                query = (from prod in ctx.tb_Insumos.Where(ins => ins.borrado == 0)
                         orderby prod.detalle
                         select new
                         {
                             ID = prod.id_insumo,
                             DETALLE = prod.detalle,
                             TIPO = prod.tb_Tipo_Insumo.detalles,
                             MARCA = prod.tb_Insumo_Marca.descripcion,
                             CANT_MINIMA = prod.cant_minima,
                             CANT_DISPONIBLE = prod.cant_disponible,
                             MEDIDA = prod.tb_Medida_Insumo.descripcion,
                             PRECIO = prod.precio_unidad

                         }).ToList();


                bs.DataSource = query;
                dvgControlStock.DataSource = bs;
                dvgControlStock.Columns[0].Visible = false;



                statusCantProd.Text = dvgControlStock.RowCount.ToString();

            }


            this.ResumeLayout();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Ventanas_DialogBoxes_ABMS.NuevoProductoDialogBox prodFrm = new Ventanas_DialogBoxes_ABMS.NuevoProductoDialogBox();
            if (prodFrm.ShowDialog() == DialogResult.OK)
            {
                cargarDatagridProductos();
            }
        }

        private void dvgControlStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxBuscarProdStock_TextChanged(object sender, EventArgs e)
        {
            dvgControlStock.Columns[0].Visible = false;
            using (var ctx = new LabDBEntities())
            {

                var resultado = from res in ctx.tb_Insumos.Where(ins => ins.borrado == 0)
                                select new
                                    {
                                        ID = res.id_insumo,
                                        DETALLE = res.detalle,
                                        TIPO = res.tb_Tipo_Insumo.detalles,
                                        MARCA = res.tb_Insumo_Marca.descripcion,
                                        CANT_MINIMA = res.cant_minima,
                                        CANT_DISPONIBLE = res.cant_disponible,
                                        MEDIDA = res.tb_Medida_Insumo.descripcion,
                                        PRECIO = res.precio_unidad
                                    };
                if (textBoxBuscarProdStock.Text != string.Empty)
                {
                    resultado = resultado.Where(ins => ins.DETALLE.ToLower().
                    Contains(textBoxBuscarProdStock.Text.ToLower()));
                }


                bs.DataSource = resultado.ToList();


            }
        }

        private void btnResetDgv_Click(object sender, EventArgs e)
        {
            comboCategorias.SelectedIndex = -1;
            textBoxBuscarProdStock.ResetText();
            cargarDatagridProductos();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dvgControlStock.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Seguro que desea eliminar el producto: " + dvgControlStock.CurrentRow.Cells[1].Value.ToString() + " ?", "Si", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var ctx = new LabDBEntities())
                    {
                        ctx.tb_Insumos.Find(dvgControlStock.CurrentRow.Cells[0].Value).borrado = 1;
                        if (ctx.SaveChanges() != 0)
                        {
                            MessageBox.Show("Producto Borrado");
                        }
                    }
                    this.cargarDatagridProductos();
                }
            }
        }

        private void dvgControlStock_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show(dvgControlStock.CurrentRow.Cells[0].Value.ToString());
            Ventanas_DialogBoxes_ABMS.NuevoProductoDialogBox prodFrm = new Ventanas_DialogBoxes_ABMS.NuevoProductoDialogBox(Convert.ToInt32(dvgControlStock.CurrentRow.Cells[0].Value));
            if (prodFrm.ShowDialog() == DialogResult.OK)
            {
                cargarDatagridProductos();
            }
        }



        private void comboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (var ctx = new LabDBEntities())
            {
                int ss = Convert.ToInt32(comboCategorias.SelectedValue);
                if (ss != 0 || ss != null)
                {
                    var query = from v in ctx.tb_Insumos.Where(ins => ins.tipo_id == ss)
                                select new
                                {
                                    ID = v.id_insumo,
                                    DETALLE = v.detalle,
                                    TIPO = v.tb_Tipo_Insumo.detalles,
                                    MARCA = v.tb_Insumo_Marca.descripcion,
                                    CANT_MINIMA = v.cant_minima,
                                    CANT_DISPONIBLE = v.cant_disponible,
                                    MEDIDA = v.tb_Medida_Insumo.descripcion,
                                    PRECIO = v.precio_unidad
                                };
                    dvgControlStock.DataSource = query.ToList();


                }

            }


        }

        private void btnCompraNva_Click(object sender, EventArgs e)
        {

            //if (dvgControlStock.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Seleccione un producto de la lista");
            //}
            //else
            //{ 
            //}
            CompraForm compFrm = new CompraForm();
            if (compFrm.ShowDialog() == DialogResult.OK)
            {
                cargarDatagridProductos();
            }
            else
            {
                cargarDatagridProductos();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cambios = 0;
            foreach (DataGridViewRow dr in dvgControlStock.Rows)
            {

        
                Historial_Insumo hi = new Historial_Insumo();
                hi.insumo_id = Convert.ToInt32(dr.Cells[0].Value);
                hi.detalle = dr.Cells[1].Value.ToString();
                hi.tipo = dr.Cells[2].Value.ToString();
                hi.marca = dr.Cells[3].Value.ToString();
                hi.cantidad_minima = Convert.ToInt32(dr.Cells[4].Value);
                hi.cantidad_disponible = Convert.ToInt32(dr.Cells[5].Value);
                hi.precio = Convert.ToDecimal(dr.Cells[7].Value);
                hi.fecha = DateTime.Today;
                using (var ctx = new LabDBEntities())
                {
                    ctx.Historial_Insumo.Add(hi);
                   cambios+= ctx.SaveChanges();

                }
                
            }
            if (cambios > 0)
            {
                MessageBox.Show(cambios + "Productos Agregados a Historial con fecha: " + DateTime.Today);
            }
        }


    }
}





