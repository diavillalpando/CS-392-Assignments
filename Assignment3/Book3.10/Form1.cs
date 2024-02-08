using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book3._10
{
    public partial class Form1 : Form
    {
        double totalCost = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void addItem(double cost)
        {
            try
            {
                this.totalCost += cost;
                outputLbl.Text = this.totalCost.ToString("c");
            }
            catch(OverflowException ex) {
                MessageBox.Show("Total is too large:\n" + ex.Message);
            }
            catch (Exception ex){
                MessageBox.Show("Something went wrong:\n" + ex.Message);
            }
            
        }
        private void applePicture_Click(object sender, EventArgs e)
        {
            addItem(1.35);
        }

        private void bananaPicture_Click(object sender, EventArgs e)
        {
            addItem(0.65);
        }

        private void orangePicture_Click(object sender, EventArgs e)
        {
            addItem(1.6);
        }

        private void pearPicture_Click(object sender, EventArgs e)
        {
            addItem(1.2);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.totalCost = 0.0;
            outputLbl.Text=this.totalCost.ToString("c");
        }
    }
}
