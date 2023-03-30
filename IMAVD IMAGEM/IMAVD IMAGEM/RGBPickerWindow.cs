using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMAVD_IMAGEM
{
    public partial class RGBPickerWindow : Form
    {
        mainAppWindow context;
        int RValue;
        int GValue;
        int BValue;
        public RGBPickerWindow(mainAppWindow main)
        {
            RValue = -1;
            GValue = -1;
            BValue = -1;
            context = main;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                RValue = Int32.Parse(RTextBox.Text);
                GValue = Int32.Parse(GTextBox.Text);
                BValue = Int32.Parse(BTextBox.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("String could not be parsed.");
            }

            if (RGBIsValid(RValue, GValue, BValue))
            {
                context.detectChosenRGBInImage(RValue, GValue, BValue);
            }
            this.Close();
        }


        private bool RGBIsValid(int R, int G, int B)
        {

            if (R >= 0 && R <= 255 && G >= 0 && G <= 255 && B >= 0 && B <= 255)
            {
                return true;
            } else
            {
                MessageBox.Show("RGB Values were not within 0 and 255.");
                return false;
            }
        }
    }
}
