namespace IMAVD_IMAGEM
{
    partial class ResizeWindow
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
            this.resizeByPercentage = new System.Windows.Forms.RadioButton();
            this.resizeByAbsoluteValue = new System.Windows.Forms.RadioButton();
            this.resizePercentage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resizeWidthNumber = new System.Windows.Forms.NumericUpDown();
            this.resizeHeightNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resizePercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeWidthNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeHeightNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // resizeByPercentage
            // 
            this.resizeByPercentage.AutoSize = true;
            this.resizeByPercentage.Location = new System.Drawing.Point(107, 73);
            this.resizeByPercentage.Name = "resizeByPercentage";
            this.resizeByPercentage.Size = new System.Drawing.Size(242, 36);
            this.resizeByPercentage.TabIndex = 0;
            this.resizeByPercentage.TabStop = true;
            this.resizeByPercentage.Text = "By percentage:";
            this.resizeByPercentage.UseVisualStyleBackColor = true;
            // 
            // resizeByAbsoluteValue
            // 
            this.resizeByAbsoluteValue.AutoSize = true;
            this.resizeByAbsoluteValue.Location = new System.Drawing.Point(107, 155);
            this.resizeByAbsoluteValue.Name = "resizeByAbsoluteValue";
            this.resizeByAbsoluteValue.Size = new System.Drawing.Size(276, 36);
            this.resizeByAbsoluteValue.TabIndex = 1;
            this.resizeByAbsoluteValue.TabStop = true;
            this.resizeByAbsoluteValue.Text = "By absolute value";
            this.resizeByAbsoluteValue.UseVisualStyleBackColor = true;
            // 
            // resizePercentage
            // 
            this.resizePercentage.Location = new System.Drawing.Point(390, 73);
            this.resizePercentage.Name = "resizePercentage";
            this.resizePercentage.Size = new System.Drawing.Size(120, 38);
            this.resizePercentage.TabIndex = 2;
            this.resizePercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Height:";
            // 
            // resizeWidthNumber
            // 
            this.resizeWidthNumber.Location = new System.Drawing.Point(390, 234);
            this.resizeWidthNumber.Name = "resizeWidthNumber";
            this.resizeWidthNumber.Size = new System.Drawing.Size(120, 38);
            this.resizeWidthNumber.TabIndex = 6;
            this.resizeWidthNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resizeHeightNumber
            // 
            this.resizeHeightNumber.Location = new System.Drawing.Point(390, 292);
            this.resizeHeightNumber.Name = "resizeHeightNumber";
            this.resizeHeightNumber.Size = new System.Drawing.Size(120, 38);
            this.resizeHeightNumber.TabIndex = 7;
            this.resizeHeightNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "px";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "px";
            // 
            // ResizeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 408);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resizeHeightNumber);
            this.Controls.Add(this.resizeWidthNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resizePercentage);
            this.Controls.Add(this.resizeByAbsoluteValue);
            this.Controls.Add(this.resizeByPercentage);
            this.Name = "ResizeWindow";
            this.Text = "ResizeWindow";
            ((System.ComponentModel.ISupportInitialize)(this.resizePercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeWidthNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeHeightNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton resizeByPercentage;
        private System.Windows.Forms.RadioButton resizeByAbsoluteValue;
        private System.Windows.Forms.NumericUpDown resizePercentage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown resizeWidthNumber;
        private System.Windows.Forms.NumericUpDown resizeHeightNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}