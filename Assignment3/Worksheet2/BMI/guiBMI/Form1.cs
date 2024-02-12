using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_392_HW2_BMU_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            calc_catch();
        }

        private void calc_catch() {
            try
            {
                double bmi = 0;
                string weight_status = "none";
                double age = double.Parse(txtAge.Text);
                string gender = txtGender.Text;
                string msg = "";

                if (txtAge.Text == "") { 
                    txtAge.Text = "0";
                }
                if (txtFt.Text == "") { 
                    txtFt.Text = "0";
                }
                if (txtInches.Text == "") {
                    txtInches.Text = "0";
                }
                if (txtPounds.Text == "") { 
                    txtPounds.Text = "0";
                }
                if (lblFeet.Text.Equals("Feet"))
                {
                    double inches = (double.Parse(txtFt.Text)) * 12 + (double.Parse(txtInches.Text));
                    double pounds = (double.Parse(txtPounds.Text));
                    bmi = (pounds / (Math.Pow(inches, 2))) * 703;
                }
                else
                {
                    double centimeters = (double.Parse(txtFt.Text));
                    double kilograms = (double.Parse(txtPounds.Text));
                    bmi = kilograms / (Math.Pow(centimeters / 100, 2));
                }

                if (bmi < 18.5)
                {
                    weight_status = "Underweight";
                }
                else if (bmi < 24.9)
                {
                    weight_status = "Healthy Weight";
                }
                else if (bmi < 29.9)
                {
                    weight_status = "Overweight";
                }
                else
                {
                    weight_status = "Obesity";
                }
                if (gender == "")
                {
                    msg = ("Your BMI is " + bmi + " at age " + age + ".");
                }
                else
                {
                    msg = ("You are a " + age + " year old " + gender + " with a BMI of " + bmi + ".");
                }
                MessageBox.Show(msg + "\n Weight satus: " + weight_status );
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Check that your values were inputed correctly: " + ex);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Unrealiscly great weight or height: " + ex);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Your height cannot be 0: " + ex);
            }
            catch (Exception ex) { 
                MessageBox.Show("Something else is wrong: "+ ex);
            }
        }

        private void lblEnglish_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblFeet.Text = "Feet";
            lblPounds.Text = "Pounds";
            lblInches.Visible = true;
            txtInches.Visible = true;
        }

        private void lblMetric_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblFeet.Text = "Centimeters";
            lblPounds.Text = "Kilograms";
            lblInches.Visible = false;
            txtInches.Visible = false;
        }

        private void lblHeight_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
