using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book7._6
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool exists = list.Any(s => s.Contains(textBox1.Text));
            if (exists)
            {
                label2.Text = "This name is in the most popular girl's name list!";
            }
            else
            {
                label2.Text = "This name is not in the most popular girl's name list.";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\karla\source\repos\CS-392-Assignments\Assignment4\Book7.6\Book7.6\GirlNames.txt");
            String line = sr.ReadLine();
            while (line != null)
            {
                list.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
