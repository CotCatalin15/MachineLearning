
namespace ImageProcessing.CustomeControlls
{
    partial class DrawablePictureBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawablePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawablePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // drawablePicture
            // 
            this.drawablePicture.BackColor = System.Drawing.Color.Black;
            this.drawablePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawablePicture.Location = new System.Drawing.Point(0, 0);
            this.drawablePicture.Name = "drawablePicture";
            this.drawablePicture.Size = new System.Drawing.Size(250, 250);
            this.drawablePicture.TabIndex = 0;
            this.drawablePicture.TabStop = false;
            this.drawablePicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawablePicture_MouseMove);
            this.drawablePicture.Resize += new System.EventHandler(this.drawablePicture_Resize);
            // 
            // DrawablePictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.drawablePicture);
            this.Name = "DrawablePictureBox";
            this.Size = new System.Drawing.Size(250, 250);
            this.Load += new System.EventHandler(this.DrawablePictureBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawablePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drawablePicture;
    }
}
