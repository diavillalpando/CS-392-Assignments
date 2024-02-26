using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book6._9
{
    public partial class Form1 : Form
    {
        private int computerChoice; //1 rock, 2 paper, 3 Scissors
        public Form1()
        {
            InitializeComponent();
        }

        private void computerChoose()
        {
            Random rnd = new Random();
            computerChoice = rnd.Next(1,4);
        }

        private string choiceToText(int play)
        {
            switch (play)
            {
                case 1:
                    return "Rock";
                case 2:
                    return "Paper";
                case 3:
                    return "Scissors";
            }
            return "";
        }
        
        private void play(int myChoice) 
        {
            int result;// 1 player won, -1 player lost, 0 tie
            string message;

            switch (computerChoice - myChoice)
            {
                case -1:
                    message = "You won!";
                    break;
                case 2:
                    message = "You won!";
                    break;
                case 0:
                    message = "Tie!";
                    break;
                default:
                    message = "You Lost!";
                    break;
            }
            MessageBox.Show($"Computer: {choiceToText(computerChoice)}\nYou: {choiceToText(myChoice)}\nResult: {message}");
            computerChoose();
        }

        private void rockBtn_Click(object sender, EventArgs e)
        {
            play(1);
        }

        private void paperBtn_Click(object sender, EventArgs e)
        {
            play(2);
        }

        private void scissorsBtn_Click(object sender, EventArgs e)
        {
            play(3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            computerChoose();
        }
    }
}
