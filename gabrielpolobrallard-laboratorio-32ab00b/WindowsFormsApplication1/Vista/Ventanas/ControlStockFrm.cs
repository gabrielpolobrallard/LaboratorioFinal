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
        public ControlStockFrm()
        {
            InitializeComponent();
            cargarDatagridProductos();
         
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
                comboCategorias.DataSource = ctx.tb_Tipo_Insumo.ToList();
                comboCategorias.DisplayMember = "detalles";
                comboCategorias.ValueMember = "id_tipo_insumo";
                comboCategorias.SelectedValue = 1;
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
                if (comboCategorias.SelectedValue.ToString() != "1")
                {
                    resultado = resultado.Where(ins => ins.TIPO.ToLower().Contains(comboCategorias.Text.Trim().ToLower()));
                }

                bs.DataSource = resultado.ToList();


            }
        }

        private void btnResetDgv_Click(object sender, EventArgs e)
        {
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
            if (textBoxBuscarProdStock.Text == string.Empty)
            {

                using (var ctx = new LabDBEntities())
                {
                    var result = from res in ctx.tb_Insumos.Where(ins => ins.borrado == 0)
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

                    if (comboCategorias.SelectedValue.ToString() == "1")
                    {

                    }
                    if (comboCategorias.SelectedValue.ToString() != "1")
                    {

                        result = result.Where(ins => ins.TIPO.Trim() == ctx.tb_Tipo_Insumo.Where(tipo => tipo.id_tipo_insumo.ToString() == comboCategorias.SelectedValue.ToString()).Single().detalles);
                    }
                    bs.DataSource = result.ToList();
                    //dvgControlStock.Update();

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
            else {
                cargarDatagridProductos();
            }

        }
    }
}





