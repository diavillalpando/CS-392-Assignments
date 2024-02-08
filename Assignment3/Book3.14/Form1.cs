using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book3._14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double aCost, bCost, cCost, totalCost;

                aCost = 15 * double.Parse(inputATxtBox.Text);
                bCost = 12 * double.Parse(inputBTxtBox.Text);
                cCost = 09 * double.Parse(inputCTxtBox.Text);
                totalCost = aCost + bCost + cCost;

                outputA.Text = (aCost).ToString("c");
                outputB.Text = (bCost).ToString("c");
                outputC.Text = (cCost).ToString("c");
                totalOutput.Text = (totalCost).ToString("c");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Check your input:\n" + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Number too big:\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong:\n" + ex.Message);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            outputA.Text = "$0.0";
            outputB.Text = "$0.0";
            outputC.Text = "$0.0";
            totalOutput.Text = "$0.0";
        }
    }
}
