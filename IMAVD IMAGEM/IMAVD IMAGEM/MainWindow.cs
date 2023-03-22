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

        public mainAppWindow()
        {
            InitializeComponent();
        }

        private void loadImageButton_Click(object sender, EventArgs e)
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

            Image image = Image.FromFile(filePath);

            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox.Image = image;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imageInformationButton_Click(object sender, EventArgs e)
        {
            ImageInformationWindow informationWindow = new ImageInformationWindow();
            informationWindow.Show();
        }
    }
}
