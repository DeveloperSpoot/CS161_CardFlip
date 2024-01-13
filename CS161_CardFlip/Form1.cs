using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS161_CardFlip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showBackCardButton_Click(object sender, EventArgs e)
        {
            cardFrontPic.Visible = false;
            cardBackPic.Visible = true;
            showBackCardButton.Enabled = false;
            showCardFrontButton.Enabled = true;
        }

        private void showCardFrontButton_Click(object sender, EventArgs e)
        {
            cardBackPic.Visible = false;
            cardFrontPic.Visible = true;
            showCardFrontButton.Enabled = false;
            showBackCardButton.Enabled = true;
        }
    }
}
