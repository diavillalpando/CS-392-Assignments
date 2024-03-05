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

namespace Book5._11
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

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBox1.Text);
                int result = num1;
                if (num1 >= 0)
                {
                    for (int val = num1 - 1; val > 0; val--)
                    {
                        result = result * val;
                    }
                    resultLabel.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("You must enter a positive number");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
