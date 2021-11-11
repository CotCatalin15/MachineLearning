using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing.CustomeControlls
{
    public partial class DrawablePictureBox : UserControl
    {
        Bitmap _framebuffer;
        Graphics _framebufferGraphics;

        public DrawablePictureBox()
        {
            InitializeComponent();
        }

        private void DrawablePictureBox_Load(object sender, EventArgs e)
        {
            BrushColor = Color.White;
            ClearColor = Color.Black;

            _framebuffer = new Bitmap(Width, Height);
            _framebufferGraphics = Graphics.FromImage(_framebuffer);
            this.drawablePicture.Image = _framebuffer;
        }

        private void drawablePicture_Resize(object sender, EventArgs e)
        {
            if (_framebuffer == null)
                _framebuffer = new Bitmap(Width, Height);
            else
            {
                Bitmap oldFramebuffer = _framebuffer;
                _framebuffer = new Bitmap(_framebuffer, Width, Height);
                oldFramebuffer.Dispose();
            }

            if(_framebufferGraphics != null)
                _framebufferGraphics.Dispose();

            _framebufferGraphics = Graphics.FromImage(_framebuffer);
            this.drawablePicture.Image = _framebuffer;
        }

        private void drawablePicture_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                int radius = 32;
                _framebufferGraphics.FillEllipse(new SolidBrush(BrushColor), 
                    new Rectangle(e.X - (radius / 2), e.Y - (radius / 2), radius, radius));
                drawablePicture.Invalidate();
            }
        }

        public void ClearCanvas()
        {
            _framebufferGraphics.Clear(ClearColor);
            this.drawablePicture.Invalidate();
        }


        public Color BrushColor { get; set; }
        public Color ClearColor { get; set; }

        public Bitmap Framebuffer { get => _framebuffer; }

    }
}
