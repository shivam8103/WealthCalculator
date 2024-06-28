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

namespace Mutual_Fund_Calculator
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "500";
            }
            int.TryParse(textBox1.Text, out int deposit);
            if (deposit > 150000)
            {
                MessageBox.Show("PPF allows a minimum investment of Rs. 500 and a Maximum of Rs. 1.5 lakh for each financial year", "Investment Limits", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "150000";
                trackBar1.Value = 150000;
            }
            else
            {
                trackBar1.Value = deposit;
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {






            if (decimal.TryParse(textBox1.Text, out decimal yearlyDeposit))
            {
                if (int.Parse(textBox1.Text) < 500)
                {
                    MessageBox.Show("PPF allows a minimum investment of Rs. 500 and a Maximum of Rs. 1.5 lakh for each financial year", "Investment Limits", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = "500";
                    trackBar1.Value = 500;

                }

                // Constants for calculation
                decimal annualInterestRate = 7.1m / 100; // 7.1% as decimal
                int timeInYears = 15; // Default time in years

                // Initialize variables
                decimal principal = 0;
                decimal maturityAmount = 0;
                decimal totalInterest = 0;
                decimal totalDeposit = yearlyDeposit * timeInYears;

                // Calculate PPF amount
                for (int i = 0; i < timeInYears; i++)
                {
                    principal += yearlyDeposit; // Add yearly deposit
                    decimal interest = principal * annualInterestRate; // Calculate interest
                    principal += interest; // Add interest to principal
                }

                maturityAmount = principal;
                totalInterest = maturityAmount - totalDeposit;

                // Display results
                textBox6.Text = "₹ " + maturityAmount.ToString("N2", CultureInfo.CreateSpecificCulture("hi-IN"));
                textBox5.Text = "₹ " + totalInterest.ToString("N2", CultureInfo.CreateSpecificCulture("hi-IN"));
                textBox4.Text = "₹ " + totalDeposit.ToString("N2", CultureInfo.CreateSpecificCulture("hi-IN"));
            }
            else
            {
                MessageBox.Show("Please enter a valid numerical value for Yearly Deposit.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
