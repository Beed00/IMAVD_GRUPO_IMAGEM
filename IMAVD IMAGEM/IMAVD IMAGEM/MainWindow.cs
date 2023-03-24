using System;
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

        string filePath;

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
            filePath = openFileDialog.FileName;

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

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbox.Image != null)
            {
                FileInfo info = new FileInfo(filePath);
                string imageName = info.Name;
                string imageExtension = info.Extension;
                string imageLocation = filePath;
                string imageDimension = "" + image.Width + "x" + image.Height;
                string imageSize = info.Length + " bytes";
                string imageCreation = info.CreationTime.ToString();

                ImageInformationWindow informationWindow = new ImageInformationWindow(imageName, imageExtension, imageLocation,
                    imageDimension, imageSize, imageCreation);
                informationWindow.Show();
            }
            else
            {
                MessageBox.Show("Image has not yet been loaded. No information to show.");
            }
        }

        private void chosenColourPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chosenColourLabel_Click(object sender, EventArgs e)
        {

        }

        private void chooseColorToolStripMenuItem_Click(object sender, EventArgs e)
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
                        detectChosenColorInImage();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void detectChosenColorInImage()
        {
            try
            {
                Boolean IsColorFound = false;

                if (pbox.Image != null)
                {
                    Bitmap bitmap = new Bitmap(pbox.Image);

                    for (int i = 0; i < pbox.Image.Height; i++)
                    {
                        for (int j = 0; j < pbox.Image.Width; j++)
                        {
                            Color instanceColor = bitmap.GetPixel(j, i);
                            if (instanceColor.ToArgb() == colorDialog.Color.ToArgb())
                            {
                                IsColorFound = true;
                                MessageBox.Show("Color has been found.");
                                break;
                            }
                        }
                        if (IsColorFound == true)
                        {
                            break;
                        }
                    }

                    if (IsColorFound == false)
                    {
                        MessageBox.Show("Chosen color was not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Image has not yet been loaded.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void pickColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
