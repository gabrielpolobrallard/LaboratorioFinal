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
    public partial class CompraForm : Form
    {
        private IList query;
        BindingSource bs = new BindingSource();
        public CompraForm()
        {

            InitializeComponent();
            cargarDatagridProductos();
            cantidadTxt.Enabled = false;
        }

        private void cargarDatagridProductos()
        {
            using (var ctx = new LabDBEntities())
            {
                query = (from prod in ctx.tb_Insumos.Include("tb_Tipo_Insumo").Where(ins => ins.borrado == 0)
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
                dvgCompraProd.DataSource = bs;
                dvgCompraProd.Columns[0].Visible = false;

            }
        }

        private void dvgCompraProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cantidadTxt.Enabled = true;
            nombreprodtxt.Text = dvgCompraProd.CurrentRow.Cells[1].Value.ToString();
            precioprodtxt.Text = dvgCompraProd.CurrentRow.Cells[7].Value.ToString();
            calculasubtotal();

        }

        private void calculasubtotal()
        {
            if (cantidadTxt.Text == string.Empty)
            {
            }
            else
            {
                subtotalprodtxt.Text = Convert.ToString(Convert.ToInt32(precioprodtxt.Text) * Convert.ToInt32(cantidadTxt.Text));
            }
        }

        private void cantidadTxt_TextChanged(object sender, EventArgs e)
        {
            calculasubtotal();
        }

        private void agregarACompraBtn_Click(object sender, EventArgs e)
        {
            int idprodAgreg = Convert.ToInt32(dvgCompraProd.CurrentRow.Cells[0].Value);


            Boolean esNuevaFila = false;
            foreach (DataGridViewRow fila in dvgDetalle.Rows)
            {
                if (idprodAgreg == Convert.ToInt32(fila.Cells[0].Value))
                {
                    esNuevaFila = false;
                    fila.Cells[2].Value = Convert.ToInt32(fila.Cells[2].Value) + Convert.ToInt32(cantidadTxt.Text);
                    fila.Cells[4].Value = Convert.ToInt32(fila.Cells[4].Value) + (Convert.ToInt32(cantidadTxt.Text) * Convert.ToInt32(fila.Cells[3].Value));

                    break;

                }

                else
                {
                    esNuevaFila = true;

                }


            }

            if (esNuevaFila)
            {
                dvgDetalle.Rows.Add(dvgCompraProd.CurrentRow.Cells[0].Value, dvgCompraProd.CurrentRow.Cells[1].Value, cantidadTxt.Text, dvgCompraProd.CurrentRow.Cells[7].Value, Convert.ToInt32(cantidadTxt.Text) * Convert.ToInt32(precioprodtxt.Text));

            }

            actualizaCantTotalYprecioTotal();

        }

        private void actualizaCantTotalYprecioTotal()
        {

            int pt = 0;
            foreach (DataGridViewRow fila in dvgDetalle.Rows)
            {
                pt = pt + Convert.ToInt32(fila.Cells[4].Value);
            }
            cantidadProdTottxt.Text = Convert.ToString(dvgDetalle.Rows.Count - 1);
            PrecioTotalTxt.Text = pt.ToString();
        }

        private void dvgDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Guarda Toda La compra

        /// <summary>
        /// tb_Compra_detalle es cada linea de la fact. relacionada con tb_Compra y con insumo.
        /// Actualizar CantDisponibleInsumo. actualizar datagrids de productos.
        /// 
        /// 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GuardarCompraBtn_Click(object sender, EventArgs e)
        {
            tb_Compras compra = new tb_Compras();
            using (var ctx = new LabDBEntities())
            {
                foreach (DataGridViewRow fila in dvgDetalle.Rows)
                {
                    if (fila.Cells[0].Value!= null)
                    {

                        tb_Compra_Detalle compraDetalle = new tb_Compra_Detalle();

                        compraDetalle.compra_id = compra.id_compra;
                        compraDetalle.cantidad = Convert.ToInt32(fila.Cells[2].Value);
                        compraDetalle.insumo_id = Convert.ToInt32(fila.Cells[0].Value);
                        MessageBox.Show(ctx.tb_Insumos.Find(compraDetalle.insumo_id).cant_disponible + " insumoid");
                        ctx.tb_Insumos.Find(compraDetalle.insumo_id).cant_disponible = ctx.tb_Insumos.Find(compraDetalle.insumo_id).cant_disponible + Convert.ToInt32(fila.Cells[2].Value);
                        compraDetalle.subtotal_prod_cant = Convert.ToInt32(fila.Cells[4].Value);
                        compra.fecha = dtpFechaCompra.Value;
                        compra.tb_Compra_Detalle.Add(compraDetalle);
                    }
                }

                ctx.tb_Compras.Add(compra);

                if (ctx.SaveChanges() == 0)
                {
                }
                else
                {
                    MessageBox.Show("Compra guardada con exito");
                    cargarDatagridProductos();
                }
            }
            

        }

        private void NuevoProdBtn_Click(object sender, EventArgs e)
        {
            Ventanas_DialogBoxes_ABMS.NuevoProductoDialogBox nvoProd = new Ventanas_DialogBoxes_ABMS.NuevoProductoDialogBox();
            if (nvoProd.ShowDialog() == DialogResult.OK)
            {
 
            }
            cargarDatagridProductos();
        }

        private void EditarProdBtn_Click(object sender, EventArgs e)
        {
            if (this.dvgCompraProd.CurrentRow.Cells[0] != null)
            {
                Ventanas_DialogBoxes_ABMS.NuevoProductoDialogBox nvoProd = new Ventanas_DialogBoxes_ABMS.NuevoProductoDialogBox(Convert.ToInt16(dvgCompraProd.CurrentRow.Cells[0].Value));
                if (nvoProd.ShowDialog() == DialogResult.OK)
                {

                }
                cargarDatagridProductos();
            }
        }

        private void GenerarNotaPedBtn_Click(object sender, EventArgs e)
        {

        }

        private void dvgCompraProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgCompraProd_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cantidadTxt.Enabled = true;
            nombreprodtxt.Text = dvgCompraProd.CurrentRow.Cells[1].Value.ToString();
            precioprodtxt.Text = dvgCompraProd.CurrentRow.Cells[7].Value.ToString();
            calculasubtotal();

        }






    }
}
