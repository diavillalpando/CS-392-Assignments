using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problems_app
{
    public partial class Form1 : Form
    {
        int number1;
        int number2;
        int attempts = 1;
        int answer;
        int correct;
        int problem = 1;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generate_problem();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {

        }

        private void lblProblem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void generate_problem() {
            Random num1 = new Random();

            attempts = 1;
            if (btnAdd.Checked) {
                lblExpression.Text = "+";
                number1 = num1.Next(0, 10);
                number2 = num1.Next(0, 10);
                answer = number1 + number2;
            } else {
                lblExpression.Text = "-";
                number1 = num1.Next(1, 10);
                number2 = num1.Next(0, number1);
                answer = number1- number2;
            }
            lblNum1.Text = number1.ToString();
            lblNum2.Text = number2.ToString();
            lblAttempNum.Text = attempts.ToString();
            lblProblemNum.Text = problem.ToString();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int user_input;
            try
            {
                user_input = int.Parse(txtAns.Text);

                if (user_input == answer)
                {
                    generate_problem();
                    correct++;
                    problem += 1;
                    MessageBox.Show("Correct!");
                }
                else
                {
                    attempts++;
                    if (attempts > 3)
                    {
                        MessageBox.Show("Incorrect, lets try something else.");
                        generate_problem();
                        problem += 1;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect, try again");

                    }
                }

                if (problem > 10)
                {
                    MessageBox.Show("Quiz completed. You got " + correct + " out of 10 problems correct.");
                    problem = 1;
                    correct = 0;
                }
                txtAns.Text = "";
                lblAttempNum.Text = attempts.ToString();
                lblProblemNum.Text = problem.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid number. " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Number is too big. " + ex.Message);
            }
            catch (Exception ex) {
                MessageBox.Show("Something was wrong. " + ex.Message);
            }
             
        }

        private void btnSubtract_CheckedChanged(object sender, EventArgs e)
        {
            generate_problem();
        }
    }
}
