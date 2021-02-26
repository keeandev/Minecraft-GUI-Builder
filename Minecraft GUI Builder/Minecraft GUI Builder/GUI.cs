using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_GUI_Builder
{
    public partial class GUI : Form
    {

        private bool numbersChecked;

        ArrayList itemList = new ArrayList();
        ArrayList slotList = new ArrayList();
        public static int drawIndex, slots = 54, x, y;
        public static string title = "GUI";

        private ImageBox inventoryImage = new ImageBox();
        private Item currentItem;
        private static GUI instance;

        public GUI()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            instance = this;
            foreach(var file in Directory.GetFiles(Application.StartupPath + @"items")) items.Images.Add(new Bitmap(file));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < items.Images.Count; i++)
            {
                Item item = new Item(i.ToString());
                item.Image.Width = 32;
                item.Image.Height = 32;
                items.ImageSize = new Size(32, 32);
                item.Image.Image = items.Images[i];
                itemList.Add(item);
            }
            foreach (Item item in itemList)
            {
                blocksPanel.Controls.Add(item.Image);
                item.onClick += ItemClicked;
            }
            CreateInventory();
            Application.DoEvents();
        }


        private void blocksPanel_Paint(object sender, PaintEventArgs e)
        {
            if (currentItem != null)
            {
                Pen pen = new Pen(Color.Black);
                pen.Width = 2;
                e.Graphics.DrawRectangle(pen, new Rectangle(currentItem.Image.Location.X - 2, currentItem.Image.Location.Y - 2, currentItem.Image.Width + 2, currentItem.Image.Height + 2));
                pen.Dispose();
            }
        }

        private void InventoryImage_Paint(object sender, PaintEventArgs e)
        {
            int xPos = 7 * 3 + 2;
            int yPos = 14 * 3 + 7;
            for (int i = 0; i < slotList.Count; i++)
            {
                Slot slot = (Slot)slotList[i];
                int x = xPos + (18 * 3) * (i % 9);
                int y = yPos + (18 * 3) * (i / 9);
                if(slot.Image != null)
                {
                    e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                    e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
                    e.Graphics.DrawImage(slot.Image, x, y, slot.Image.Width * 1.5f, slot.Image.Height * 1.5f);
                }
            }
        }

        private void exitButton_ItemClicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void newButton_ItemClicked(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm();
            newForm.Show();
        }
        private void numbers_ItemClicked(object sender, EventArgs e)
        {
            numbersChecked = !numbersChecked;
            if (numbersChecked)
            {
                numbers.Image = new Bitmap(Application.StartupPath + @"icons\check.png");
            }
            else numbers.Image = null;
        }
        private void ItemClicked(object sender, EventArgs e)
        {
            Item item = (Item) sender;
            currentItem = item;
            blocksPanel.Invalidate();
        }

        private void GUI_Resize(object sender, EventArgs e)
        {
            var workPanel = this.workPanel;
            inventoryImage.Location = new Point(workPanel.Location.X + workPanel.Width / 2 - inventoryImage.Width / 2, workPanel.Location.Y + workPanel.Height / 2 - inventoryImage.Height / 2);
            Application.DoEvents();
        }

        private void InventoryImage_Click(object sender, MouseEventArgs e)
        {
            int xPos = 7 * 3 + 2;
            int yPos = 14 * 3 + 6;
            Slot clickedSlot = null;
            for (int i = 0; i < slotList.Count; i++)
            {
                int x = xPos + (18 * 3) * (i % 9);
                int y = yPos + (18 * 3) * (i / 9);
                if (e.X >= x && e.X <= x + (18 * 3) && e.Y >= y && e.Y <= y + (18 * 3)) clickedSlot = (Slot) slotList[i];
            }
            Debug.WriteLine(clickedSlot != null ? clickedSlot.Index : "no slot / null");
            if (clickedSlot != null)
            {
                if (currentItem != null)
                {
                    clickedSlot.Image = currentItem.Image.Image;
                }
                else clickedSlot.Image = null;
                inventoryImage.Invalidate();
            }
        }

        private void clearSlotsButton_Click(object sender, EventArgs e)
        {
            foreach (Slot slot in slotList)
            {
                slot.Image = null;
                inventoryImage.Invalidate();
            }
        }

        public void CreateInventory()
        {
            slotList.Clear();
            for (int i = 0; i < slots; i++)
            {
                Slot slot = new Slot(i);
                slotList.Add(slot);
            }
            inventoryImage.SizeMode = PictureBoxSizeMode.StretchImage;
            inventoryImage.MouseClick += InventoryImage_Click;
            inventoryImage.Image = new Bitmap(Application.StartupPath + @"icons\inventory_" + slots + ".png");
            inventoryImage.Width = inventoryImage.Image.Width * 3;
            inventoryImage.Height = inventoryImage.Image.Height * 3;
            inventoryImage.Paint += InventoryImage_Paint;
            inventoryImage.Location = new Point(workPanel.Location.X + workPanel.Width / 2 - inventoryImage.Width / 2, workPanel.Location.Y + workPanel.Height / 2 - inventoryImage.Height / 2);
            if (!workPanel.Controls.Contains(inventoryImage)) workPanel.Controls.Add(inventoryImage);
        }

        public Image GetInventoryImage()
        {
            return inventoryImage.Image;
        }
        public static GUI GetInstance()
        {
            return instance;
        }

    }
}
