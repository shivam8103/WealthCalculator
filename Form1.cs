namespace Mutual_Fund_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Remove any existing controls in the panel
            panel1.Controls.Clear();
            ShowFormInPanel1(new Form3());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Remove any existing controls in the panel
            panel1.Controls.Clear();
            ShowFormInPanel1(new Form4());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Remove any existing controls in the panel
            panel1.Controls.Clear();
            ShowFormInPanel1(new Form5());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Remove any existing controls in the panel
            panel1.Controls.Clear();
            ShowFormInPanel1(new Form6());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Remove any existing controls in the panel
            panel1.Controls.Clear();
            ShowFormInPanel1(new Form7());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Remove any existing controls in the panel
            panel1.Controls.Clear();
            ShowFormInPanel1(new Form8());
        }
        private void button8_Click(object sender, EventArgs e)
        {
            // Remove any existing controls in the panel
            panel1.Controls.Clear();
            ShowFormInPanel1(new Form9());
        }

       
        private void ShowFormInPanel1(Form form)
        {
            

            // Set the TopLevel property to false to allow embedding the form in a panel
            form.TopLevel = false;

            // Set the form to dock within the panel
            form.Dock = DockStyle.Fill;

            // Add the form to the panel's controls
            panel1.Controls.Add(form);

            // Show the form
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Remove any existing controls in the panel
            panel1.Controls.Clear();
            ShowFormInPanel1(new Form2());
            
        }




    }
}
