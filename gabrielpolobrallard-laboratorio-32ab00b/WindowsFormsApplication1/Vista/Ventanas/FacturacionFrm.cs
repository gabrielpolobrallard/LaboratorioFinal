using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Modelo;

namespace WindowsFormsApplication1.Vista.Ventanas
{
    public partial class FacturacionFrm : Form
    {

        Remito nvoRemito = new Remito();
        public FacturacionFrm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.cargarProdARemitoFrm pdfrm = new Ventanas_DialogBoxes_ABMS.cargarProdARemitoFrm();
            if (pdfrm.ShowDialog() == DialogResult.OK)
            {
                dgvRemito.Rows.Add(pdfrm.codigo, pdfrm.detalle, pdfrm.cantidad, pdfrm.precio, pdfrm.descuento, pdfrm.cantidad * pdfrm.precio - (pdfrm.descuento));
            }
            pdfrm.Close();

        }

        private void dgvRemito_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            SubtotaltextBox.Text = calcularSubtotal();
            TotaltextBox.Text = calcularSubtotal();
        }

        private string calcularSubtotal()
        {
            decimal subt = 0;
            foreach (DataGridViewRow row in dgvRemito.Rows)
            {
                subt += Convert.ToDecimal(row.Cells[6].Value);

            }
            return subt.ToString();
        }

        private void btnBorrarItem_Click(object sender, EventArgs e)
        {
            if (dgvRemito.SelectedRows.Count == 1)
            {
                dgvRemito.Rows.Remove(dgvRemito.CurrentRow);
            }
        }

        private void btnEmitirRemito_Click(object sender, EventArgs e)
        {
            nvoRemito.fecha = fechaRemitoDtp.Value;
            nvoRemito.numero_remito = Convert.ToInt16(nroRemitoTextBox.Text);
            nvoRemito.razon_social = razonSocialTextBox.Text;
            nvoRemito.condicion_iva = Convert.ToInt16(comboBoxCondIVA.SelectedValue);
            nvoRemito.condicion_venta = Convert.ToInt16(comboBoxCondVenta.SelectedValue);
            nvoRemito.direccion = direccionTextBox.Text;
            nvoRemito.total = Convert.ToDecimal(TotaltextBox.Text);

            //cargo los detalles
            Remito_Detalle r = new Remito_Detalle();
            foreach (DataGridViewRow row in dgvRemito.Rows)
            {
                r.codigo_id = Convert.ToInt16(row.Cells[0].Value);
                r.descripcion = row.Cells[1].Value.ToString();
                r.cantidad = Convert.ToInt16(row.Cells[2].Value);
                r.precio = Convert.ToDecimal(row.Cells[3].Value);
                r.descuento = Convert.ToDecimal(row.Cells[4].Value);
                r.total_venta = nvoRemito.total;
                
                
                nvoRemito.Remito_Detalle.Add(r);
                
            }
            MessageBox.Show("Remito Guardado con id: "+nvoRemito.id_remito);

        }


    }
}
