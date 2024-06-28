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
    public partial class Form7 : Form
    {
        public Form7()
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
            // Validate and read input values
            if (double.TryParse(textBox1.Text, out double principal) &&
                double.TryParse(textBox2.Text, out double annualInterestRate) &&
                double.TryParse(textBox3.Text, out double timeInYears))
            {
                // Convert annual interest rate to a decimal
                double interestRate = annualInterestRate / 100;

                // Number of times interest is compounded per year (assuming monthly compounding here)
                int compoundingFrequency = 12;

                // Calculate maturity amount using the compound interest formula
                double maturityAmount = principal * Math.Pow(1 + interestRate / compoundingFrequency, compoundingFrequency * timeInYears);

                // Calculate total interest
                double totalInterest = maturityAmount - principal;

                // Display results
                textBox4.Text = "₹ " + principal.ToString("N0", CultureInfo.CreateSpecificCulture("hi-IN")); // Total deposit amount
                textBox5.Text = "₹ " + totalInterest.ToString("N0", CultureInfo.CreateSpecificCulture("hi-IN")); // Total interest
                textBox6.Text = "₹ " + maturityAmount.ToString("N0", CultureInfo.CreateSpecificCulture("hi-IN")); // Maturity amount
            }
            else
            {
                MessageBox.Show("Please enter valid numerical values in all input fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
