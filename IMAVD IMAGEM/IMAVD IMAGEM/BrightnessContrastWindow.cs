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
    public partial class BrightnessContrastWindow : Form
    {
        mainAppWindow context;
        public int chosenBrightness;
        public int chosenContrast;

        public BrightnessContrastWindow(mainAppWindow main, int previousBrightness,
            int previousContrast)
        {
            InitializeComponent();
            this.context = main;

            this.trackBarBrightness.Value = previousBrightness;
            this.txtBrightness.Text = previousBrightness.ToString();

            this.trackBarContrast.Value = previousContrast;
            this.txtContrast.Text = previousContrast.ToString();
        }

        private void btnConclude_Click(object sender, EventArgs e)
        {
            this.chosenBrightness = trackBarBrightness.Value;
            this.chosenContrast = trackBarContrast.Value;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            txtBrightness.Text = trackBarBrightness.Value.ToString();
        }

        private void trackBarContrast_Scroll(object sender, EventArgs e)
        {
            txtContrast.Text = trackBarContrast.Value.ToString();
        }
    }
}
