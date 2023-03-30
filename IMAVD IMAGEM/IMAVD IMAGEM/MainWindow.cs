using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Policy;
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
        bool cropImageEventOne = false;
        bool cropImageEventTwo = false;

        int[] firstLimitMousePosition = new int[2];
        int[] secondLimitMousePosition = new int[2];
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
            filePath = openFileDialog.FileName.Trim();
            if (filePath != null)
            {
                Console.WriteLine("FilePath: " + filePath);
                image = Image.FromFile(filePath);

                pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                pbox.Image = image;
            }
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

        private void pbox_ClickAsync(object sender, EventArgs e)
        {

            if (cropImageEventTwo)
            {
                // Message to register bottom right limit

                secondLimitMousePosition = mousePosition(e);

                cropImageEventTwo = false;

                Rectangle retangulo = createRectangle(firstLimitMousePosition, secondLimitMousePosition);

                pbox.Image = cropImage(pbox.Image, retangulo);
            }

            if (cropImageEventOne)
            {
                // Message to  register top left limit

                firstLimitMousePosition = mousePosition(e);

                cropImageEventOne = false;
                cropImageEventTwo = true;
            }

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

        private int[] mousePosition(EventArgs e)
        {
            int[] mousePositions = new int[2];
            mousePositions[0] = -1;

            MouseEventArgs limitOneMouse = e as MouseEventArgs;
            Bitmap b = ((Bitmap)pbox.Image);
            int x = limitOneMouse.X * b.Width / pbox.ClientSize.Width;
            int y = limitOneMouse.Y * b.Height / pbox.ClientSize.Height;

            mousePositions[0] = x;
            mousePositions[1] = y;

            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);

            if (mousePositions[0] != -1)
            {
                return mousePositions;
            }
            return null;
        }

        private Rectangle createRectangle(int[] firtMouseXY, int[] secondMouseXY)
        {
            int originX = 0;
            int originY = 0;
            int width = 0;
            int height = 0;

            if(firtMouseXY[0] < secondMouseXY[0])
            {
                originX = firtMouseXY[0];

                width = secondMouseXY[0] - firtMouseXY[0];
            } else
            {
                originX = secondMouseXY[0];

                width = firtMouseXY[0] - secondMouseXY[0];
            }

            if(firtMouseXY[1] < secondMouseXY[1])
            {
                originY = firtMouseXY[1];

                height = secondMouseXY[1] - firtMouseXY[1];
            } else
            {
                originY = secondMouseXY[1];

                height = firtMouseXY[1] - secondMouseXY[1];
            }
            
            return new Rectangle(originX, originY, width, height);
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

        private void flipHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbox.Image != null)
            {
                pbox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pbox.Refresh();
            }
            else
            {
                MessageBox.Show("Image has not yet been loaded.");
            }
        }

        private void flipVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbox.Image != null)
            {
                pbox.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pbox.Refresh();
            }
            else
            {
                MessageBox.Show("Image has not yet been loaded.");
            }
        }

        private void rotate90ToTheRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbox.Image != null)
            {
                pbox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pbox.Location = new Point(
                    pbox.Location.X + (pbox.Width / 2) - (pbox.Height / 2),
                    pbox.Location.Y + (pbox.Height / 2) - (pbox.Width / 2)
                    );
                pbox.Size = new Size(pbox.Height, pbox.Width);
                pbox.Refresh();
            }
            else
            {
                MessageBox.Show("Image has not yet been loaded.");
            }
        }

        private void rotate90ToTheLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbox.Image != null)
            {
                pbox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pbox.Location = new Point(
                    pbox.Location.X + (pbox.Width / 2) - (pbox.Height / 2),
                    pbox.Location.Y + (pbox.Height / 2) - (pbox.Width / 2)
                    );
                pbox.Size = new Size(pbox.Height, pbox.Width);
                pbox.Refresh();
            }
            else
            {
                MessageBox.Show("Image has not yet been loaded.");
            }
        }

        private void rotate180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbox.Image != null)
            {

                pbox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                pbox.Refresh();
            }
            else
            {
                MessageBox.Show("Image has not yet been loaded.");
            }
        }

        private static Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea,
            bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }

        private void cropImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbox.Image != null)
            {
                cropImageEventOne = true;
            }
            else
            {
                MessageBox.Show("Image has not yet been loaded.");
            }
        }
    }
}
