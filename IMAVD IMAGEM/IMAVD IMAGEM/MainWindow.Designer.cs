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
            this.loadImageButton = new System.Windows.Forms.Button();
            this.imageInformationButton = new System.Windows.Forms.Button();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.searchColourButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.chosenColourPanel = new System.Windows.Forms.Panel();
            this.chosenColourLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(669, 379);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(73, 379);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(75, 23);
            this.loadImageButton.TabIndex = 1;
            this.loadImageButton.Text = "Load Image";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // imageInformationButton
            // 
            this.imageInformationButton.Location = new System.Drawing.Point(71, 112);
            this.imageInformationButton.Name = "imageInformationButton";
            this.imageInformationButton.Size = new System.Drawing.Size(84, 40);
            this.imageInformationButton.TabIndex = 2;
            this.imageInformationButton.Text = "Image Information";
            this.imageInformationButton.UseVisualStyleBackColor = true;
            this.imageInformationButton.Click += new System.EventHandler(this.imageInformationButton_Click);
            // 
            // pbox
            // 
            this.pbox.Location = new System.Drawing.Point(41, 27);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(401, 295);
            this.pbox.TabIndex = 2;
            this.pbox.TabStop = false;
            // 
            // searchColourButton
            // 
            this.searchColourButton.Location = new System.Drawing.Point(622, 101);
            this.searchColourButton.Name = "searchColourButton";
            this.searchColourButton.Size = new System.Drawing.Size(146, 63);
            this.searchColourButton.TabIndex = 3;
            this.searchColourButton.Text = "Search Colour";
            this.searchColourButton.UseVisualStyleBackColor = true;
            this.searchColourButton.Click += new System.EventHandler(this.searchColourButton_Click);
            // 
            // chosenColourPanel
            // 
            this.chosenColourPanel.Location = new System.Drawing.Point(622, 202);
            this.chosenColourPanel.Name = "chosenColourPanel";
            this.chosenColourPanel.Size = new System.Drawing.Size(146, 19);
            this.chosenColourPanel.TabIndex = 4;
            this.chosenColourPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.chosenColourPanel_Paint);
            // 
            // chosenColourLabel
            // 
            this.chosenColourLabel.AutoSize = true;
            this.chosenColourLabel.Location = new System.Drawing.Point(628, 183);
            this.chosenColourLabel.Name = "chosenColourLabel";
            this.chosenColourLabel.Size = new System.Drawing.Size(132, 16);
            this.chosenColourLabel.TabIndex = 5;
            this.chosenColourLabel.Text = "Chosen Colour Label";
            this.chosenColourLabel.Click += new System.EventHandler(this.chosenColourLabel_Click);
            // 
            // mainAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chosenColourLabel);
            this.Controls.Add(this.chosenColourPanel);
            this.Controls.Add(this.searchColourButton);
            this.Controls.Add(this.imageInformationButton);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.loadImageButton);
            this.Controls.Add(this.exitButton);
            this.Name = "mainAppWindow";
            this.Text = "IMAVD IMAGEM";
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.Button imageInformationButton;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.Button searchColourButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel chosenColourPanel;
        private System.Windows.Forms.Label chosenColourLabel;
    }
}

