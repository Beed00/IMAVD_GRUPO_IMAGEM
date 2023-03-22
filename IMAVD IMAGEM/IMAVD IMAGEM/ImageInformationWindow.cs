using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMAVD_IMAGEM
{
    public partial class ImageInformationWindow : Form
    {
        public ImageInformationWindow(string imageName, string imageExtension, string imageLocation,
                string imageDimension, string imageSize, string imageCreation)
        {
            InitializeComponent();

            this.imageNameField.Text = imageName;
            this.imageExtensionField.Text = imageExtension;
            this.imageLocationField.Text = imageLocation;
            this.imageDimensionField.Text = imageDimension;
            this.imageSizeField.Text = imageSize;
            this.imageCreatedOnField.Text = imageCreation;

        }

        private void imageNameField_Click(object sender, EventArgs e)
        {

        }

        private void ImageInformationWindow_Load(object sender, EventArgs e)
        {

        }

        private void imageExtensionField_Click(object sender, EventArgs e)
        {

        }

        private void imageLocationField_Click(object sender, EventArgs e)
        {

        }

        private void imageDimensionField_Click(object sender, EventArgs e)
        {

        }

        private void imageSizeField_Click(object sender, EventArgs e)
        {

        }

        private void imageCreatedOnField_Click(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
