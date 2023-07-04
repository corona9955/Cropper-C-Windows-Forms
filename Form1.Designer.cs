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
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImagenOriginal
            // 
            this.pbxImagenOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImagenOriginal.Location = new System.Drawing.Point(47, 44);
            this.pbxImagenOriginal.Name = "pbxImagenOriginal";
            this.pbxImagenOriginal.Size = new System.Drawing.Size(150, 150);
            this.pbxImagenOriginal.TabIndex = 0;
            this.pbxImagenOriginal.TabStop = false;
            this.pbxImagenOriginal.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxImagenOriginal_Paint_1);
            this.pbxImagenOriginal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxImagenOriginal_MouseDown_1);
            this.pbxImagenOriginal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxImagenOriginal_MouseMove_1);
            this.pbxImagenOriginal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxImagenOriginal_MouseUp_1);
            // 
            // cmdRecortar
            // 
            this.cmdRecortar.Location = new System.Drawing.Point(199, 218);
            this.cmdRecortar.Name = "cmdRecortar";
            this.cmdRecortar.Size = new System.Drawing.Size(75, 23);
            this.cmdRecortar.TabIndex = 2;
            this.cmdRecortar.Text = "Recortar";
            this.cmdRecortar.UseVisualStyleBackColor = true;
            this.cmdRecortar.Click += new System.EventHandler(this.cmdRecortar_Click_1);
            // 
            // pbxImagenDestino
            // 
            this.pbxImagenDestino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxImagenDestino.Location = new System.Drawing.Point(269, 44);
            this.pbxImagenDestino.Name = "pbxImagenDestino";
            this.pbxImagenDestino.Size = new System.Drawing.Size(150, 150);
            this.pbxImagenDestino.TabIndex = 3;
            this.pbxImagenDestino.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 260);
            this.Controls.Add(this.pbxImagenDestino);
            this.Controls.Add(this.cmdRecortar);
            this.Controls.Add(this.pbxImagenOriginal);
            this.Name = "Form1";
            this.Text = "Cropper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenDestino)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImagenOriginal;
        private System.Windows.Forms.Button cmdRecortar;
        private System.Windows.Forms.PictureBox pbxImagenDestino;
    }
}

