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
    public partial class GestorDonaciones : Form
    {
        public GestorDonaciones()
        {
            InitializeComponent();
            cargarDatagrid();
        }

        private void cargarDatagrid()
        {

            using (var ctx = new LabDBEntities())
            {
                var query = from v in ctx.Donaciones
                            join p in ctx.tb_Donantes on v.donante_id equals p.id_donante
                            join x in ctx.tb_GrupoSanguineo on v.grupo_id equals x.id_grupo
                            join u in ctx.tb_Usuarios on v.bioquimica equals u.id_usuario
                            select new
                                {
                                    Id = v.id_donacion,
                                    Fecha = v.fecha_donacion,
                                    Nombre = p.nombre,
                                    Apellido = p.apellido,
                                    Grupo_Sanguineo = x.descripcion,
                                    Bioquimica = u.nombre + " " + u.apellido
                                };
                dataGridView1.DataSource = query.ToList();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Vista.Ventanas_DialogBoxes_ABMS.NuevaDonacion dona = new Vista.Ventanas_DialogBoxes_ABMS.NuevaDonacion();
            if (dona.ShowDialog() == DialogResult.OK)
            {
                
                cargarDatagrid();
            }
        }
    }
}
