namespace IMAVD_IMAGEM
{
    partial class mainAppWindow
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
            this.exitButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.chosenColourPanel = new System.Windows.Forms.Panel();
            this.chosenColourLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cropImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipVerticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rotate90ToTheRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90ToTheLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBrightness = new System.Windows.Forms.TextBox();
            this.txtContrast = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(692, 2);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(74, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // chosenColourPanel
            // 
            this.chosenColourPanel.Location = new System.Drawing.Point(311, 104);
            this.chosenColourPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chosenColourPanel.Name = "chosenColourPanel";
            this.chosenColourPanel.Size = new System.Drawing.Size(73, 10);
            this.chosenColourPanel.TabIndex = 4;
            this.chosenColourPanel.Visible = false;
            this.chosenColourPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.chosenColourPanel_Paint);
            // 
            // chosenColourLabel
            // 
            this.chosenColourLabel.AutoSize = true;
            this.chosenColourLabel.Location = new System.Drawing.Point(308, 86);
            this.chosenColourLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chosenColourLabel.Name = "chosenColourLabel";
            this.chosenColourLabel.Size = new System.Drawing.Size(132, 16);
            this.chosenColourLabel.TabIndex = 5;
            this.chosenColourLabel.Text = "Chosen Colour Label";
            this.chosenColourLabel.Visible = false;
            this.chosenColourLabel.Click += new System.EventHandler(this.chosenColourLabel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.imageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(778, 26);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.informationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.loadToolStripMenuItem.Text = "Open";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(253, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(253, 6);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator5,
            this.cropImageToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(176, 6);
            // 
            // cropImageToolStripMenuItem
            // 
            this.cropImageToolStripMenuItem.Name = "cropImageToolStripMenuItem";
            this.cropImageToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.cropImageToolStripMenuItem.Text = "Crop Image";
            this.cropImageToolStripMenuItem.Click += new System.EventHandler(this.cropImageToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem1,
            this.zoomOutToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomToolStripMenuItem1
            // 
            this.zoomToolStripMenuItem1.Name = "zoomToolStripMenuItem1";
            this.zoomToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl++";
            this.zoomToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.zoomToolStripMenuItem1.Size = new System.Drawing.Size(206, 26);
            this.zoomToolStripMenuItem1.Text = "Zoom in";
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+-";
            this.zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.zoomOutToolStripMenuItem.Text = "Zoom out";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseColorToolStripMenuItem,
            this.pickColorToolStripMenuItem,
            this.findColorToolStripMenuItem,
            this.invertColorsToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // chooseColorToolStripMenuItem
            // 
            this.chooseColorToolStripMenuItem.Name = "chooseColorToolStripMenuItem";
            this.chooseColorToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.chooseColorToolStripMenuItem.Text = "Choose Color";
            this.chooseColorToolStripMenuItem.Click += new System.EventHandler(this.chooseColorToolStripMenuItem_Click);
            // 
            // pickColorToolStripMenuItem
            // 
            this.pickColorToolStripMenuItem.Name = "pickColorToolStripMenuItem";
            this.pickColorToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.pickColorToolStripMenuItem.Text = "Pick Color";
            this.pickColorToolStripMenuItem.Click += new System.EventHandler(this.pickColorToolStripMenuItem_Click);
            // 
            // findColorToolStripMenuItem
            // 
            this.findColorToolStripMenuItem.Name = "findColorToolStripMenuItem";
            this.findColorToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.findColorToolStripMenuItem.Text = "Find Color";
            this.findColorToolStripMenuItem.Click += new System.EventHandler(this.findColorToolStripMenuItem_Click);
            // 
            // invertColorsToolStripMenuItem
            // 
            this.invertColorsToolStripMenuItem.Name = "invertColorsToolStripMenuItem";
            this.invertColorsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.invertColorsToolStripMenuItem.Text = "Invert Colors";
            this.invertColorsToolStripMenuItem.Click += new System.EventHandler(this.invertColorsToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipHorizontallyToolStripMenuItem,
            this.flipVerticallyToolStripMenuItem,
            this.toolStripSeparator3,
            this.rotate90ToTheRightToolStripMenuItem,
            this.rotate90ToTheLeftToolStripMenuItem,
            this.rotate180ToolStripMenuItem,
            this.toolStripSeparator4,
            this.zoomToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // flipHorizontallyToolStripMenuItem
            // 
            this.flipHorizontallyToolStripMenuItem.Name = "flipHorizontallyToolStripMenuItem";
            this.flipHorizontallyToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.flipHorizontallyToolStripMenuItem.Text = "Flip horizontally";
            this.flipHorizontallyToolStripMenuItem.Click += new System.EventHandler(this.flipHorizontallyToolStripMenuItem_Click);
            // 
            // flipVerticallyToolStripMenuItem
            // 
            this.flipVerticallyToolStripMenuItem.Name = "flipVerticallyToolStripMenuItem";
            this.flipVerticallyToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.flipVerticallyToolStripMenuItem.Text = "Flip vertically";
            this.flipVerticallyToolStripMenuItem.Click += new System.EventHandler(this.flipVerticallyToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(290, 6);
            // 
            // rotate90ToTheRightToolStripMenuItem
            // 
            this.rotate90ToTheRightToolStripMenuItem.Name = "rotate90ToTheRightToolStripMenuItem";
            this.rotate90ToTheRightToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.rotate90ToTheRightToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.rotate90ToTheRightToolStripMenuItem.Text = "Rotate 90º to the right";
            this.rotate90ToTheRightToolStripMenuItem.Click += new System.EventHandler(this.rotate90ToTheRightToolStripMenuItem_Click);
            // 
            // rotate90ToTheLeftToolStripMenuItem
            // 
            this.rotate90ToTheLeftToolStripMenuItem.Name = "rotate90ToTheLeftToolStripMenuItem";
            this.rotate90ToTheLeftToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.rotate90ToTheLeftToolStripMenuItem.Text = "Rotate 90º to the left";
            this.rotate90ToTheLeftToolStripMenuItem.Click += new System.EventHandler(this.rotate90ToTheLeftToolStripMenuItem_Click);
            // 
            // rotate180ToolStripMenuItem
            // 
            this.rotate180ToolStripMenuItem.Name = "rotate180ToolStripMenuItem";
            this.rotate180ToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.rotate180ToolStripMenuItem.Text = "Rotate 180º";
            this.rotate180ToolStripMenuItem.Click += new System.EventHandler(this.rotate180ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(290, 6);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem8,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(128, 26);
            this.toolStripMenuItem2.Text = "50%";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(128, 26);
            this.toolStripMenuItem3.Text = "100%";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(128, 26);
            this.toolStripMenuItem8.Text = "150%";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(128, 26);
            this.toolStripMenuItem4.Text = "200%";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(128, 26);
            this.toolStripMenuItem5.Text = "300%";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(128, 26);
            this.toolStripMenuItem6.Text = "400%";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(128, 26);
            this.toolStripMenuItem7.Text = "500%";
            // 
            // pbox
            // 
            this.pbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbox.Location = new System.Drawing.Point(11, 33);
            this.pbox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(766, 407);
            this.pbox.TabIndex = 2;
            this.pbox.TabStop = false;
            this.pbox.Click += new System.EventHandler(this.pbox_ClickAsync);
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Location = new System.Drawing.Point(130, 467);
            this.trackBarBrightness.Maximum = 255;
            this.trackBarBrightness.Minimum = -255;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(636, 56);
            this.trackBarBrightness.TabIndex = 6;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Location = new System.Drawing.Point(130, 539);
            this.trackBarContrast.Maximum = 100;
            this.trackBarContrast.Minimum = -100;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(636, 56);
            this.trackBarContrast.TabIndex = 7;
            this.trackBarContrast.Value = 1;
            this.trackBarContrast.Scroll += new System.EventHandler(this.trackBarContrast_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 467);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Brightness";
            // 
            // txtBrightness
            // 
            this.txtBrightness.Location = new System.Drawing.Point(12, 495);
            this.txtBrightness.Name = "txtBrightness";
            this.txtBrightness.Size = new System.Drawing.Size(100, 22);
            this.txtBrightness.TabIndex = 9;
            this.txtBrightness.Text = "0";
            // 
            // txtContrast
            // 
            this.txtContrast.Location = new System.Drawing.Point(12, 567);
            this.txtContrast.Name = "txtContrast";
            this.txtContrast.Size = new System.Drawing.Size(100, 22);
            this.txtContrast.TabIndex = 11;
            this.txtContrast.Text = "1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 539);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Contrast";
            // 
            // mainAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(778, 618);
            this.Controls.Add(this.txtContrast);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtBrightness);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBarContrast);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.chosenColourLabel);
            this.Controls.Add(this.chosenColourPanel);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MinimumSize = new System.Drawing.Size(368, 166);
            this.Name = "mainAppWindow";
            this.Text = "Photostore";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel chosenColourPanel;
        private System.Windows.Forms.Label chosenColourLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipHorizontallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipVerticallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem rotate90ToTheRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate90ToTheLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cropImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBrightness;
        private System.Windows.Forms.TextBox txtContrast;
        private System.Windows.Forms.TextBox textBox3;
    }
}

