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
            // mainAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageInformationButton);
            this.Controls.Add(this.loadImageButton);
            this.Controls.Add(this.exitButton);
            this.Name = "mainAppWindow";
            this.Text = "Photostore";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.Button imageInformationButton;
    }
}

