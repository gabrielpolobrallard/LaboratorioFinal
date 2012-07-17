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
    public partial class HistorialNotasPedidoFrm : Form
    {
        public HistorialNotasPedidoFrm()
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
                var query = from v in ctx.tb_NotaPedido.Where(esx => esx.fecha_emision == dateTime.Date)
                            select new
                            {
                                Id = v.id_nota_pedido,
                                v.numero_orden,
                                Fecha = v.fecha_emision,
                                Descripcion = v.descripcion,
                                total = v.Pedido_Detalle.FirstOrDefault().total

                            }
                            ;
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
                var query2 = from v in ctx.Pedido_Detalle.Where(esx => esx.pedido_id == p)
                             select new
                             {
                                 Id = v.id_notapedido_detalle,
                                 Pedido_Nro = v.pedido_id,
                                 Producto_Insumo=v.tb_Insumos.detalle,
                                Medida= v.unidad_medida,
                                 Precio=v.precio,
                                 Cantidad=v.cantidad,
                                 Descuento=v.descuento,
                                 Subtotal=v.subtotal





                             };
                dataGridView2.DataSource = query2.ToList();
            }
        }
    }
}
