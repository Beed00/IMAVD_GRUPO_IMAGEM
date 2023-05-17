using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMAVD_IMAGEM
{
    public partial class mainAppWindow : Form
    {
        // Constants
        const int MAX_STORABLE_IMAGE_HISTORIES = 10;


        // Variables
        Image backup;

        string filePath;

        Color chosenColor;

        bool pickColorEvent = false;
        bool cropImageEventOne = false;
        bool cropImageEventTwo = false;

        int[] firstLimitMousePosition = new int[2];
        int[] secondLimitMousePosition = new int[2];

        // Undo and Redo Stacks
        private LinkedList<ImageHistory> undoStack = new LinkedList<ImageHistory>();
        private LinkedList<ImageHistory> redoStack = new LinkedList<ImageHistory>();

        int currentBrightness;
        int currentContrast;

        public mainAppWindow()
        {
            InitializeComponent();
            currentBrightness = 0;
            currentContrast = 1;
            MouseWheel += MyMouseWheel;

        }

        private void MyMouseWheel(object sender, MouseEventArgs e)
        {
            int mousedeltavalue = e.Delta / 2;

            if (ModifierKeys == Keys.Control)
            {
                double resizeCoeff = (double)(100 + mousedeltavalue / 2) / 100;
                Size newSize = new Size((int)(pbox.Size.Width * resizeCoeff), (int)(pbox.Size.Height * resizeCoeff));
                pbox.Size = newSize;
                pbox.Location = new Point(
                    e.Location.X - (int)(resizeCoeff * (e.Location.X - pbox.Location.X)),
                    e.Location.Y - (int)(resizeCoeff * (e.Location.Y - pbox.Location.Y))
                    );
                return;
            }

            if (ModifierKeys == Keys.Shift)
            {
                pbox.Location = new Point(
                    pbox.Location.X + mousedeltavalue,
                    pbox.Location.Y
                    );
            }
            else
            {
                pbox.Location = new Point(
                    pbox.Location.X,
                    pbox.Location.Y + mousedeltavalue
                    );
            }
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
                backup = Image.FromFile(filePath);

                pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                pbox.Image = backup;
            }
        }

        /*
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        */

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(pbox.Image.Width);
                int height = Convert.ToInt32(pbox.Image.Height);
                using (Bitmap bmp = new Bitmap(width, height))
                {
                    //image..DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    pbox.Image.Save(dialog.FileName + ".jpeg", ImageFormat.Jpeg);
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
                string imageDimension = "" + backup.Width + "x" + backup.Height;
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

                pbox.Image = cropImage(retangulo);
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

            if (firtMouseXY[0] < secondMouseXY[0])
            {
                originX = firtMouseXY[0];

                width = secondMouseXY[0] - firtMouseXY[0];
            }
            else
            {
                originX = secondMouseXY[0];

                width = firtMouseXY[0] - secondMouseXY[0];
            }

            if (firtMouseXY[1] < secondMouseXY[1])
            {
                originY = firtMouseXY[1];

                height = secondMouseXY[1] - firtMouseXY[1];
            }
            else
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
            addImageToHistory();
            Bitmap inverted;

            if (pbox.Image != null)
            {
                inverted = new Bitmap(pbox.Image.Width, pbox.Image.Height);

                ColorMatrix clrMatrix = new ColorMatrix(new float[][]
                {
                new float[] {-1, 0, 0, 0, 0},
                new float[] {0, -1, 0, 0, 0},
                new float[] {0, 0, -1, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {1, 1, 1, 0, 1}
                });

                using (ImageAttributes attrImage = new ImageAttributes())
                {
                    attrImage.SetColorMatrix(clrMatrix);

                    using (Graphics g = Graphics.FromImage(inverted))
                    {
                        g.DrawImage(pbox.Image, new Rectangle(0, 0,
                            pbox.Image.Width, pbox.Image.Height), 0, 0,
                            pbox.Image.Width, pbox.Image.Height, GraphicsUnit.Pixel,
                            attrImage);
                    }
                }

                pbox.Image = inverted;
            }
        }

        private void flipHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbox.Image != null)
            {
                addImageToHistory();
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
                addImageToHistory();
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
                addImageToHistory();
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
                addImageToHistory();
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
                addImageToHistory();
                pbox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                pbox.Refresh();
            }
            else
            {
                MessageBox.Show("Image has not yet been loaded.");
            }
        }

        private Image cropImage(Rectangle cropArea)
        {
            addImageToHistory();
            Bitmap bmpImage = new Bitmap(pbox.Image);
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

        public void addImageToHistory()
        {
            undoStack.AddFirst(new ImageHistory(pbox));
            undoToolStripMenuItem.Enabled = true;
            if (undoStack.Count >= MAX_STORABLE_IMAGE_HISTORIES)
            {
                undoStack.RemoveFirst();
            }
            // Clear the redo stack
            redoToolStripMenuItem.Enabled = false;
            redoStack.Clear();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                // Push the current image onto the redo stack and set the previous image as the new image
                redoStack.AddFirst(new ImageHistory(pbox));
                ImageHistory data = undoStack.First();
                pbox.Image = data.ImageBitmap;
                pbox.Location = data.Location;
                pbox.Size = data.Size;
                pbox.Refresh();
                undoStack.RemoveFirst();
            }
            undoToolStripMenuItem.Enabled = undoStack.Count > 0;
            redoToolStripMenuItem.Enabled = redoStack.Count > 0;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                // Push the current image onto the undo stack and set the next image as the new image
                undoStack.AddFirst(new ImageHistory(pbox));
                ImageHistory data = redoStack.First();
                pbox.Image = data.ImageBitmap;
                pbox.Location = data.Location;
                pbox.Size = data.Size;
                pbox.Refresh();
                redoStack.RemoveFirst();
            }
            undoToolStripMenuItem.Enabled = undoStack.Count > 0;
            redoToolStripMenuItem.Enabled = redoStack.Count > 0;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbox.Image != null)
            {
                Bitmap temp = (Bitmap)backup;

                Bitmap contrast = new Bitmap(temp.Width, temp.Height);

                ColorMatrix clrMatrix = new ColorMatrix(new float[][]
                {
                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 0, 0, 0, 0},
                    new float[] {0, 0, 0, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 1, 1}
                });

                using (ImageAttributes attrImage = new ImageAttributes())
                {
                    attrImage.SetColorMatrix(clrMatrix);

                    using (Graphics g = Graphics.FromImage(contrast))
                    {
                        g.DrawImage(temp, new Rectangle(0, 0,
                            temp.Width, temp.Height), 0, 0,
                            temp.Width, temp.Height, GraphicsUnit.Pixel,
                            attrImage);

                        attrImage.Dispose();
                        g.Dispose();
                    }
                }

                pbox.Image = contrast;
            }
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbox.Image != null)
            {
                Bitmap temp = (Bitmap)backup;

                Bitmap contrast = new Bitmap(temp.Width, temp.Height);

                ColorMatrix clrMatrix = new ColorMatrix(new float[][]
                {
                    new float[] {0, 0, 0, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 0, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 1, 1}
                });

                using (ImageAttributes attrImage = new ImageAttributes())
                {
                    attrImage.SetColorMatrix(clrMatrix);

                    using (Graphics g = Graphics.FromImage(contrast))
                    {
                        g.DrawImage(temp, new Rectangle(0, 0,
                            temp.Width, temp.Height), 0, 0,
                            temp.Width, temp.Height, GraphicsUnit.Pixel,
                            attrImage);

                        attrImage.Dispose();
                        g.Dispose();
                    }
                }

                pbox.Image = contrast;
            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbox.Image != null)
            {
                Bitmap temp = (Bitmap)backup;

                Bitmap contrast = new Bitmap(temp.Width, temp.Height);

                ColorMatrix clrMatrix = new ColorMatrix(new float[][]
                {
                    new float[] {0, 0, 0, 0, 0},
                    new float[] {0, 0, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 1, 1}
                });

                using (ImageAttributes attrImage = new ImageAttributes())
                {
                    attrImage.SetColorMatrix(clrMatrix);

                    using (Graphics g = Graphics.FromImage(contrast))
                    {
                        g.DrawImage(temp, new Rectangle(0, 0,
                            temp.Width, temp.Height), 0, 0,
                            temp.Width, temp.Height, GraphicsUnit.Pixel,
                            attrImage);

                        attrImage.Dispose();
                        g.Dispose();
                    }
                }

                pbox.Image = contrast;
            }
        }

        private void gammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbox.Image != null)
            {
                addImageToHistory();

                Bitmap temp = (Bitmap)pbox.Image;

                GammaWindow gammaWindow = new GammaWindow(this);
                gammaWindow.ShowDialog();

                float redGamma = gammaWindow.redGamma;
                float greenGamma = gammaWindow.greenGamma;
                float blueGamma = gammaWindow.blueGamma;

                for (int i = 0; i < temp.Width; i++)
                {
                    for (int j = 0; j < temp.Height; j++)
                    {
                        Color c = temp.GetPixel(i, j);

                        int newRed = 0;
                        int newGreen = 0;
                        int newBlue = 0;

                        if (redGamma < 0)
                        {
                            newRed = c.R;
                        }
                        else
                        {
                            newRed = (int)Math.Pow(c.R, 1 / redGamma);
                        }

                        if (greenGamma < 0)
                        {
                            newGreen = c.G;
                        }
                        else
                        {
                            newGreen = (int)Math.Pow(c.G, 1 / greenGamma);
                        }

                        if (blueGamma < 0)
                        {
                            newBlue = c.B;
                        }
                        else
                        {
                            newBlue = (int)Math.Pow(c.B, 1 / blueGamma);
                        }

                        Color newColor = Color.FromArgb(newRed, newGreen, newBlue);

                        temp.SetPixel(i, j, newColor);

                    }
                }

                pbox.Image = temp;
            }
        }

        private void brightnessContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbox.Image != null)
            {
                addImageToHistory();

                BrightnessContrastWindow brightnessContrastWindow = new BrightnessContrastWindow(this, currentBrightness, currentContrast);
                brightnessContrastWindow.ShowDialog();

                currentBrightness = brightnessContrastWindow.chosenBrightness;
                currentContrast = brightnessContrastWindow.chosenContrast;

                float chosenContrast = 1 + (currentContrast * 0.01f);
                float chosenBrightness = (float)(currentBrightness / 255.0);

                Bitmap temp = (Bitmap)pbox.Image;

                Bitmap contrast = new Bitmap(temp.Width, temp.Height);

                ColorMatrix clrMatrix = new ColorMatrix(new float[][]
                {
                    new float[] {chosenContrast, 0, 0, 0, 0},
                    new float[] {0, chosenContrast, 0, 0, 0},
                    new float[] {0, 0, chosenContrast, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {chosenBrightness, chosenBrightness, chosenBrightness, 0, 1}
                });

                using (ImageAttributes attrImage = new ImageAttributes())
                {
                    attrImage.SetColorMatrix(clrMatrix);

                    using (Graphics g = Graphics.FromImage(contrast))
                    {
                        g.DrawImage(temp, new Rectangle(0, 0,
                            temp.Width, temp.Height), 0, 0,
                            temp.Width, temp.Height, GraphicsUnit.Pixel,
                            attrImage);

                        attrImage.Dispose();
                        g.Dispose();
                    }
                }

                pbox.Image = contrast;

            }
        }

        private void addTextToImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbox.Image != null)
            {
                addImageToHistory();

                Bitmap temp = (Bitmap)pbox.Image;

                TextForImageWindow textWindow = new TextForImageWindow(this);
                textWindow.ShowDialog();

                string textForImage = textWindow.textToAdd;

                Console.WriteLine("TEXTO: " + textForImage);

                if (!string.IsNullOrEmpty(textForImage))
                {
                    RectangleF rectf = new RectangleF(temp.Width / 2, temp.Height / 2, temp.Width / 2, temp.Height / 2); //rectf for My Text

                    using (Graphics g = Graphics.FromImage(temp))
                    {
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        StringFormat sf = new StringFormat();
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;
                        g.DrawString(textForImage, new System.Drawing.Font("Arial", 20, FontStyle.Regular), Brushes.Black, rectf, sf);
                        g.Dispose();
                    }

                    pbox.Image = temp;
                }

            }
        }

        private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbox.Image != null)
            {
                addImageToHistory();

                Bitmap temp = (Bitmap)pbox.Image;

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

                filePath = openFileDialog.FileName.Trim();
                if (filePath != null)
                {
                    Image imageToAdd = Image.FromFile(filePath);

                    Graphics g = Graphics.FromImage(temp);
                    g.DrawImage(imageToAdd, temp.Width / 2, 10);

                    pbox.Image = temp;
                }

            }
        }

        private void redimensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbox.Image != null)
            {
                addImageToHistory();

                Bitmap temp = (Bitmap)pbox.Image;

                ResizeWindow resizeWindow = new ResizeWindow(this, pbox.Image.Width, pbox.Image.Height);
                resizeWindow.ShowDialog();

                if (resizeWindow.byPercentage)
                {
                    //new Size((int)(pbox.Size.Width * resizeCoeff), (int)(pbox.Size.Height * resizeCoeff));

                    pbox.Image = new Bitmap(
                        pbox.Image,
                        new Size(
                            (pbox.Image.Width * resizeWindow.resizePercentageValue) / 100,
                            (pbox.Image.Height * resizeWindow.resizePercentageValue) / 100
                            )
                        );
                    pbox.Size = new Size(
                            (pbox.Size.Width * resizeWindow.resizePercentageValue) / 100,
                            (pbox.Size.Height * resizeWindow.resizePercentageValue) / 100
                            );
                }
                else if (resizeWindow.byAbsolute)
                {
                    Console.WriteLine("Widths:");
                    Console.WriteLine(pbox.Image.Width);
                    Console.WriteLine(pbox.Size.Width);

                    Console.WriteLine("Heights:");
                    Console.WriteLine(pbox.Image.Height);
                    Console.WriteLine(pbox.Size.Height);
                    pbox.Image = new Bitmap(pbox.Image, new Size(resizeWindow.resizeWidthValue, resizeWindow.resizeHeightValue));
                    Size newSize = new Size(resizeWindow.resizeWidthValue, resizeWindow.resizeHeightValue);
                    pbox.Size = newSize;
                }


                /*
                string textForImage = textWindow.textToAdd;

                Console.WriteLine("TEXTO: " + textForImage);

                if (!string.IsNullOrEmpty(textForImage))
                {
                    RectangleF rectf = new RectangleF(temp.Width / 2, temp.Height / 2, temp.Width / 2, temp.Height / 2); //rectf for My Text

                    using (Graphics g = Graphics.FromImage(temp))
                    {
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        StringFormat sf = new StringFormat();
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;
                        g.DrawString(textForImage, new System.Drawing.Font("Arial", 20, FontStyle.Regular), Brushes.Black, rectf, sf);
                        g.Dispose();
                    }

                    pbox.Image = temp;
                }*/

            }
        }
    }

    public class ImageHistory
    {
        public Bitmap ImageBitmap { get; set; }
        public Point Location { get; set; }
        public Size Size { get; set; }

        public ImageHistory(PictureBox pbox)
        {
            ImageBitmap = new Bitmap(pbox.Image);
            Location = pbox.Location;
            Size = pbox.Size;
        }
    }
}
