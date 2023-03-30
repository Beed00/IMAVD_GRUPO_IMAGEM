namespace IMAVD_IMAGEM
{
    partial class RGBPickerWindow
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
            this.okButton = new System.Windows.Forms.Button();
            this.RTextBox = new System.Windows.Forms.TextBox();
            this.GTextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.RLabel = new System.Windows.Forms.Label();
            this.GLabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(104, 90);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // RTextBox
            // 
            this.RTextBox.Location = new System.Drawing.Point(42, 44);
            this.RTextBox.Name = "RTextBox";
            this.RTextBox.Size = new System.Drawing.Size(39, 22);
            this.RTextBox.TabIndex = 1;
            this.RTextBox.TextChanged += new System.EventHandler(this.RTextBox_TextChanged);
            // 
            // GTextBox
            // 
            this.GTextBox.Location = new System.Drawing.Point(122, 44);
            this.GTextBox.Name = "GTextBox";
            this.GTextBox.Size = new System.Drawing.Size(42, 22);
            this.GTextBox.TabIndex = 2;
            this.GTextBox.TextChanged += new System.EventHandler(this.GTextBox_TextChanged);
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(203, 44);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(42, 22);
            this.BTextBox.TabIndex = 3;
            this.BTextBox.TextChanged += new System.EventHandler(this.BTextBox_TextChanged);
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLabel.ForeColor = System.Drawing.Color.Red;
            this.RLabel.Location = new System.Drawing.Point(42, 22);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(18, 16);
            this.RLabel.TabIndex = 4;
            this.RLabel.Text = "R";
            this.RLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // GLabel
            // 
            this.GLabel.AutoSize = true;
            this.GLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GLabel.ForeColor = System.Drawing.Color.Green;
            this.GLabel.Location = new System.Drawing.Point(119, 22);
            this.GLabel.Name = "GLabel";
            this.GLabel.Size = new System.Drawing.Size(18, 16);
            this.GLabel.TabIndex = 5;
            this.GLabel.Text = "G";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLabel.ForeColor = System.Drawing.Color.Blue;
            this.BLabel.Location = new System.Drawing.Point(200, 22);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(17, 16);
            this.BLabel.TabIndex = 6;
            this.BLabel.Text = "B";
            // 
            // RGBPickerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 125);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.GLabel);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.GTextBox);
            this.Controls.Add(this.RTextBox);
            this.Controls.Add(this.okButton);
            this.Name = "RGBPickerWindow";
            this.Text = "RBG Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox RTextBox;
        private System.Windows.Forms.TextBox GTextBox;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Label GLabel;
        private System.Windows.Forms.Label BLabel;
    }
}