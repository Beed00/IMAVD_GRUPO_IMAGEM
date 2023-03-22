﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMAVD_IMAGEM
{
    public partial class mainAppWindow : Form
    {
        Image image;


        Color chosenColor;
        public mainAppWindow()
        {
            InitializeComponent();
            
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog(); // Shows the dialog.
            if (result == DialogResult.OK) // Tests result.
            {
                string file = openFileDialog.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }

            Console.WriteLine("FileSize: " + size);
            Console.WriteLine("Result: " + result);
            Console.WriteLine("FilePath: " + openFileDialog.FileName);

            //"C:/Users/emonteiro/OneDrive - Hitachi Solutions/Desktop/Mestrado ISEP/1ano/2semestre/COSIG/Test_Scene_1.txt";
            string filePath = openFileDialog.FileName;

            image = Image.FromFile(filePath);

            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox.Image = image;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(image.Width);
                int height = Convert.ToInt32(image.Height);
                using (Bitmap bmp = new Bitmap(width, height))
                {
                    //image..DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    image.Save(dialog.FileName + ".jpeg", ImageFormat.Jpeg);
                }
            }
        }

        private void imageInformationButton_Click(object sender, EventArgs e)
        {
            ImageInformationWindow informationWindow = new ImageInformationWindow();
            informationWindow.Show();
        }

        private void searchColourButton_Click(object sender, EventArgs e)
        {
                try
                {
                    chosenColourLabel.Text = "";
                    chosenColourPanel.BackColor = chosenColor;

                    DialogResult IsColorChosen = colorDialog.ShowDialog();

                    if (IsColorChosen == System.Windows.Forms.DialogResult.OK)
                    {
                        chosenColourPanel.BackColor = colorDialog.Color;
                        if (colorDialog.Color.IsKnownColor == true)
                        {
                            chosenColourLabel.Text = colorDialog.Color.ToKnownColor().ToString();
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

        private void chosenColourPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chosenColourLabel_Click(object sender, EventArgs e)
        {

        }
    }
    }
