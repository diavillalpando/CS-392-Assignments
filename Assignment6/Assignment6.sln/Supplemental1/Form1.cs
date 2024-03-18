using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            loadWords();

            new_word();
        }

        // initalize variables 
        private string word;
        string hint;
        char[] guessed;
        private int incorrectGuesses = 0;

        class wordAndHint { 
            public string word { get; set; }
            public string hint { get; set; }

        }

        private List<wordAndHint> words;

        private void loadWords()
        {
            DataSet dataSet = new WordBankDataSet(); // Create an object of type WordBankDataSet


            // Check if the dataset contains any tables
            if (dataSet.Tables.Count > 0)
            {
                DataTable dataTable = dataSet.Tables[0];
                if (dataTable.Rows.Count > 0)
                {
                    // Iterate through each row in the table
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        // Extract word and hint from the current row
                        string word = dr["Word"].ToString();
                        string hint = dr["Hint"].ToString();

                        // Create a new wordAndHint object and add it to the list
                        words.Add(new wordAndHint { word = word, hint = hint });
                    }
                }
                else
                {
                    MessageBox.Show("No rows found in the DataTable.");
                }
            }
            else
            {
                MessageBox.Show("The DataSet does not contain any tables.");
            }
        }





        private void btnGetWord_Click(object sender, EventArgs e)
        {
            new_word();
        }

        private void new_word()
        {
            // Check if there are words available in the list
            if (words.Count > 0)
            {
                // Randomly select a wordAndHint object from the list
                Random random = new Random();
                wordAndHint chosenWord = words[random.Next(words.Count)];

                // Assign the word and hint from the selected wordAndHint object
                word = chosenWord.word;
                hint = chosenWord.hint;

                // Display the hint
                lblHint.Text = hint;

                // Initialize guessed array
                guessed = new char[word.Length];

                // Fill guessed array with underscores
                for (int i = 0; i < word.Length; i++)
                {
                    guessed[i] = '_';
                }

                // Display guessed array
                lblDisplay.Text = new string(guessed);

                // Enable all buttons in panel1
                foreach (Control control in panel1.Controls)
                {
                    if (control is Button button)
                    {
                        button.Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("No words available.");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // disable the button
            (sender as Button).Enabled = false;
            char letter = Char.ToLower(Char.Parse((sender as Button).Text));
            // check to see if the letter apears
            check_letter(letter);
        }

        private void check_letter(char letter) // method to check if a letter appears in the word and update the form accordingly
        {
            bool correct = false;

            // checking to see if the letter appeared at each location
            for (int i = 0; i < word.Length; i++)
            {
                if (letter == word[i])
                {
                    correct = true;
                    guessed[i] = letter;
                }
            }

            // chech if the letter chosen appeared at least once
            if (!correct)
            {
                // increment the amount of incorrect guesses and update the hangman image
                incorrectGuesses++;
                UpdateHangmanImage();

            }

            // Update the display with the new guessed array
            lblDisplay.Text = new string(guessed);

            // check to see if the player had sucessfully guessed every letter
            if (lblDisplay.Text == word) {
                MessageBox.Show("Congratulations, you won! Prepare to start a new game.");
                new_word();
            }
        }

        private void UpdateHangmanImage()
        {
            switch (incorrectGuesses)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.hangman_step2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.hangman_step3;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.hangman_step4;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.hangman_step5;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.hangman_step6;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.hangman_step7;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.hangman_step8;
                    MessageBox.Show($"Eh, you lost! The answer was '{word}'. Prepare to start a new game.");
                    new_word();
                    break;
                default:
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
