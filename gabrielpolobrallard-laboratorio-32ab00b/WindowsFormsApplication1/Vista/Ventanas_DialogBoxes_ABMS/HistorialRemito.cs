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
    public partial class HistorialRemito : Form
    {
        public HistorialRemito()
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
                var query = from v in ctx.Remito.Where(esx => esx.fecha == dateTime.Date)
                            select new
                            {
                                Id = v.id_remito,
                                Fecha = v.fecha,
                                Numero_Remito = v.numero_remito,
                                Razon_Social = v.razon_social,
                                Direccion = v.direccion,
                                Condicion_iVA = v.Tipo_IVA.descripcion,
                                Condicion_Venta = v.Tipo_Venta.descripcion,
                               
                                CUIL_CUIT=v.cuil_cuit,
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
                var query2 = from v in ctx.Remito_Detalle.Where(esx => esx.remito_id == p)
                             select new
                             {
                                 Id = v.id_remito_detalle,
                                 Codigo_Servicio= v.codigo_id,
                                 Remito_ID= v.remito_id,
                                 Detalle=v.descripcion,
                                 Precio_Unitario=v.precio,
                                 Cantidad=v.cantidad,
                                 Descuento=v.descuento,
                                 Subtotal=v.importe

                                 

                                
                             };
                dataGridView2.DataSource = query2.ToList();
            }
        }

   
        
    }
}
