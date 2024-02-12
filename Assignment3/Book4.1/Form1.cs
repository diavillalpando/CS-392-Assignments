using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book4._1
{
    public partial class FormBook4_1 : Form
    {
        private readonly string[] romanNums = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
        public FormBook4_1()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            int inputNumber;
            if(int.TryParse(inputTextBox.Text,out inputNumber) && ( 0 < inputNumber && inputNumber < 11))
            {
                outputLabel.Text = romanNums[inputNumber - 1];
            }
            else
            {
                MessageBox.Show("Invalid input, make sure it is an integer between 1-10");
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "...";
        }
    }
}
