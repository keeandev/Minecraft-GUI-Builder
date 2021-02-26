using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Minecraft_GUI_Builder
{
    class Slot
    {
        public int Index { get; set; }
        public Image Image { get; set; }
        public Slot(int Index)
        {
            this.Index = Index;
        }
    }
}
