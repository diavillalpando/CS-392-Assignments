using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace part1
{
    public partial class Form1 : Form
    {
        private bool english_mode = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void englishToggle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            english_mode = !english_mode;
            englishToggle.Enabled = !english_mode;
            metricToggle.Enabled = english_mode;

            heightInput1.Text = "";
            heightInput2.Text = "";
            weightInput.Text = "";

            heightUnitsLabel2.Visible = english_mode;
            heightInput2.Visible = english_mode;

            if (english_mode)
            {
                weightUnitLabel.Text = "Pounds";
                heightUnitsLabel1.Text = "Feet";
            }
            else
            {
                weightUnitLabel.Text = "Kilograms";
                heightUnitsLabel1.Text = "Centimeters";
            }
        }

        private void calculate(object sender, EventArgs e)
        {
            try
            {
                double bmi = 0;
                string weight_status = "none";
                if (english_mode)
                {
                    double inches = (double.Parse(heightInput1.Text)) * 12 + (double.Parse(heightInput2.Text));
                    double pounds = (double.Parse(weightInput.Text));
                    bmi = (pounds / (Math.Pow(inches, 2))) * 703;
                }
                else
                {
                    double centimeters = (double.Parse(heightInput1.Text));
                    double kilograms = (double.Parse(weightInput.Text));
                    bmi = kilograms / (Math.Pow(centimeters/100, 2));
                }

                if (bmi < 18.5)
                {
                    weight_status = "Underweight";
                }else if (bmi < 24.9)
                {
                    weight_status = "Healthy Weight";
                }else if (bmi < 29.9)
                {
                    weight_status = "Overweight";
                }
                else
                {
                    weight_status = "Obesity";
                }
                MessageBox.Show("BMI: " + bmi + "\nWeight Status: " + weight_status);
            }
            catch
            {
                MessageBox.Show("Check that your values were inputed correctly");
            }
            
        }
    }
}
