using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Minecraft_GUI_Builder
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }
        private void NewForm_Load(object sender, EventArgs e)
        {
            slotsLabel.Text = "Slots: " + widthUpDown.Value * heightUpDown.Value;
        }

        private void widthUpDown_ValueChanged(object sender, EventArgs e)
        {
            slotsLabel.Text = "Slots: " + widthUpDown.Value * heightUpDown.Value;
        }

        private void heightUpDown_ValueChanged(object sender, EventArgs e)
        {
            slotsLabel.Text = "Slots: " + widthUpDown.Value * heightUpDown.Value;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            GUI.GetInstance().title = titleBox.Text;
            GUI.GetInstance().slots = (int) (widthUpDown.Value * heightUpDown.Value);
            GUI.GetInstance().CreateInventory();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
