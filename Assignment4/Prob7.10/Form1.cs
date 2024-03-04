using Prob7._10.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prob7._10
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void spin_btn_Click(object sender, EventArgs e)
        {
            int money_in;
            if (Int32.TryParse(money_inp.Text, out money_in)){
                System.Drawing.Bitmap[] images = { Resources.black, Resources.green, Resources.red};
                PictureBox[] pics = { pic1, pic2, pic3 };
                Random rnd = new Random();
                for (int i = 0; i < 3; i++)
                    pics[i].Image = images[rnd.Next(0, 3)];
                if (pic1.Image == pic2.Image&&pic2.Image == pic3.Image)
                {
                    won_label.Text ="Won $"+(money_in * 3).ToString();
                }
                else
                {
                    won_label.Text = "Won $0";
                }
            }
            
            else
            {
                won_label.Text = "Bad input. Use only integers, with a max value of 2147483647";
            }
            
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
