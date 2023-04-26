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
    public partial class TextForImageWindow : Form
    {
        mainAppWindow context;
        public string textToAdd;

        public TextForImageWindow(mainAppWindow main)
        {
            InitializeComponent();
            context = main;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtBox.Text))
            {
                textToAdd = txtBox.Text;
            }

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
