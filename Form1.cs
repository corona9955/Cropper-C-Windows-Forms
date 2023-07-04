using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cropper
{
    public partial class Form1 : Form
    {

        int xDown = 0;
        int yDown = 0;
        int xUp = 0;
        int yUp = 0;
        Rectangle rectCropArea = new Rectangle();
        System.IO.MemoryStream ms = new System.IO.MemoryStream();
        Task timeout;
        string fn = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdSubirImagen_Click(object sender, EventArgs e)
        {
            // Crea una instancia del cuadro de diálogo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Establece los filtros de archivo para mostrar solo las imágenes
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            // Abre el cuadro de diálogo de selección de archivo
            DialogResult result = openFileDialog.ShowDialog();

            // Comprueba si el usuario seleccionó un archivo
            if (result == DialogResult.OK)
            {
                // Obtiene la ruta de archivo seleccionada
                string imagePath = openFileDialog.FileName;

                // Carga la imagen en un objeto Image
                System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);

                // Asigna la imagen al PictureBox
                pbxImagenOriginal.Image = image;
            }
            pbxImagenOriginal.Cursor = Cursors.Cross;
        }

        private void pbxImagenOriginal_MouseUp(object sender, MouseEventArgs e)
        {
            //pictureBox1.Image.Clone();
            xUp = e.X;
            yUp = e.Y;
            Rectangle rec = new Rectangle(xDown, yDown, Math.Abs(xUp - xDown), Math.Abs(yUp - yDown));
            using (Pen pen = new Pen(Color.YellowGreen, 3))
            {

                pbxImagenOriginal.CreateGraphics().DrawRectangle(pen, rec);
            }
            rectCropArea = rec;
            cmdRecortar.Enabled = true;
        }

        private void pbxImagenOriginal_MouseDown(object sender, MouseEventArgs e)
        {
            pbxImagenOriginal.Invalidate();

            xDown = e.X;
            yDown = e.Y;
            cmdRecortar.Enabled = true;
        }

        private void cmdRecortar_Click(object sender, EventArgs e)
        {
            try
            {
                pbxImagenDestino.Refresh();
                // Prepare a new Bitmap on which the cropped image will be drawn
                Bitmap sourceBitmap = new Bitmap(pbxImagenOriginal.Image, pbxImagenOriginal.Width, pbxImagenOriginal.Height);
                Graphics g = pbxImagenDestino.CreateGraphics();

                // Create a new Bitmap to store the cropped image
                Bitmap croppedBitmap = new Bitmap(pbxImagenDestino.Width, pbxImagenDestino.Height);
                using (Graphics croppedG = Graphics.FromImage(croppedBitmap))
                {
                    // Draw the image onto the new Bitmap
                    croppedG.DrawImage(sourceBitmap, new Rectangle(0, 0, pbxImagenDestino.Width, pbxImagenDestino.Height), rectCropArea, GraphicsUnit.Pixel);
                }
                // Display the cropped image in another PictureBox (e.g., pbxImagenCropped)
                pbxImagenDestino.Image = croppedBitmap;

                pbxFinal.Image = croppedBitmap;

                cmdRecortar.Enabled = false;


            }
            catch (Exception ex)
            {

            }
        }
    }
}
