using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supplemental1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string word;
        string hint;
        char[] guessed;
        private void btnGetWord_Click(object sender, EventArgs e)
        {
            new_word();
        }

        private void new_word() {
            word = "string";
            hint = "not empty";

            lblHint.Text = hint;
            guessed = new char[word.Length]; // Initialize guessed array

            // Fill guessed array with underscores
            for (int i = 0; i < word.Length; i++)
            {
                guessed[i] = '_';
            }

            lblDisplay.Text = new string(guessed); // Convert guessed array to string and set it to lblDisplay.Text

            // Enable all buttons in panel1
            foreach (Control control in panel1.Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            char letter = Char.ToLower(Char.Parse((sender as Button).Text));
            check_letter(letter);



        }

        private void check_letter(char letter)
        {
            bool correct = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (letter == word[i])
                {
                    correct = true;
                    guessed[i] = letter;
                }
            }

            if (!correct)
            {
                pictureBox1.Image = Properties.Resources.hangman_step5; // Update the hangman image
            }

            // Update the display with the new guessed array
            lblDisplay.Text = new string(guessed);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
