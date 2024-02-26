using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book6._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double calculateRetail(double cost, double markup)
        {
            if (markup > 100 || markup < 0)
            {
                throw new ArgumentException("Markup needs to be less than or equal to 100 and greater than or equal to 0 ");
            }
            return cost + cost * (markup / 100);
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double itemCost = double.Parse(itemTxtBox.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency);
                double itemMarkup = double.Parse(markupTxtBox.Text);
                outputLbl.Text = calculateRetail(itemCost, itemMarkup).ToString("c");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Input formatted incorrectly : {ex.Message}");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Number too large: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Invalid argument: {ex.Message}");
            }
            catch (Exception ex){
                MessageBox.Show($"Something went wrong: {ex.Message}");
            }
        }
    }
}
