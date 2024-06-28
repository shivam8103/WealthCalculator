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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Parse the text box value, default to 1 if parsing fails or text box is empty
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                // If textbox is empty, set default value to 1
                textBox1.Text = "1";
            }

            if (int.TryParse(textBox1.Text, out int valueFromTextBox))
            {
                // Check if the parsed value is within the range of the TrackBar
                if (valueFromTextBox < trackBar1.Minimum)
                    trackBar1.Value = trackBar1.Minimum;
                else if (valueFromTextBox > trackBar1.Maximum)
                    trackBar1.Value = trackBar1.Maximum;

                else
                    trackBar1.Value = valueFromTextBox;

            }
            else
            {
                // Handle case where parsing fails (invalid input)
                MessageBox.Show("Invalid input. Please enter a valid integer.");
                textBox1.Text = "1"; // Set default value to 1
                trackBar1.Value = 1; // Set default value to 1 for TrackBar
            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox2.Text = "1";
            }

            if (decimal.TryParse(textBox2.Text, out decimal valueFromTextBox))
            {
                if (valueFromTextBox < trackBar2.Minimum)
                    trackBar2.Value = trackBar2.Minimum;
                else if (valueFromTextBox > trackBar2.Maximum)
                    trackBar2.Value = trackBar2.Maximum;

                else
                    trackBar2.Value = (int)valueFromTextBox;

            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid integer.");
                textBox2.Text = "1";
                trackBar2.Value = 1;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox3.Text = "1";
            }

            if (int.TryParse(textBox3.Text, out int valueFromTextBox))
            {
                if (valueFromTextBox < trackBar3.Minimum)
                    trackBar3.Value = trackBar3.Minimum;
                else if (valueFromTextBox > trackBar3.Maximum)
                    trackBar3.Value = trackBar3.Maximum;

                else
                    trackBar3.Value = valueFromTextBox;

            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid integer.");
                textBox3.Text = "1";
                trackBar3.Value = 1;
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar2.Value.ToString();
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = trackBar3.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the input values
            if (double.TryParse(textBox1.Text, out double emi) &&
                double.TryParse(textBox2.Text, out double annualInterestRate) &&
                int.TryParse(textBox3.Text, out int loanTermInYears))
            {
                // Calculate monthly interest rate
                double monthlyInterestRate = annualInterestRate / 12 / 100;

                // Calculate loan term in months
                int loanTermInMonths = loanTermInYears * 12;

                // Calculate the principal loan amount (P) using the rearranged formula
                double loanAmount = emi * (Math.Pow(1 + monthlyInterestRate, loanTermInMonths) - 1) /
                                    (monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, loanTermInMonths));

                // Calculate total repayment (P + I)
                double totalRepayment = emi * loanTermInMonths;

                // Calculate interest paid (I)
                double interestPaid = totalRepayment - loanAmount;

                // Set the output values
                textBox4.Text = "₹ " + interestPaid.ToString("N0", CultureInfo.CreateSpecificCulture("hi-IN")); // Interest paid
                textBox5.Text = "₹ " + loanAmount.ToString("N0", CultureInfo.CreateSpecificCulture("hi-IN")); // Principal amount
                textBox6.Text = "₹ " + totalRepayment.ToString("N0", CultureInfo.CreateSpecificCulture("hi-IN")); // Total repayment
            }
            else
            {
                MessageBox.Show("Please enter valid numerical values in all input fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
