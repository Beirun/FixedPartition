namespace FixedPartition
{
    partial class Start
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            panel3 = new Panel();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(378, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 82);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 26F);
            textBox1.Location = new Point(8, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(404, 58);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(378, 343);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 82);
            panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 26F);
            textBox2.Location = new Point(8, 11);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(404, 58);
            textBox2.TabIndex = 0;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(378, 139);
            label1.Name = "label1";
            label1.Size = new Size(158, 35);
            label1.TabIndex = 2;
            label1.Text = "Memory Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(378, 305);
            label2.Name = "label2";
            label2.Size = new Size(253, 35);
            label2.TabIndex = 3;
            label2.Text = "Number of Processes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 28F);
            label3.Location = new Point(411, 42);
            label3.Name = "label3";
            label3.Size = new Size(334, 62);
            label3.TabIndex = 4;
            label3.Text = "ENTER VALUES";
            // 
            // button1
            // 
            button1.Location = new Point(486, 632);
            button1.Name = "button1";
            button1.Size = new Size(172, 45);
            button1.TabIndex = 5;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(378, 482);
            label4.Name = "label4";
            label4.Size = new Size(124, 35);
            label4.TabIndex = 7;
            label4.Text = "Block Size";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(textBox3);
            panel3.Location = new Point(378, 520);
            panel3.Name = "panel3";
            panel3.Size = new Size(422, 82);
            panel3.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 26F);
            textBox3.Location = new Point(8, 11);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(404, 58);
            textBox3.TabIndex = 0;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 703);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Start";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Panel panel2;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Panel panel3;
        private TextBox textBox3;
    }
}
