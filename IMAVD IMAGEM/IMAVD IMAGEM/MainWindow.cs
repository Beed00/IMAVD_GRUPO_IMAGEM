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

        bool pickColorEvent = false;
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
                        detectChosenColorInImage(colorDialog.Color);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void detectChosenColorInImage(Color selectedColor)
        {
            try
            {
                Boolean IsColorFound = false;

                if (pbox.Image != null)
                {
                    Bitmap bitmap = new Bitmap(pbox.Image);
                    long colorCounter = 0;

                    for (int i = 0; i < pbox.Image.Height; i++)
                    {
                        for (int j = 0; j < pbox.Image.Width; j++)
                        {
                            Color instanceColor = bitmap.GetPixel(j, i);
                            if (instanceColor.ToArgb() == selectedColor.ToArgb())
                            {
                                IsColorFound = true;
                                colorCounter = colorCounter + 1;
                            }
                        }
                        /*
                        if (IsColorFound == true)
                        {
                            break;
                        }
                        */
                    }
                    if (IsColorFound == true)
                    {
                        MessageBox.Show("Color has been found. Number of pixels of this color in the image is: " + colorCounter + " px");
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
            if (pbox.Image != null)
            {
                pickColorEvent = true;
            }
            else
            {
                MessageBox.Show("Image has not yet been loaded.");
            }
        }

        private void pbox_Click(object sender, EventArgs e)
        {
            if (pickColorEvent)
            {
                MouseEventArgs mouse = e as MouseEventArgs;
                Bitmap b = ((Bitmap)pbox.Image);
                int x = mouse.X * b.Width / pbox.ClientSize.Width;
                int y = mouse.Y * b.Height / pbox.ClientSize.Height;
                Color pickedColor = b.GetPixel(x, y);

                pickColorEvent = false;

                detectChosenColorInImage(pickedColor);
            }
        }

        private void findColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RGBPickerWindow rgbPickerWindow = new RGBPickerWindow(this);
            rgbPickerWindow.Show();
        }

        public void detectChosenRGBInImage(int R, int G, int B)
        {
            Color pickedRGBColor = new Color();
            pickedRGBColor = Color.FromArgb(R, G, B);

            detectChosenColorInImage(pickedRGBColor);
        }

        private void invertColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbox.Image != null)
            {
                Bitmap inverted = new Bitmap(pbox.Image);

                for (int y = 0; (y <= (inverted.Height - 1)); y++)
                {
                    for (int x = 0; (x <= (inverted.Width - 1)); x++)
                    {
                        Color inv = inverted.GetPixel(x, y);
                        inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                        inverted.SetPixel(x, y, inv);
                    }
                }

                pbox.Image = inverted;
            }
        }
    }
}
