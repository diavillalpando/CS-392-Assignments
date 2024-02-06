using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part2
{
    public partial class Form1 : Form
    {
        private string displayText = "";
        private double storedVal = 0.0;
        private string storedOptr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void numberBtn_click(object sender, EventArgs e)
        {
            displayText += (sender as Button).Text;
            outputTextBox.Text = displayText;
        }

        private void operatorBtn_click(object sender, EventArgs e)
        {
            calculateBtn_Click(sender, e);
            storedOptr = (sender as Button).Text;
        }


        private void clearBtn_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = "0.0";
            storedVal = 0.0;
            displayText = "";
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double screenVal = double.Parse(outputTextBox.Text);
            if (storedOptr == "+")
            {
                outputTextBox.Text = (storedVal + screenVal).ToString();
            }
            else if (storedOptr == "-")
            {
                outputTextBox.Text = (storedVal - screenVal).ToString();
            }
            else if (storedOptr == "*")
            {
                outputTextBox.Text = (storedVal * screenVal).ToString();
            }
            else if (storedOptr == "/")
            {
                outputTextBox.Text = (storedVal / screenVal).ToString();
            }

            storedVal = double.Parse(outputTextBox.Text);
            storedOptr = "";
            displayText = "";
        }
    }
}
