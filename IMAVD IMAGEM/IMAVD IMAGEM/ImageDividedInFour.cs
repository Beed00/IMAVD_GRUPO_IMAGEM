using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMAVD_IMAGEM
{
    public partial class ImageDividedInFour : Form
    {
        public List<Bitmap> dividedImage;

        public ImageDividedInFour(List<Bitmap> dividedImage)
        {
            InitializeComponent();

            this.dividedImage = dividedImage;

            pboxD1.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxD2.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxD3.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxD4.SizeMode = PictureBoxSizeMode.StretchImage;

            pboxD1.Image = dividedImage[0];
            pboxD2.Image = dividedImage[1];
            pboxD3.Image = dividedImage[2];
            pboxD4.Image = dividedImage[3];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(pboxD1.Image.Width);
                int height = Convert.ToInt32(pboxD1.Image.Height);
                using (Bitmap bmp = new Bitmap(width, height))
                {
                    //image..DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    pboxD1.Image.Save(dialog.FileName + ".jpeg", ImageFormat.Jpeg);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(pboxD2.Image.Width);
                int height = Convert.ToInt32(pboxD2.Image.Height);
                using (Bitmap bmp = new Bitmap(width, height))
                {
                    //image..DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    pboxD2.Image.Save(dialog.FileName + ".jpeg", ImageFormat.Jpeg);
                }
            }
        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(pboxD3.Image.Width);
                int height = Convert.ToInt32(pboxD3.Image.Height);
                using (Bitmap bmp = new Bitmap(width, height))
                {
                    //image..DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    pboxD3.Image.Save(dialog.FileName + ".jpeg", ImageFormat.Jpeg);
                }
            }
        }

        private void btnSave4_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(pboxD4.Image.Width);
                int height = Convert.ToInt32(pboxD4.Image.Height);
                using (Bitmap bmp = new Bitmap(width, height))
                {
                    //image..DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    pboxD4.Image.Save(dialog.FileName + ".jpeg", ImageFormat.Jpeg);
                }
            }
        }
    }
}
