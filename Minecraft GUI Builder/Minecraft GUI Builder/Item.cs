using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Minecraft_GUI_Builder
{
    public class Item
    {
        public bool Current { get; set; }
        public int Index { get; set; }
        public string Title { get; set; }
        public PictureBox Image { get; set; }

        public delegate void clicked(object sender, EventArgs e);
        public event clicked onClick;

        public Item(string title)
        {
            Title = title;
            Image = new ImageBox();
            Image.Click += onClicked;
        }

        public void onClicked(object sender, EventArgs e)
        {
            if (onClick != null) onClick(this, e);
        }
    }
}
