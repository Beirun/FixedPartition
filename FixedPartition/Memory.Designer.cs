namespace FixedPartition
{
    partial class Memory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            ProcessID = new DataGridViewTextBoxColumn();
            ProcessSize = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Red;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(477, 53);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 600);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Margin = new Padding(3, 3, 3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(91, 23);
            label1.Name = "label1";
            label1.Size = new Size(63, 50);
            label1.TabIndex = 0;
            label1.Text = "OS 100KB";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(535, 4);
            label3.Name = "label3";
            label3.Size = new Size(146, 46);
            label3.TabIndex = 1;
            label3.Text = "Memory";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.5F);
            label4.Location = new Point(732, 48);
            label4.Name = "label4";
            label4.Size = new Size(34, 17);
            label4.TabIndex = 2;
            label4.Text = "0 KB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(732, 643);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 3;
            label5.Text = "label5";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProcessID, ProcessSize });
            dataGridView1.Location = new Point(44, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.Size = new Size(324, 188);
            dataGridView1.TabIndex = 4;
            dataGridView1.Visible = false;
            // 
            // ProcessID
            // 
            ProcessID.HeaderText = "Process ID";
            ProcessID.MinimumWidth = 6;
            ProcessID.Name = "ProcessID";
            ProcessID.ReadOnly = true;
            ProcessID.Width = 150;
            // 
            // ProcessSize
            // 
            ProcessSize.HeaderText = "ProcessSize";
            ProcessSize.MinimumWidth = 6;
            ProcessSize.Name = "ProcessSize";
            ProcessSize.ReadOnly = true;
            ProcessSize.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F);
            label2.Location = new Point(128, 171);
            label2.Name = "label2";
            label2.Size = new Size(129, 45);
            label2.TabIndex = 5;
            label2.Text = "Waiting";
            label2.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19F);
            label6.Location = new Point(846, 265);
            label6.Name = "label6";
            label6.Size = new Size(345, 45);
            label6.TabIndex = 6;
            label6.Text = "Internal Fragmentation";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(985, 328);
            label7.Name = "label7";
            label7.Size = new Size(64, 35);
            label7.TabIndex = 7;
            label7.Text = "0 KB";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 25F);
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(155, 57);
            label8.TabIndex = 8;
            label8.Text = "0 msec";
            // 
            // Memory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 703);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            Name = "Memory";
            Text = "Memory";
            Load += Memory_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ProcessID;
        private DataGridViewTextBoxColumn ProcessSize;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}