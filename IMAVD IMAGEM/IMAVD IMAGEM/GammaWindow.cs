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
using static System.Net.Mime.MediaTypeNames;

namespace IMAVD_IMAGEM
{
    public partial class GammaWindow : Form
    {
        mainAppWindow context;
        public float redGamma;
        public float greenGamma;
        public float blueGamma;

        public GammaWindow(mainAppWindow main)
        {
            InitializeComponent();
            this.redGamma = -1;
            this.greenGamma = -1;
            this.blueGamma = -1;
            this.context = main;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtRedValue.Text))
            {
                this.redGamma = float.Parse(txtRedValue.Text);
            }

            if (!string.IsNullOrEmpty(txtGreenValue.Text))
            {
                this.greenGamma = float.Parse(txtGreenValue.Text);
            }

            if (!string.IsNullOrEmpty(txtBlueValue.Text))
            {
                this.blueGamma = float.Parse(txtBlueValue.Text);
            }

            this.Close();

        }
    }
}
