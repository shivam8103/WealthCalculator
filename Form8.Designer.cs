namespace Mutual_Fund_Calculator
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            textBox6 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            trackBar3 = new TrackBar();
            label3 = new Label();
            trackBar2 = new TrackBar();
            label2 = new Label();
            button1 = new Button();
            trackBar1 = new TrackBar();
            label13 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top;
            textBox6.BackColor = Color.FromArgb(183, 181, 151);
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Cambria", 18F, FontStyle.Bold);
            textBox6.ForeColor = Color.FromArgb(37, 67, 54);
            textBox6.Location = new Point(615, 459);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(203, 43);
            textBox6.TabIndex = 55;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(183, 181, 151);
            label6.Font = new Font("Cambria", 18F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(37, 67, 54);
            label6.Location = new Point(37, 459);
            label6.Name = "label6";
            label6.Size = new Size(175, 36);
            label6.TabIndex = 52;
            label6.Text = "Future Cost";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(183, 181, 151);
            label7.Enabled = false;
            label7.Font = new Font("Cambria", 24F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(37, 67, 54);
            label7.Location = new Point(338, 23);
            label7.Name = "label7";
            label7.Size = new Size(179, 47);
            label7.TabIndex = 48;
            label7.Text = "Inflation";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(183, 181, 151);
            label4.Font = new Font("Cambria", 13F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(37, 67, 54);
            label4.Location = new Point(33, 635);
            label4.Name = "label4";
            label4.Size = new Size(0, 26);
            label4.TabIndex = 50;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top;
            textBox3.BackColor = Color.FromArgb(183, 181, 151);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Cambria", 13F, FontStyle.Bold);
            textBox3.ForeColor = Color.FromArgb(37, 67, 54);
            textBox3.Location = new Point(622, 289);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = " Year";
            textBox3.Size = new Size(192, 33);
            textBox3.TabIndex = 3;
            textBox3.TextAlign = HorizontalAlignment.Right;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.BackColor = Color.FromArgb(183, 181, 151);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Cambria", 13F, FontStyle.Bold);
            textBox2.ForeColor = Color.FromArgb(37, 67, 54);
            textBox2.Location = new Point(622, 186);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "5.70% in 2023";
            textBox2.Size = new Size(192, 33);
            textBox2.TabIndex = 2;
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = Color.FromArgb(183, 181, 151);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Cambria", 13F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(37, 67, 54);
            textBox1.Location = new Point(622, 88);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "₹";
            textBox1.Size = new Size(192, 33);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // trackBar3
            // 
            trackBar3.Anchor = AnchorStyles.Top;
            trackBar3.BackColor = Color.FromArgb(183, 181, 151);
            trackBar3.Location = new Point(33, 326);
            trackBar3.Maximum = 40;
            trackBar3.Minimum = 1;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(792, 56);
            trackBar3.TabIndex = 36;
            trackBar3.TickStyle = TickStyle.None;
            trackBar3.Value = 1;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(183, 181, 151);
            label3.Font = new Font("Cambria", 13F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(37, 67, 54);
            label3.Location = new Point(33, 292);
            label3.Name = "label3";
            label3.Size = new Size(168, 26);
            label3.TabIndex = 24;
            label3.Text = "Time (in years)";
            // 
            // trackBar2
            // 
            trackBar2.Anchor = AnchorStyles.Top;
            trackBar2.BackColor = Color.FromArgb(183, 181, 151);
            trackBar2.Location = new Point(30, 233);
            trackBar2.Maximum = 30;
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(795, 56);
            trackBar2.TabIndex = 35;
            trackBar2.TickStyle = TickStyle.None;
            trackBar2.Value = 1;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(183, 181, 151);
            label2.Font = new Font("Cambria", 13F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(37, 67, 54);
            label2.Location = new Point(33, 191);
            label2.Name = "label2";
            label2.Size = new Size(371, 26);
            label2.TabIndex = 23;
            label2.Text = "Expected Annual Inflation Rate (%)";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(37, 67, 54);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(107, 138, 122);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(107, 138, 122);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Cambria", 13F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(183, 181, 151);
            button1.Location = new Point(364, 381);
            button1.Name = "button1";
            button1.Size = new Size(126, 50);
            button1.TabIndex = 4;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Top;
            trackBar1.BackColor = Color.FromArgb(183, 181, 151);
            trackBar1.LargeChange = 500;
            trackBar1.Location = new Point(30, 127);
            trackBar1.Maximum = 100000;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(784, 56);
            trackBar1.SmallChange = 100;
            trackBar1.TabIndex = 34;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Enabled = false;
            label13.Font = new Font("Cambria", 11F);
            label13.ForeColor = Color.FromArgb(37, 67, 54);
            label13.Location = new Point(354, 619);
            label13.Name = "label13";
            label13.Size = new Size(0, 22);
            label13.TabIndex = 44;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(183, 181, 151);
            label1.Font = new Font("Cambria", 13F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(37, 67, 54);
            label1.Location = new Point(33, 96);
            label1.Name = "label1";
            label1.Size = new Size(248, 26);
            label1.TabIndex = 22;
            label1.Text = "Current Cost of an Item";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(183, 181, 151);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(trackBar2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(trackBar3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 620);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 14F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(37, 67, 54);
            label5.Location = new Point(37, 510);
            label5.MaximumSize = new Size(800, 100);
            label5.Name = "label5";
            label5.Size = new Size(76, 28);
            label5.TabIndex = 0;
            label5.Text = "Note: ";
            // 
            // Form8
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 181, 151);
            ClientSize = new Size(855, 620);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form8";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inflation";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox6;
        private Label label6;
        private Label label7;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TrackBar trackBar3;
        private Label label3;
        private TrackBar trackBar2;
        private Label label2;
        private Button button1;
        private TrackBar trackBar1;
        private Label label13;
        private Label label1;
        private Panel panel1;
        private Label label5;
    }
}