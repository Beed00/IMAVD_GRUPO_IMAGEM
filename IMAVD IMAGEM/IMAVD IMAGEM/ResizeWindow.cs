using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IMAVD_IMAGEM
{
    public partial class ResizeWindow : Form
    {
        mainAppWindow context;
        public bool byPercentage = false;
        public bool byAbsolute = false;
        public int resizePercentageValue;

        public int resizeWidthValue;
        public int resizeHeightValue;

        public ResizeWindow(mainAppWindow mainAppWindow, int width, int height)
        {
            InitializeComponent();
            context = mainAppWindow;

            resizeWidthNumber.Value = width;
            resizeHeightNumber.Value = height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // If valid
            if (resizeByPercentage.Checked)
            {
                resizePercentageValue = (int)resizePercentage.Value;
                byPercentage = true;
            }
            else if (resizeByAbsoluteValue.Checked)
            {
                resizeWidthValue = (int)resizeWidthNumber.Value;
                resizeHeightValue = (int)resizeHeightNumber.Value;
                byAbsolute = true;
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resizeByPercentage_CheckedChanged(object sender, EventArgs e)
        {
            if (resizeByPercentage.Checked)
            {
                resizePercentage.ReadOnly = false;
                resizePercentage.Increment = 1;

                resizeWidthNumber.ReadOnly = true;
                resizeWidthNumber.Increment = 0;
                resizeHeightNumber.ReadOnly = true;
                resizeHeightNumber.Increment = 0;
            }
        }

        private void resizeByAbsoluteValue_CheckedChanged(object sender, EventArgs e)
        {
            if (resizeByAbsoluteValue.Checked)
            {
                resizePercentage.ReadOnly = true;
                resizePercentage.Increment = 0;

                resizeWidthNumber.ReadOnly = false;
                resizeWidthNumber.Increment = 1;
                resizeHeightNumber.ReadOnly = false;
                resizeHeightNumber.Increment = 1;
            }
        }
    }
}
