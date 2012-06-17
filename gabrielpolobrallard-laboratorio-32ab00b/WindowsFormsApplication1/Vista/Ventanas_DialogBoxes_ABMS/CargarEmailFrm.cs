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
    public partial class CargarEmailFrm : Form
    {

        private int tipo = 0;
        public int pacienteSelId { get; set; }
        public int tel_id_guardado { get; set; }
        private int modificado = 0;
        private int idMod;
        public CargarEmailFrm()
        {
            InitializeComponent();
        }
        public CargarEmailFrm(int opcion)
        {

            //opcion 1 paciente
            switch (opcion)
            {
                case 1:
                    {
                        this.tipo = 1;//tipo paciente
                        break;
                    }
                case 2:
                    {
                        this.tipo = 2; //tipo donante
                        break;
                    }
            }

            InitializeComponent();
        }



        public CargarEmailFrm(int opcion, int id)
        {
            InitializeComponent();
            //opcion 1 paciente
            switch (opcion)
            {
                case 1:
                    {
                        this.tipo = 1;//tipo paciente
                        break;
                    }
                case 2:
                    {
                        this.tipo = 2; //tipo donante
                        break;
                    }
            }

            using (var ctx = new LabDBEntities()) {
                textBoxTelefono.Text = ctx.tb_EmailsTodos.Find(id).email;

            }
            modificado = 1;
            idMod = id;

        }






        //boton guardartelefono
        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new LabDBEntities())
            {
                switch (this.tipo)
                {
                    case 1:
                        { //Guarda el PACIENTE en la bd
                            if (modificado == 1)
                            {
                                ctx.tb_Pacientes.Find(pacienteSelId).tb_EmailsTodos.FirstOrDefault(em => em.id_email == idMod).email = textBoxTelefono.Text;
                            }
                            else
                            {
                                tb_EmailsTodos tel = new tb_EmailsTodos();

                                tel.email = textBoxTelefono.Text;
                                tel.borrado = 0;
                                ctx.tb_Pacientes.Find(pacienteSelId).tb_EmailsTodos.Add(tel);
                            }

                            if (ctx.SaveChanges() != 0)
                            {
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                this.DialogResult = DialogResult.Cancel;
                            }
                            break;
                        }
                    case 2:
                        { // carga tel ed DONANTE

                            break;
                        }
                }
            }


        }
    }
}
