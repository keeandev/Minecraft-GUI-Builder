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

        private bool itemsLastClicked = true;
        private bool numbersChecked;
        public string title = "GUI";
        public int slots = 54;
        private int x, y;

        private List<string> blockImageNames = new List<string>();
        private List<string> itemImageNames = new List<string>();
        private List<Image> itemImages = new List<Image>();
        private List<Image> blockImages = new List<Image>();
        private ArrayList itemList = new ArrayList();
        private ArrayList slotList = new ArrayList();

        private ImageBox inventoryImage = new ImageBox(InterpolationMode.NearestNeighbor);
        private Item currentItem;
        private static GUI instance;

        public GUI()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            instance = this;
        }

        /**
         * Handles the loading of items asynchronously, adding them to the itemPanel, hooking click events, and displaying them.
         **/

        private async void Form1_Load(object sender, EventArgs e)
        {
            CreateInventory();
            await Task.Run(async () =>
            {
                foreach (string file in Directory.GetFiles(Application.StartupPath + @"items"))
                {
                    itemImages.Add(new Bitmap(file));
                    itemImageNames.Add(Path.GetFileName(file));
                }
                foreach (string file in Directory.GetFiles(Application.StartupPath + @"blocks"))
                {
                    blockImages.Add(new Bitmap(file));
                    blockImageNames.Add(Path.GetFileName(file));
                }
            });
            items.Images.AddRange(itemImages.ToArray());
            for (int i = 0; i < items.Images.Count; i++)
            {
                Item item = new Item(itemImageNames[i]);
                item.Image.Width = 32;
                item.Image.Height = 32;
                items.ImageSize = new Size(32, 32);
                item.Image.Image = items.Images[i];
                item.Index = i;
                itemList.Add(item);
            }
            blocksPanel.SuspendLayout();
            foreach (Item item in itemList)
            {
                blocksPanel.Controls.Add(item.Image);
                item.onClick += ItemClicked;
            }
            blocksPanel.ResumeLayout();
        }


        /**
         * Draws an outline around the selected item in the item list.
        **/

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

        /**
         * Displays the slots on the inventory if the image has been set.
         * InterpolationMode.NearestNeighbor tells the graphics that we don't want antialiasing.
         * PixelOffsetMode.Half means coordinate (0.5, 0.5) aligns with the middle (=half) of the top left pixel, or to put it more clearly: (0, 0) is the top left of the top left pixel.
         * PixelOffsetMode.None means coordinate (0.5, 0.5) aligns with the top left corner of the top left pixel.
        **/

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
                    //if (slot.Block) e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    //else e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                    e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                    e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
                    e.Graphics.DrawImage(slot.Image, x, y, slot.Image.Width * 1.5f, slot.Image.Height * 1.5f);
                }
            }
        }

        /**
         * Handles clicking from the MenuStrip exit button.
         * This kills the program.
        **/

        private void exitButton_ItemClicked(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        /**
         * Handles clicking from the MenuStrip new button.
         * Creates and opens a new form.
        **/

        private void newButton_ItemClicked(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm();
            newForm.Show();
        }

        /**
         * Handles clicking from the MenuStrip numbers button.
         * Toggles the numbers buttons.
        **/

        private void numbers_ItemClicked(object sender, EventArgs e)
        {
            numbersChecked = !numbersChecked;
            if (numbersChecked)
            {
                numbers.Image = new Bitmap(Application.StartupPath + @"icons\check.png");
            }
            else numbers.Image = null;
        }

        /**
         * Handles item clicking from the blocksPanel.
         * Sets the currentItem to the clicked one.
        **/

        private void ItemClicked(object sender, EventArgs e)
        {
            Item item = (Item) sender;
            currentItem = item;
            blocksPanel.Invalidate();
        }

        /**
         * Handles the resizing of the window and repositions the inventory in the center of the screen.
        **/

        private void GUI_Resize(object sender, EventArgs e)
        {
            var workPanel = this.workPanel;
            inventoryImage.Location = new Point(workPanel.Location.X + workPanel.Width / 2 - inventoryImage.Width / 2, workPanel.Location.Y + workPanel.Height / 2 - inventoryImage.Height / 2);
        }

        /**
         * Finds the slot that you clicked in and sets the selectedItem's image to the slot's image.
         * Invalidate invalidates the image to redraw it.
         **/

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
            if (clickedSlot != null)
            {
                if (currentItem != null)
                {
                    clickedSlot.Image = currentItem.Image.Image;
                    clickedSlot.ImageName = currentItem.Title;
                    clickedSlot.Block = currentItem.Block;
                } else clickedSlot.Image = null;

                inventoryImage.Invalidate();
            }
        }

        /**
         * Focuses the panel when entered so workPanel_MouseClick will always execute.
        **/

        private void workPanel_MouseEnter(object sender, EventArgs e)
        {
            if(Focused) workPanel.Focus();
        }

        /**
         * Sets the currentItem to null when your not clicking in the inventory.
         * Invalidate invalidates the panel to redraw it.
         **/

        private void workPanel_MouseClick(object sender, MouseEventArgs e)
        {
            currentItem = null;
            blocksPanel.Invalidate();
        }

        /**
         * Sets all the slot images to null, clearing them.
         * Invalidate invalidates the image to redraw it.
        **/

        private void clearSlotsButton_Click(object sender, EventArgs e)
        {
            foreach (Slot slot in slotList)
            {
                slot.Image = null;
                inventoryImage.Invalidate();
            }
        }

        /**
         * Handles the switching from Items to Blocks buttons.
         * Invalidate invalidates the panel to redraw it.
        **/

        private void itemsButton_Click(object sender, EventArgs e)
        {
            if(!itemsLastClicked)
            {
                currentItem = null;
                blocksPanel.Controls.Clear();
                itemList.Clear();
                items.Images.Clear();
                items.Images.AddRange(itemImages.ToArray());
                for (int i = 0; i < items.Images.Count; i++)
                {
                    Item item = new Item(itemImageNames[i]);
                    item.Image.Width = 32;
                    item.Image.Height = 32;
                    items.ImageSize = new Size(32, 32);
                    item.Image.Image = items.Images[i];
                    item.Index = i;
                    itemList.Add(item);
                }
                blocksPanel.SuspendLayout();
                foreach (Item item in itemList)
                {
                    blocksPanel.Controls.Add(item.Image);
                    item.onClick += ItemClicked;
                }
                blocksPanel.ResumeLayout();
                itemsLastClicked = true;
                //blocksPanel.Invalidate();
            }
        }

        /**
         * Handles the switching from Blocks to Items buttons.
         * Invalidate invalidates the panel to redraw it.
         **/

        private void blocksButton_Click(object sender, EventArgs e)
        {
            if(itemsLastClicked)
            {
                currentItem = null;
                blocksPanel.Controls.Clear();
                itemList.Clear();
                items.Images.Clear();
                items.Images.AddRange(blockImages.ToArray());
                for (int i = 0; i < items.Images.Count; i++)
                {
                    Item item = new Item(blockImageNames[i]);
                    item.Image.Width = 32;
                    item.Image.Height = 32;
                    items.ImageSize = new Size(32, 32);
                    item.Image.Image = items.Images[i];
                    item.Block = true;
                    item.Index = i;
                    itemList.Add(item);
                }
                blocksPanel.SuspendLayout();
                foreach (Item item in itemList)
                {
                    blocksPanel.Controls.Add(item.Image);
                    item.onClick += ItemClicked;
                }
                blocksPanel.ResumeLayout();
                itemsLastClicked = false;
                //blocksPanel.Invalidate();
            }
        }

        /**
         * Creates and sets up the inventory.
         **/

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

        public Image GetInventoryImage() { return inventoryImage.Image; }
        public static GUI GetInstance() { return instance; }

    }
}
