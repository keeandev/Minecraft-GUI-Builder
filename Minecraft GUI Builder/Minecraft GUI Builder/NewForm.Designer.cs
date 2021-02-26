
namespace Minecraft_GUI_Builder
{
    partial class NewForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewForm));
            this.sizeBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.slotsLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthUpDown = new System.Windows.Forms.NumericUpDown();
            this.sizeBox.SuspendLayout();
            this.infoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // sizeBox
            // 
            this.sizeBox.Controls.Add(this.cancelButton);
            this.sizeBox.Controls.Add(this.createButton);
            this.sizeBox.Controls.Add(this.titleLabel);
            this.sizeBox.Controls.Add(this.infoBox);
            this.sizeBox.Controls.Add(this.titleBox);
            this.sizeBox.Controls.Add(this.heightLabel);
            this.sizeBox.Controls.Add(this.widthLabel);
            this.sizeBox.Controls.Add(this.heightUpDown);
            this.sizeBox.Controls.Add(this.widthUpDown);
            this.sizeBox.Location = new System.Drawing.Point(13, 12);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(321, 152);
            this.sizeBox.TabIndex = 0;
            this.sizeBox.TabStop = false;
            this.sizeBox.Text = "Size";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(167, 120);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(148, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(6, 120);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(144, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(16, 95);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(32, 15);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.slotsLabel);
            this.infoBox.Location = new System.Drawing.Point(187, 22);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(128, 92);
            this.infoBox.TabIndex = 2;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Info";
            // 
            // slotsLabel
            // 
            this.slotsLabel.AutoSize = true;
            this.slotsLabel.Location = new System.Drawing.Point(6, 19);
            this.slotsLabel.Name = "slotsLabel";
            this.slotsLabel.Size = new System.Drawing.Size(44, 15);
            this.slotsLabel.TabIndex = 0;
            this.slotsLabel.Text = "Slots: 0";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(61, 91);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(120, 23);
            this.titleBox.TabIndex = 0;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(12, 66);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(46, 15);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Height:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(13, 37);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(42, 15);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Width:";
            // 
            // heightUpDown
            // 
            this.heightUpDown.Location = new System.Drawing.Point(61, 62);
            this.heightUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.heightUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(120, 23);
            this.heightUpDown.TabIndex = 0;
            this.heightUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightUpDown.ValueChanged += new System.EventHandler(this.heightUpDown_ValueChanged);
            // 
            // widthUpDown
            // 
            this.widthUpDown.Location = new System.Drawing.Point(61, 33);
            this.widthUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.widthUpDown.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(120, 23);
            this.widthUpDown.TabIndex = 0;
            this.widthUpDown.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.widthUpDown.ValueChanged += new System.EventHandler(this.widthUpDown_ValueChanged);
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 169);
            this.Controls.Add(this.sizeBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New";
            this.sizeBox.ResumeLayout(false);
            this.sizeBox.PerformLayout();
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sizeBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.NumericUpDown heightUpDown;
        private System.Windows.Forms.NumericUpDown widthUpDown;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.Label slotsLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createButton;
    }
}