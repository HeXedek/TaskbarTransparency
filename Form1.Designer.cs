namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            trackBar1 = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(28, 28, 28);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 186);
            button1.Name = "button1";
            button1.Size = new Size(475, 38);
            button1.TabIndex = 0;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.AutoSize = false;
            trackBar1.LargeChange = 10;
            trackBar1.Location = new Point(12, 85);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(475, 50);
            trackBar1.SmallChange = 10;
            trackBar1.TabIndex = 1;
            trackBar1.TickFrequency = 0;
            trackBar1.Value = 5;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(457, 111);
            label1.Name = "label1";
            label1.Size = new Size(33, 19);
            label1.TabIndex = 2;
            label1.Text = "255";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 112);
            label2.Name = "label2";
            label2.Size = new Size(17, 19);
            label2.TabIndex = 3;
            label2.Text = "0";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(16, 16, 16);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(12, 134);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "[TRACKBARV]";
            textBox1.Size = new Size(478, 19);
            textBox1.TabIndex = 4;
            textBox1.TabStop = false;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.LostFocus += textBox1_LostFocus;
            textBox1.MouseLeave += textBox1_MouseLeave;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(14, 26);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 16, 16);
            ClientSize = new Size(499, 236);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(button1);
            MaximumSize = new Size(517, 280);
            MinimumSize = new Size(517, 280);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Leave += Form1_Leave;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TrackBar trackBar1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
    }
}
