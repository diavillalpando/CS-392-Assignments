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

        private double oilChangeCharges()
        {
            return 50.0 * (Convert.ToInt32(oilChangeCheck.Checked));
        }
        private double lubeCharges()
        {
            return 40.0 * (Convert.ToInt32(lubeJobCheck.Checked));
        }
        private double radiatorFlushCharges()
        {
            return 100.0 * (Convert.ToInt32(radFlushCheck.Checked));
        }
        private double transmissionFlushCharges()
        {
            return 120.0 * (Convert.ToInt32(transFlushCheck.Checked));
        }
        private double InspectionCharges()
        {
            return 35.0 * (Convert.ToInt32(inspectionCheck.Checked));
        }
        private double MufflerCharges()
        {
            return 150.0 * (Convert.ToInt32(replaceMufflerCheck.Checked));
        }
        private double tireRotationCharges()
        {
            return 25.0 * (Convert.ToInt32(tireRotateCheck.Checked));
        }
        private double partsCharges()
        {
            return double.Parse(partsTxtBox.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency);
        }
        private double laborCharges()
        {
            return double.Parse(laborTxtBox.Text) * 75;
        }
        private double taxCharges()
        {
            return partsCharges() * 0.2;
        }
        private double serviceLaborCharges()
        {
            double oilLube = oilChangeCharges() + lubeCharges();
            double flushes = radiatorFlushCharges() + transmissionFlushCharges();
            double misc = InspectionCharges() + MufflerCharges() + tireRotationCharges();

            return oilLube + flushes + misc + laborCharges();
        }
        private double totalCharges()
        {
            double serviceAndLabor = serviceLaborCharges();
            double parts = partsCharges();
            double partsTax = taxCharges();

            return serviceAndLabor + partsTax + parts;
            
        }
        private void clearForm()
        {
            oilChangeCheck.Checked = false;
            lubeJobCheck.Checked = false;

            radFlushCheck.Checked = false;
            transFlushCheck.Checked = false;

            inspectionCheck.Checked = false;
            replaceMufflerCheck.Checked = false;
            tireRotateCheck.Checked = false;

            partsTxtBox.Text = "0";
            laborTxtBox.Text = "0";

            serviceOutput.Text = "$0.0";
            partsOutput.Text = "$0.0";
            taxOutput.Text = "$0.0";
            totalOutput.Text = "$0.0";
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                serviceOutput.Text = serviceLaborCharges().ToString("c");
                partsOutput.Text = partsCharges().ToString("c");
                taxOutput.Text = taxCharges().ToString("c");
                totalOutput.Text = totalCharges().ToString("c");

            }
            catch(FormatException ex)
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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}
