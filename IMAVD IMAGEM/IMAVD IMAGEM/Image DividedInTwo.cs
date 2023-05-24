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
    public partial class Image_DividedInTwo : Form
    {
        public List<Bitmap> dividedImage;

        public Image_DividedInTwo(List<Bitmap> dividedImage)
        {
            InitializeComponent();

            this.dividedImage = dividedImage;

            pboxDiv1.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxDiv2.SizeMode = PictureBoxSizeMode.StretchImage;

            pboxDiv1.Image = dividedImage[0];
            pboxDiv2.Image = dividedImage[1];
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(pboxDiv1.Image.Width);
                int height = Convert.ToInt32(pboxDiv1.Image.Height);
                using (Bitmap bmp = new Bitmap(width, height))
                {
                    //image..DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    pboxDiv1.Image.Save(dialog.FileName + ".jpeg", ImageFormat.Jpeg);
                }
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(pboxDiv2.Image.Width);
                int height = Convert.ToInt32(pboxDiv2.Image.Height);
                using (Bitmap bmp = new Bitmap(width, height))
                {
                    //image..DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    pboxDiv2.Image.Save(dialog.FileName + ".jpeg", ImageFormat.Jpeg);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
