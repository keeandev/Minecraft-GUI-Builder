using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Minecraft_GUI_Builder
{
    class ImageBox : PictureBox
    {

        private InterpolationMode mode;

        public ImageBox(InterpolationMode mode)
        {
            this.mode = mode;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = mode;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            base.OnPaint(e);
        }
    }

}
