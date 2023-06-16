using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cropper
{
    public partial class Form1 : Form
    {
        private Image originalImage;
        private Rectangle cropArea;
        private Point startPoint;
        private bool isDragging;
        private int selectionBorderSize = 8;
        private Cursor[] resizeCursors;
        private int resizeIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Carga la imagen de perfil de ejemplo
            originalImage = Image.FromFile(@"..\..\Source\HombreFrente.png");
            pbxImagenOriginal.Image = originalImage;
            pbxImagenOriginal.SizeMode = PictureBoxSizeMode.Zoom;

            // Configura cursores para redimensionar las esquinas
            resizeCursors = new Cursor[]
            {
                Cursors.SizeNWSE, Cursors.SizeNS, Cursors.SizeNESW, Cursors.SizeWE,
                Cursors.SizeNWSE, Cursors.SizeNS, Cursors.SizeNESW, Cursors.SizeWE
            };
        }

        private int GetResizeIndex(Point location)
        {
            // Obtiene el índice de redimensionamiento correspondiente según la ubicación del ratón
            if (cropArea.Contains(location))
            {
                if (Math.Abs(location.X - cropArea.Left) <= selectionBorderSize && Math.Abs(location.Y - cropArea.Top) <= selectionBorderSize)
                    return 0; // NW
                if (Math.Abs(location.X - cropArea.Right) <= selectionBorderSize && Math.Abs(location.Y - cropArea.Top) <= selectionBorderSize)
                    return 2; // NE
                if (Math.Abs(location.X - cropArea.Right) <= selectionBorderSize && Math.Abs(location.Y - cropArea.Bottom) <= selectionBorderSize)
                    return 4; // SE
                if (Math.Abs(location.X - cropArea.Left) <= selectionBorderSize && Math.Abs(location.Y - cropArea.Bottom) <= selectionBorderSize)
                    return 6; // SW
                if (Math.Abs(location.Y - cropArea.Top) <= selectionBorderSize)
                    return 1; // N
                if (Math.Abs(location.X - cropArea.Right) <= selectionBorderSize)
                    return 3; // E
                if (Math.Abs(location.Y - cropArea.Bottom) <= selectionBorderSize)
                    return 5; // S
                if (Math.Abs(location.X - cropArea.Left) <= selectionBorderSize)
                    return 7; // W
            }

            return -1;
        }


        private void pbxImagenOriginal_MouseDown_1(object sender, MouseEventArgs e)
        {
            // Comienza la operación de arrastre del área de recorte o redimensionamiento
            startPoint = e.Location;
            isDragging = true;
            resizeIndex = GetResizeIndex(e.Location);
        }

        private void pbxImagenOriginal_MouseMove_1(object sender, MouseEventArgs e)
        {
            // Actualiza el cursor durante el arrastre o redimensionamiento
            if (isDragging && resizeIndex == -1)
            {
                // Actualiza el área de recorte durante el arrastre
                int width = e.Location.X - startPoint.X;
                int height = e.Location.Y - startPoint.Y;
                cropArea = new Rectangle(startPoint.X, startPoint.Y, width, height);
                pbxImagenOriginal.Invalidate();
            }
            else if (isDragging && resizeIndex >= 0)
            {
                // Actualiza el área de recorte durante el redimensionamiento
                int newX = cropArea.X;
                int newY = cropArea.Y;
                int newWidth = cropArea.Width;
                int newHeight = cropArea.Height;

                switch (resizeIndex)
                {
                    case 0: // NW
                        newX = e.X;
                        newY = e.Y;
                        newWidth = cropArea.Right - newX;
                        newHeight = cropArea.Bottom - newY;
                        break;
                    case 1: // N
                        newY = e.Y;
                        newHeight = cropArea.Bottom - newY;
                        break;
                    case 2: // NE
                        newY = e.Y;
                        newWidth = e.X - cropArea.X;
                        newHeight = cropArea.Bottom - newY;
                        break;
                    case 3: // E
                        newWidth = e.X - cropArea.X;
                        break;
                    case 4: // SE
                        newWidth = e.X - cropArea.X;
                        newHeight = e.Y - cropArea.Y;
                        break;
                    case 5: // S
                        newHeight = e.Y - cropArea.Y;
                        break;
                    case 6: // SW
                        newX = e.X;
                        newWidth = cropArea.Right - newX;
                        newHeight = e.Y - cropArea.Y;
                        break;
                    case 7: // W
                        newX = e.X;
                        newWidth = cropArea.Right - newX;
                        break;
                }

                cropArea = new Rectangle(newX, newY, newWidth, newHeight);
                pbxImagenOriginal.Invalidate();
            }
            else
            {
                int resizeIndex = GetResizeIndex(e.Location);
                if (resizeIndex != -1)
                    pbxImagenOriginal.Cursor = resizeCursors[resizeIndex];
                else
                    pbxImagenOriginal.Cursor = Cursors.Default;
            }
        }

        private void pbxImagenOriginal_MouseUp_1(object sender, MouseEventArgs e)
        {
            // Finaliza la operación de arrastre o redimensionamiento
            isDragging = false;
            resizeIndex = -1;
        }

        private void pbxImagenOriginal_Paint_1(object sender, PaintEventArgs e)
        {
            // Dibuja el área de recorte y los bordes de selección
            if (cropArea.Width > 0 && cropArea.Height > 0)
            {
                // Dibuja el área de recorte
                e.Graphics.DrawImage(originalImage, pbxImagenOriginal.ClientRectangle, cropArea, GraphicsUnit.Pixel);

                // Dibuja los bordes de selección
                e.Graphics.DrawRectangle(Pens.Red, cropArea);

                // Dibuja los bordes de redimensionamiento
                if (isDragging)
                {
                    int x = cropArea.X - selectionBorderSize;
                    int y = cropArea.Y - selectionBorderSize;
                    int width = cropArea.Width + 2 * selectionBorderSize;
                    int height = cropArea.Height + 2 * selectionBorderSize;

                    e.Graphics.FillRectangle(Brushes.White, x, y, width, height);
                    for (int i = 0; i < 8; i++)
                    {
                        int bx = x + (i % 3) * (width / 3);
                        int by = y + (i / 3) * (height / 3);
                        e.Graphics.DrawRectangle(Pens.Black, bx, by, width / 3, height / 3);
                    }
                }
            }
        }

        private void cmdRecortar_Click_1(object sender, EventArgs e)
        {
            // Realiza el recorte de la imagen original
            Bitmap croppedImage = new Bitmap(300, 300);
            using (Graphics g = Graphics.FromImage(croppedImage))
            {
                g.DrawImage(originalImage, new Rectangle(0, 0, 300, 300), cropArea, GraphicsUnit.Pixel);
                pbxImagenDestino.Image = croppedImage;
            }
        }
    }
}
