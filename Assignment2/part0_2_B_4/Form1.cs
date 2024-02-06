using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part0_2_B_4
{
    public partial class Form1 : Form
    {
        private string setup = "What's the advantage of living in Switzerland?";
        private string punch = "Well, the flag is a big plus!";
        public Form1()
        {
            InitializeComponent();
        }

        private void sayPunchBtn_Click(object sender, EventArgs e)
        {
            jokeLabel.Text = punch;
        }

        private void SaySetupBtn_Click(object sender, EventArgs e)
        {
            jokeLabel.Text = setup;
        }


    }
}
