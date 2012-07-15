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
    public partial class LoginFrm : Form
    {
        int contadorIntentosFallidos = 0;

        public LoginFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new LabDBEntities())
            {
             
                    tb_Usuarios usuario = (from users in ctx.tb_Usuarios.Where(ex => ex.username == textBoxUsername.Text.Trim().ToLower() && ex.password == textBoxPassword.Text.Trim().ToLower())
                                           select users).FirstOrDefault();


                    if (usuario != null)
                    {
                        //MessageBox.Show("Ingreso correcto");
                        WindowsFormsApplication1.Principal prin = new WindowsFormsApplication1.Principal(Convert.ToInt16(usuario.permisos));
                        this.Hide();
                        prin.Show();

                    }
                    else
                    {
                        contadorIntentosFallidos++;
                        MessageBox.Show("Ingreso Incorrecto. Intentos Fallidos: "+ contadorIntentosFallidos);


                    }
               
            }

        }
    }
}
