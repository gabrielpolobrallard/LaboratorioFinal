using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Librerias
{
    class Utilidades
    {

        public static byte[] Image2Bytes(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;
            //
            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }

        public static Image Bytes2Image(byte[] bytes)
        {
            if (bytes == null) return null;
            //
            MemoryStream ms = new MemoryStream(bytes);
            Bitmap bm = null;
            try
            {
                bm = new Bitmap(ms);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return bm;
        }


        public static byte[] cargarImagen(OpenFileDialog openFileDialogCargaImagenEstab, PictureBox pict)
        {
            byte[] imgTmp = null;
            string garrobito;
            //Definimos los filtros de archivos a permitir, en este caso imagenes
            openFileDialogCargaImagenEstab.Filter = "Bitmap files (*.bmp)|*.bmp|Gif files (*.gif)|*.gif|JGP files (*.jpg)|*.jpg|All (*.*)|*.* |PNG (*.patito)|*.png ";
            ///Establece que filtro se mostrará por deceto en este caso, 3=jpg
            openFileDialogCargaImagenEstab.FilterIndex = 3;
            ///Esto aparece en el Nombre del archivo a seleccionar, se puede quitar no es fundamental
            openFileDialogCargaImagenEstab.FileName = "Seleccione una imagen";

            //El titulo de la Ventana....
            openFileDialogCargaImagenEstab.Title = "Cargar Imagen";

            //El directorio que por deceto habrirá, para cada contrapleca del Path colocar \\ C:\\Fotitos\\Wizard y así sucesivamente
            openFileDialogCargaImagenEstab.InitialDirectory = "c:\\";

            /// Evalúa que si al aparecer el cuadro de dialogo la persona presionó Ok
            if (openFileDialogCargaImagenEstab.ShowDialog() == DialogResult.OK)
            {

                /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en la variable Garrobito
                garrobito = openFileDialogCargaImagenEstab.FileName;
                //Por ultimo se la asignamos al PictureBox
                if (garrobito != "")
                {
                    pict.Image = Image.FromFile(@garrobito);
                    imgTmp = Librerias.Utilidades.Image2Bytes(pict.Image);
                }


            }


            return imgTmp;



        }

    }
}
