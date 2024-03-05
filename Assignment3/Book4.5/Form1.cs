using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book4._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            double inVal,outVal;
            string inUnit = InputListBox.Text;
            string outUnit = OutputListBox.Text;

            try
            {
                inVal = double.Parse(inputTextBox.Text);
                switch (inUnit.ToLower())
                {
                    case "inches":
                        break;
                    case "feet":
                        inVal *= 12;
                        break;
                    case "yards":
                        inVal *= 36;
                        break;
                    default:
                        throw new FormatException("No input unit selected");
                }

                switch (outUnit.ToLower())
                {
                    case "inches":
                        outVal = inVal;
                        break;
                    case "feet":
                        outVal = inVal / 12;
                        break;
                    case "yards":
                        outVal = inVal / 36;
                        break;
                    default:
                        throw new FormatException("No output unit selected");
                }
                outputLbl.Text = outVal.ToString("n");

            }
            catch (FormatException ex) {
                MessageBox.Show("Invalid Input: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Overflow Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            OutputListBox.SelectedItem = null;
            InputListBox.SelectedItem = null;
            outputLbl.Text = "0.0";
        }
    }
}
