
namespace Minecraft_GUI_Builder
{
    partial class GUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.items = new System.Windows.Forms.ImageList(this.components);
            this.programMenu = new System.Windows.Forms.MenuStrip();
            this.fileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.newButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.editButton = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSlotsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.viewButton = new System.Windows.Forms.ToolStripMenuItem();
            this.numbers = new System.Windows.Forms.ToolStripMenuItem();
            this.blocksPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.workPanel = new System.Windows.Forms.Panel();
            this.itemsButton = new System.Windows.Forms.Button();
            this.blocksButton = new System.Windows.Forms.Button();
            this.programMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // items
            // 
            this.items.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.items.ImageSize = new System.Drawing.Size(32, 32);
            this.items.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // programMenu
            // 
            this.programMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.programMenu.AutoSize = false;
            this.programMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton,
            this.editButton,
            this.viewButton});
            this.programMenu.Location = new System.Drawing.Point(0, 0);
            this.programMenu.Name = "programMenu";
            this.programMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.programMenu.Size = new System.Drawing.Size(800, 24);
            this.programMenu.TabIndex = 2;
            this.programMenu.Text = "programMenu";
            // 
            // fileButton
            // 
            this.fileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButton,
            this.exitButton});
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(37, 20);
            this.fileButton.Text = "File";
            // 
            // newButton
            // 
            this.newButton.Image = ((System.Drawing.Image)(resources.GetObject("newButton.Image")));
            this.newButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(98, 22);
            this.newButton.Text = "New";
            this.newButton.Click += new System.EventHandler(this.newButton_ItemClicked);
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 22);
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Click += new System.EventHandler(this.exitButton_ItemClicked);
            // 
            // editButton
            // 
            this.editButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearSlotsButton});
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(39, 20);
            this.editButton.Text = "Edit";
            // 
            // clearSlotsButton
            // 
            this.clearSlotsButton.Image = ((System.Drawing.Image)(resources.GetObject("clearSlotsButton.Image")));
            this.clearSlotsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearSlotsButton.Name = "clearSlotsButton";
            this.clearSlotsButton.Size = new System.Drawing.Size(129, 22);
            this.clearSlotsButton.Text = "Clear Slots";
            this.clearSlotsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearSlotsButton.Click += new System.EventHandler(this.clearSlotsButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numbers});
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(44, 20);
            this.viewButton.Text = "View";
            // 
            // numbers
            // 
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(123, 22);
            this.numbers.Text = "Numbers";
            this.numbers.Click += new System.EventHandler(this.numbers_ItemClicked);
            // 
            // blocksPanel
            // 
            this.blocksPanel.AutoScroll = true;
            this.blocksPanel.BackColor = System.Drawing.Color.Transparent;
            this.blocksPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.blocksPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.blocksPanel.ForeColor = System.Drawing.Color.Transparent;
            this.blocksPanel.Location = new System.Drawing.Point(626, 24);
            this.blocksPanel.Margin = new System.Windows.Forms.Padding(0);
            this.blocksPanel.Name = "blocksPanel";
            this.blocksPanel.Size = new System.Drawing.Size(174, 426);
            this.blocksPanel.TabIndex = 6;
            this.blocksPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.blocksPanel_Paint);
            // 
            // workPanel
            // 
            this.workPanel.AutoScroll = true;
            this.workPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workPanel.Location = new System.Drawing.Point(0, 24);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(626, 426);
            this.workPanel.TabIndex = 7;
            this.workPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.workPanel_MouseClick);
            this.workPanel.MouseEnter += new System.EventHandler(this.workPanel_MouseEnter);
            // 
            // itemsButton
            // 
            this.itemsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsButton.Location = new System.Drawing.Point(625, 1);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(83, 23);
            this.itemsButton.TabIndex = 8;
            this.itemsButton.Text = "Items";
            this.itemsButton.UseVisualStyleBackColor = true;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // blocksButton
            // 
            this.blocksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blocksButton.Location = new System.Drawing.Point(717, 1);
            this.blocksButton.Name = "blocksButton";
            this.blocksButton.Size = new System.Drawing.Size(83, 23);
            this.blocksButton.TabIndex = 8;
            this.blocksButton.Text = "Blocks";
            this.blocksButton.UseVisualStyleBackColor = true;
            this.blocksButton.Click += new System.EventHandler(this.blocksButton_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.blocksButton);
            this.Controls.Add(this.itemsButton);
            this.Controls.Add(this.workPanel);
            this.Controls.Add(this.blocksPanel);
            this.Controls.Add(this.programMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.programMenu;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft GUI Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.GUI_Resize);
            this.programMenu.ResumeLayout(false);
            this.programMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList items;
        private System.Windows.Forms.MenuStrip programMenu;
        private System.Windows.Forms.ToolStripMenuItem fileButton;
        private System.Windows.Forms.ToolStripMenuItem newButton;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.ToolStripMenuItem editButton;
        private System.Windows.Forms.ToolStripMenuItem clearSlotsButton;
        private System.Windows.Forms.ToolStripMenuItem viewButton;
        private System.Windows.Forms.ToolStripMenuItem numbers;
        private System.Windows.Forms.FlowLayoutPanel blocksPanel;
        public System.Windows.Forms.Panel workPanel;
        private System.Windows.Forms.Button itemsButton;
        private System.Windows.Forms.Button blocksButton;
    }
}

