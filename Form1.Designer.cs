namespace Cropper
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxImagenOriginal = new System.Windows.Forms.PictureBox();
            this.cmdRecortar = new System.Windows.Forms.Button();
            this.pbxImagenDestino = new System.Windows.Forms.PictureBox();
            this.pbxFinal = new System.Windows.Forms.PictureBox();
            this.btnSubirImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImagenOriginal
            // 
            this.pbxImagenOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImagenOriginal.Location = new System.Drawing.Point(47, 57);
            this.pbxImagenOriginal.Name = "pbxImagenOriginal";
            this.pbxImagenOriginal.Size = new System.Drawing.Size(300, 300);
            this.pbxImagenOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenOriginal.TabIndex = 0;
            this.pbxImagenOriginal.TabStop = false;
            // 
            // cmdRecortar
            // 
            this.cmdRecortar.Location = new System.Drawing.Point(404, 203);
            this.cmdRecortar.Name = "cmdRecortar";
            this.cmdRecortar.Size = new System.Drawing.Size(75, 23);
            this.cmdRecortar.TabIndex = 2;
            this.cmdRecortar.Text = "Recortar";
            this.cmdRecortar.UseVisualStyleBackColor = true;
            // 
            // pbxImagenDestino
            // 
            this.pbxImagenDestino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxImagenDestino.Location = new System.Drawing.Point(555, 57);
            this.pbxImagenDestino.Name = "pbxImagenDestino";
            this.pbxImagenDestino.Size = new System.Drawing.Size(300, 300);
            this.pbxImagenDestino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenDestino.TabIndex = 3;
            this.pbxImagenDestino.TabStop = false;
            // 
            // pbxFinal
            // 
            this.pbxFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxFinal.Location = new System.Drawing.Point(374, 365);
            this.pbxFinal.Name = "pbxFinal";
            this.pbxFinal.Size = new System.Drawing.Size(150, 150);
            this.pbxFinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFinal.TabIndex = 0;
            this.pbxFinal.TabStop = false;
            // 
            // btnSubirImagen
            // 
            this.btnSubirImagen.Location = new System.Drawing.Point(47, 365);
            this.btnSubirImagen.Name = "btnSubirImagen";
            this.btnSubirImagen.Size = new System.Drawing.Size(75, 23);
            this.btnSubirImagen.TabIndex = 2;
            this.btnSubirImagen.Text = "Recortar";
            this.btnSubirImagen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 527);
            this.Controls.Add(this.pbxImagenDestino);
            this.Controls.Add(this.btnSubirImagen);
            this.Controls.Add(this.cmdRecortar);
            this.Controls.Add(this.pbxFinal);
            this.Controls.Add(this.pbxImagenOriginal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cropper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFinal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImagenOriginal;
        private System.Windows.Forms.Button cmdRecortar;
        private System.Windows.Forms.PictureBox pbxImagenDestino;
        private System.Windows.Forms.PictureBox pbxFinal;
        private System.Windows.Forms.Button btnSubirImagen;
    }
}

