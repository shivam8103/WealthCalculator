namespace Mutual_Fund_Calculator
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            trackBar1 = new TrackBar();
            button1 = new Button();
            label2 = new Label();
            trackBar2 = new TrackBar();
            label3 = new Label();
            trackBar3 = new TrackBar();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(183, 181, 151);
            label1.Font = new Font("Cambria", 13F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(37, 67, 54);
            label1.Location = new Point(31, 96);
            label1.Name = "label1";
            label1.Size = new Size(275, 26);
            label1.TabIndex = 100;
            label1.Text = "Monthly Repayment(EMI)";
            label1.Click += label1_Click;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Top;
            trackBar1.BackColor = Color.FromArgb(183, 181, 151);
            trackBar1.LargeChange = 500;
            trackBar1.Location = new Point(28, 133);
            trackBar1.Maximum = 100000;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(784, 56);
            trackBar1.SmallChange = 100;
            trackBar1.TabIndex = 101;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
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
            button1.Location = new Point(364, 405);
            button1.Name = "button1";
            button1.Size = new Size(126, 50);
            button1.TabIndex = 4;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(183, 181, 151);
            label2.Font = new Font("Cambria", 13F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(37, 67, 54);
            label2.Location = new Point(28, 192);
            label2.Name = "label2";
            label2.Size = new Size(261, 26);
            label2.TabIndex = 102;
            label2.Text = "Annual Interest Rate(%)";
            // 
            // trackBar2
            // 
            trackBar2.Anchor = AnchorStyles.Top;
            trackBar2.BackColor = Color.FromArgb(183, 181, 151);
            trackBar2.Location = new Point(31, 229);
            trackBar2.Maximum = 20;
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(795, 56);
            trackBar2.TabIndex = 103;
            trackBar2.TickStyle = TickStyle.None;
            trackBar2.Value = 1;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(183, 181, 151);
            label3.Font = new Font("Cambria", 13F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(37, 67, 54);
            label3.Location = new Point(31, 288);
            label3.Name = "label3";
            label3.Size = new Size(166, 26);
            label3.TabIndex = 104;
            label3.Text = "Loan Term (Yr)";
            // 
            // trackBar3
            // 
            trackBar3.Anchor = AnchorStyles.Top;
            trackBar3.BackColor = Color.FromArgb(183, 181, 151);
            trackBar3.Location = new Point(31, 330);
            trackBar3.Maximum = 30;
            trackBar3.Minimum = 1;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(792, 56);
            trackBar3.TabIndex = 105;
            trackBar3.TickStyle = TickStyle.None;
            trackBar3.Value = 1;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = Color.FromArgb(183, 181, 151);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Cambria", 13F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(37, 67, 54);
            textBox1.Location = new Point(620, 94);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "₹";
            textBox1.Size = new Size(192, 33);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.BackColor = Color.FromArgb(183, 181, 151);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Cambria", 13F, FontStyle.Bold);
            textBox2.ForeColor = Color.FromArgb(37, 67, 54);
            textBox2.Location = new Point(620, 190);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "%";
            textBox2.Size = new Size(192, 33);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top;
            textBox3.BackColor = Color.FromArgb(183, 181, 151);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Cambria", 13F, FontStyle.Bold);
            textBox3.ForeColor = Color.FromArgb(37, 67, 54);
            textBox3.Location = new Point(623, 291);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = " Year";
            textBox3.Size = new Size(192, 33);
            textBox3.TabIndex = 2;
            textBox3.TextAlign = HorizontalAlignment.Right;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top;
            textBox6.BackColor = Color.FromArgb(183, 181, 151);
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Cambria", 14F, FontStyle.Bold);
            textBox6.ForeColor = Color.FromArgb(37, 67, 54);
            textBox6.Location = new Point(616, 485);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(203, 35);
            textBox6.TabIndex = 109;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top;
            textBox5.BackColor = Color.FromArgb(183, 181, 151);
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Cambria", 13F, FontStyle.Bold);
            textBox5.ForeColor = Color.FromArgb(37, 67, 54);
            textBox5.Location = new Point(616, 531);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(203, 33);
            textBox5.TabIndex = 110;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top;
            textBox4.BackColor = Color.FromArgb(183, 181, 151);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Cambria", 13F, FontStyle.Bold);
            textBox4.ForeColor = Color.FromArgb(37, 67, 54);
            textBox4.Location = new Point(616, 571);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(203, 33);
            textBox4.TabIndex = 111;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(183, 181, 151);
            label6.Font = new Font("Cambria", 14F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(37, 67, 54);
            label6.Location = new Point(35, 489);
            label6.Name = "label6";
            label6.Size = new Size(260, 28);
            label6.TabIndex = 106;
            label6.Text = "Total Repayment (P+I)";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(183, 181, 151);
            label5.Font = new Font("Cambria", 13F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(37, 67, 54);
            label5.Location = new Point(35, 536);
            label5.Name = "label5";
            label5.Size = new Size(185, 26);
            label5.TabIndex = 107;
            label5.Text = "Loan Amount (P)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(183, 181, 151);
            label4.Font = new Font("Cambria", 13F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(37, 67, 54);
            label4.Location = new Point(35, 576);
            label4.Name = "label4";
            label4.Size = new Size(174, 26);
            label4.TabIndex = 108;
            label4.Text = "Interest Paid (I)";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(183, 181, 151);
            label7.Enabled = false;
            label7.Font = new Font("Cambria", 24F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(37, 67, 54);
            label7.Location = new Point(272, 17);
            label7.Name = "label7";
            label7.Size = new Size(310, 47);
            label7.TabIndex = 112;
            label7.Text = "LOAN (Amount)";
            label7.Click += label7_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(183, 181, 151);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
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
            // Form5
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 181, 151);
            ClientSize = new Size(855, 620);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TrackBar trackBar1;
        private Button button1;
        private Label label2;
        private TrackBar trackBar2;
        private Label label3;
        private TrackBar trackBar3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Panel panel1;
    }
}