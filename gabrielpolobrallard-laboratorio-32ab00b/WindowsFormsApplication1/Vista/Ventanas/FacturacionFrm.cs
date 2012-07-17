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
            cargarCombosyRemitoN();
            nroRemitoTextBox.Text = "Autogenerado";

        }

        private void cargarCombosyRemitoN()
        {
            using (var ctx = new LabDBEntities())
            {
                var query = from x in ctx.Tipo_IVA select x;
                comboBoxCondIVA.DisplayMember = "descripcion";
                comboBoxCondIVA.ValueMember = "id_iva";
                comboBoxCondIVA.DataSource = query.ToList();
                var query2 = from x in ctx.Tipo_Venta select x;
                comboBoxCondVenta.DisplayMember = "descripcion";
                comboBoxCondVenta.ValueMember = "id_tipoventa";
                comboBoxCondVenta.DataSource = query2.ToList();
                comboBoxCondIVA.SelectedIndex = -1;
                comboBoxCondVenta.SelectedIndex = -1;


            }
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            Vista.Ventanas_DialogBoxes_ABMS.cargarProdARemitoFrm pdfrm = new Ventanas_DialogBoxes_ABMS.cargarProdARemitoFrm();
            if (pdfrm.ShowDialog() == DialogResult.OK)
            {
                dgvRemito.Rows.Add(pdfrm.codigo, pdfrm.detalle, pdfrm.cantidad, pdfrm.precio, pdfrm.descuento, (pdfrm.cantidad * pdfrm.precio) - (pdfrm.descuento));
            }
            pdfrm.Close();

        }

        private void dgvRemito_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            TotaltextBox.Text = calcularSubtotal();
        }

        private string calcularSubtotal()
        {
            decimal subt = 0;
            foreach (DataGridViewRow row in dgvRemito.Rows)
            {
                subt += Convert.ToDecimal(row.Cells[5].Value);

            }
            return subt.ToString();
        }

        private void btnBorrarItem_Click(object sender, EventArgs e)
        {
            if (dgvRemito.SelectedRows.Count == 1)
            {
                dgvRemito.Rows.Remove(dgvRemito.CurrentRow);
                TotaltextBox.Text = calcularSubtotal();
            }
        }

        private void btnEmitirRemito_Click(object sender, EventArgs e)
        {
            if (!Validaciones.Validation.hasValidationErrors(this.Controls))
            {

                nvoRemito.fecha = fechaRemitoDtp.Value;
                //nvoRemito.numero_remito = Convert.ToInt32(nroRemitoTextBox.Text);
                nvoRemito.razon_social = razonSocialTextBox.Text;
                nvoRemito.cuil_cuit = CUILtextBox.Text;
                nvoRemito.condicion_iva = Convert.ToInt16(comboBoxCondIVA.SelectedValue);
                nvoRemito.condicion_venta = Convert.ToInt16(comboBoxCondVenta.SelectedValue);
                nvoRemito.direccion = direccionTextBox.Text;
                nvoRemito.total = Convert.ToDecimal(TotaltextBox.Text);


                using (var ctx = new LabDBEntities())
                {
                    ctx.Remito.Add(nvoRemito);
                    if (ctx.SaveChanges() != 0)
                    {


                        //cargo los detalles
                        Remito_Detalle r = new Remito_Detalle();
                        foreach (DataGridViewRow row in dgvRemito.Rows)
                        {
                            if (row.Cells[0].Value != null)
                            {
                                r.codigo_id = Convert.ToInt16(row.Cells[0].Value);
                                r.descripcion = Convert.ToString(row.Cells[1].Value);
                                r.cantidad = Convert.ToInt16(row.Cells[2].Value);
                                r.precio = Convert.ToDecimal(row.Cells[3].Value);
                                r.descuento = Convert.ToDecimal(row.Cells[4].Value);
                                r.total_venta = nvoRemito.total;
                                r.remito_id = nvoRemito.id_remito;
                                r.importe = Convert.ToDecimal(row.Cells[5].Value);
                                r.fecha = fechaRemitoDtp.Value;
                                ctx.Remito_Detalle.Add(r);

                                //ctx.Remito.Find(nvoRemito.id_remito).Remito_Detalle.Add(r);
                                if (ctx.SaveChanges() != 0)
                                {
                                    MessageBox.Show("Detalles Guardados con Exito");
                                }
                            }
                        }

                        MessageBox.Show("Remito Guardado con id: " + nvoRemito.id_remito);
                        ReportesLaboratorio.EmitirReporteRemitoFrm remitofrm = new ReportesLaboratorio.EmitirReporteRemitoFrm(nvoRemito.id_remito);
                        remitofrm.Show();
                        nroRemitoTextBox.Text = nvoRemito.numero_remito.ToString();
                        limpiartodo();
                    }
                }

            }
        }

        private void limpiartodo()
        {
            dgvRemito.Rows.Clear();
            cargarCombosyRemitoN();
            foreach (System.Windows.Forms.Control c in tableLayoutPanel1.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {

                    ((TextBox)c).ResetText();
                }
            }
            CUILtextBox.ResetText();
            fechaRemitoDtp.ResetText();
            TotaltextBox.ResetText();
            nroRemitoTextBox.Text = "Autogenerado";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Vista.mayoRediseño.PacientesNewForm pnf = new mayoRediseño.PacientesNewForm();
            if (pnf.ShowDialog() == DialogResult.Abort)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiartodo();
        }

        private void razonSocialTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (razonSocialTextBox.Text == "")
            {
                errorProvider1.SetError(razonSocialTextBox, "Campo Requerido!");
                e.Cancel = true;
                return;
            }
        }

        private void direccionTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (direccionTextBox.Text == "")
            {
                errorProvider1.SetError(direccionTextBox, "Campo Requerido!");
                e.Cancel = true;
                return;
            }
        }

        private void CUILtextBox_Validating(object sender, CancelEventArgs e)
        {
            if (CUILtextBox.Text == "")
            {
                errorProvider1.SetError(CUILtextBox, "Campo Requerido!");
                e.Cancel = true;
                return;
            }
        }

        private void comboBoxCondIVA_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxCondIVA.Text == "")
            {
                errorProvider1.SetError(comboBoxCondIVA, "Campo Requerido!");
                e.Cancel = true;
                return;
            }
        }

        private void comboBoxCondVenta_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxCondVenta.Text == "")
            {
                errorProvider1.SetError(comboBoxCondVenta, "Campo Requerido!");
                e.Cancel = true;
                return;
            }
        }


    }
}
