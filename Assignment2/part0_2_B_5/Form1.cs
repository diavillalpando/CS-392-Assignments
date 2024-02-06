using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part0_2_B_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showTailsBtn_Click(object sender, EventArgs e)
        {
            tailsPicture.Visible = true;
            headsPicture.Visible = false;
        }

        private void headsPicture_Click(object sender, EventArgs e)
        {
            headsPicture.Visible = true;
            tailsPicture.Visible = false;
        }
    }
}
