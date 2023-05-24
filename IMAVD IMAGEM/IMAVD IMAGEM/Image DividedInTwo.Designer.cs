namespace IMAVD_IMAGEM
{
    partial class Image_DividedInTwo
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
            this.pboxDiv1 = new System.Windows.Forms.PictureBox();
            this.pboxDiv2 = new System.Windows.Forms.PictureBox();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDiv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDiv2)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxDiv1
            // 
            this.pboxDiv1.Location = new System.Drawing.Point(12, 31);
            this.pboxDiv1.Name = "pboxDiv1";
            this.pboxDiv1.Size = new System.Drawing.Size(776, 195);
            this.pboxDiv1.TabIndex = 0;
            this.pboxDiv1.TabStop = false;
            // 
            // pboxDiv2
            // 
            this.pboxDiv2.Location = new System.Drawing.Point(12, 243);
            this.pboxDiv2.Name = "pboxDiv2";
            this.pboxDiv2.Size = new System.Drawing.Size(776, 195);
            this.pboxDiv2.TabIndex = 1;
            this.pboxDiv2.TabStop = false;
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(330, 457);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(127, 23);
            this.btnSave1.TabIndex = 2;
            this.btnSave1.Text = "Save Image 1";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(330, 486);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(127, 23);
            this.btnSave2.TabIndex = 3;
            this.btnSave2.Text = "Save Image 2";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(330, 515);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Image_DividedInTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.btnSave1);
            this.Controls.Add(this.pboxDiv2);
            this.Controls.Add(this.pboxDiv1);
            this.Name = "Image_DividedInTwo";
            this.Text = "Image_DividedInTwo";
            ((System.ComponentModel.ISupportInitialize)(this.pboxDiv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDiv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxDiv1;
        private System.Windows.Forms.PictureBox pboxDiv2;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button btnExit;
    }
}