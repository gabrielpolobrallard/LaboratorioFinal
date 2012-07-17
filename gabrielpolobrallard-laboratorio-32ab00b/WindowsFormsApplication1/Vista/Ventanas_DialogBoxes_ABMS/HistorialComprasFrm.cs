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
    public partial class HistorialComprasFrm : Form
    {
        public HistorialComprasFrm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            cargarDatagrid(dateTimePicker1.Value);
        }

        private void cargarDatagrid(DateTime dateTime)
        {

            using (var ctx = new LabDBEntities())
            {
                var query = from v in ctx.tb_Compras.Where(esx => esx.fecha == dateTime.Date)
                            select new
                            {
                                Id = v.id_compra,
                                Fecha = v.fecha,
                                Descripcion = v.descripcion,
                                Tipo_de_Pago = v.pago,
                                Nota_de_Pedido = v.notapedido_id,
                                Descuento = v.descuento,
                                Total = v.total
                            };
                dataGridView1.DataSource = query.ToList();
            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarDataGridDetalle(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
        }

        private void cargarDataGridDetalle(int p)
        {
            using (var ctx = new LabDBEntities())
            {
                var query2 = from v in ctx.tb_Compra_Detalle.Where(esx => esx.compra_id == p)
                            select new
                            {
                                Id = v.id_compra_detalle
                                ,

                                Insumo = v.tb_Insumos.detalle,
                                Precio=v.precio,
                                Subtotal=v.subtotal_prod_cant,
                                Descuento=v.descuento,
                                Cantidad=v.cantidad,
                                Medida=v.medida,
                              
                            };
                dataGridView2.DataSource = query2.ToList();
            }
        }
    }
}
