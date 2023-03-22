namespace IMAVD_IMAGEM
{
    partial class ImageInformationWindow
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
            this.imageNameLabel = new System.Windows.Forms.Label();
            this.imageExtensionLabel = new System.Windows.Forms.Label();
            this.imageLocationLabel = new System.Windows.Forms.Label();
            this.imageDimensionLabel = new System.Windows.Forms.Label();
            this.imageSizeLabel = new System.Windows.Forms.Label();
            this.imageCreatedOnLabel = new System.Windows.Forms.Label();
            this.imageNameField = new System.Windows.Forms.Label();
            this.imageExtensionField = new System.Windows.Forms.Label();
            this.imageLocationField = new System.Windows.Forms.Label();
            this.imageDimensionField = new System.Windows.Forms.Label();
            this.imageSizeField = new System.Windows.Forms.Label();
            this.imageCreatedOnField = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageNameLabel
            // 
            this.imageNameLabel.AutoSize = true;
            this.imageNameLabel.Location = new System.Drawing.Point(40, 29);
            this.imageNameLabel.Name = "imageNameLabel";
            this.imageNameLabel.Size = new System.Drawing.Size(88, 16);
            this.imageNameLabel.TabIndex = 0;
            this.imageNameLabel.Text = "Image Name:";
            // 
            // imageExtensionLabel
            // 
            this.imageExtensionLabel.AutoSize = true;
            this.imageExtensionLabel.Location = new System.Drawing.Point(40, 73);
            this.imageExtensionLabel.Name = "imageExtensionLabel";
            this.imageExtensionLabel.Size = new System.Drawing.Size(109, 16);
            this.imageExtensionLabel.TabIndex = 1;
            this.imageExtensionLabel.Text = "Image Extension:";
            // 
            // imageLocationLabel
            // 
            this.imageLocationLabel.AutoSize = true;
            this.imageLocationLabel.Location = new System.Drawing.Point(40, 116);
            this.imageLocationLabel.Name = "imageLocationLabel";
            this.imageLocationLabel.Size = new System.Drawing.Size(102, 16);
            this.imageLocationLabel.TabIndex = 2;
            this.imageLocationLabel.Text = "Image Location:";
            // 
            // imageDimensionLabel
            // 
            this.imageDimensionLabel.AutoSize = true;
            this.imageDimensionLabel.Location = new System.Drawing.Point(40, 158);
            this.imageDimensionLabel.Name = "imageDimensionLabel";
            this.imageDimensionLabel.Size = new System.Drawing.Size(115, 16);
            this.imageDimensionLabel.TabIndex = 3;
            this.imageDimensionLabel.Text = "Image Dimension:";
            // 
            // imageSizeLabel
            // 
            this.imageSizeLabel.AutoSize = true;
            this.imageSizeLabel.Location = new System.Drawing.Point(40, 202);
            this.imageSizeLabel.Name = "imageSizeLabel";
            this.imageSizeLabel.Size = new System.Drawing.Size(77, 16);
            this.imageSizeLabel.TabIndex = 4;
            this.imageSizeLabel.Text = "Image Size:";
            // 
            // imageCreatedOnLabel
            // 
            this.imageCreatedOnLabel.AutoSize = true;
            this.imageCreatedOnLabel.Location = new System.Drawing.Point(40, 246);
            this.imageCreatedOnLabel.Name = "imageCreatedOnLabel";
            this.imageCreatedOnLabel.Size = new System.Drawing.Size(119, 16);
            this.imageCreatedOnLabel.TabIndex = 5;
            this.imageCreatedOnLabel.Text = "Image Created On:";
            // 
            // imageNameField
            // 
            this.imageNameField.AutoSize = true;
            this.imageNameField.Location = new System.Drawing.Point(201, 29);
            this.imageNameField.Name = "imageNameField";
            this.imageNameField.Size = new System.Drawing.Size(60, 16);
            this.imageNameField.TabIndex = 6;
            this.imageNameField.Text = "Example";
            this.imageNameField.Click += new System.EventHandler(this.imageNameField_Click);
            // 
            // imageExtensionField
            // 
            this.imageExtensionField.AutoSize = true;
            this.imageExtensionField.Location = new System.Drawing.Point(201, 73);
            this.imageExtensionField.Name = "imageExtensionField";
            this.imageExtensionField.Size = new System.Drawing.Size(62, 16);
            this.imageExtensionField.TabIndex = 7;
            this.imageExtensionField.Text = ".example";
            this.imageExtensionField.Click += new System.EventHandler(this.imageExtensionField_Click);
            // 
            // imageLocationField
            // 
            this.imageLocationField.AutoSize = true;
            this.imageLocationField.Location = new System.Drawing.Point(201, 116);
            this.imageLocationField.Name = "imageLocationField";
            this.imageLocationField.Size = new System.Drawing.Size(76, 16);
            this.imageLocationField.TabIndex = 8;
            this.imageLocationField.Text = "C:\\Example";
            this.imageLocationField.Click += new System.EventHandler(this.imageLocationField_Click);
            // 
            // imageDimensionField
            // 
            this.imageDimensionField.AutoSize = true;
            this.imageDimensionField.Location = new System.Drawing.Point(201, 158);
            this.imageDimensionField.Name = "imageDimensionField";
            this.imageDimensionField.Size = new System.Drawing.Size(75, 16);
            this.imageDimensionField.TabIndex = 9;
            this.imageDimensionField.Text = "1000 x 2000";
            this.imageDimensionField.Click += new System.EventHandler(this.imageDimensionField_Click);
            // 
            // imageSizeField
            // 
            this.imageSizeField.AutoSize = true;
            this.imageSizeField.Location = new System.Drawing.Point(201, 202);
            this.imageSizeField.Name = "imageSizeField";
            this.imageSizeField.Size = new System.Drawing.Size(65, 16);
            this.imageSizeField.TabIndex = 10;
            this.imageSizeField.Text = "123,45 KB";
            this.imageSizeField.Click += new System.EventHandler(this.imageSizeField_Click);
            // 
            // imageCreatedOnField
            // 
            this.imageCreatedOnField.AutoSize = true;
            this.imageCreatedOnField.Location = new System.Drawing.Point(201, 246);
            this.imageCreatedOnField.Name = "imageCreatedOnField";
            this.imageCreatedOnField.Size = new System.Drawing.Size(167, 16);
            this.imageCreatedOnField.TabIndex = 11;
            this.imageCreatedOnField.Text = "quarta-feira Março 22, 2023";
            this.imageCreatedOnField.Click += new System.EventHandler(this.imageCreatedOnField_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(168, 296);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(93, 27);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ImageInformationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(414, 353);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.imageCreatedOnField);
            this.Controls.Add(this.imageSizeField);
            this.Controls.Add(this.imageDimensionField);
            this.Controls.Add(this.imageLocationField);
            this.Controls.Add(this.imageExtensionField);
            this.Controls.Add(this.imageNameField);
            this.Controls.Add(this.imageCreatedOnLabel);
            this.Controls.Add(this.imageSizeLabel);
            this.Controls.Add(this.imageDimensionLabel);
            this.Controls.Add(this.imageLocationLabel);
            this.Controls.Add(this.imageExtensionLabel);
            this.Controls.Add(this.imageNameLabel);
            this.Name = "ImageInformationWindow";
            this.Text = "Image Information";
            this.Load += new System.EventHandler(this.ImageInformationWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imageNameLabel;
        private System.Windows.Forms.Label imageExtensionLabel;
        private System.Windows.Forms.Label imageLocationLabel;
        private System.Windows.Forms.Label imageDimensionLabel;
        private System.Windows.Forms.Label imageSizeLabel;
        private System.Windows.Forms.Label imageCreatedOnLabel;
        private System.Windows.Forms.Label imageNameField;
        private System.Windows.Forms.Label imageExtensionField;
        private System.Windows.Forms.Label imageLocationField;
        private System.Windows.Forms.Label imageDimensionField;
        private System.Windows.Forms.Label imageSizeField;
        private System.Windows.Forms.Label imageCreatedOnField;
        private System.Windows.Forms.Button okButton;
    }
}