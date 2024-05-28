namespace FixedPartition
{
    partial class Table
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Process = new DataGridViewTextBoxColumn();
            ProcessSize = new DataGridViewTextBoxColumn();
            AllocationTime = new DataGridViewTextBoxColumn();
            CompletionTime = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Process, ProcessSize, AllocationTime, CompletionTime });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.Location = new Point(120, 117);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 15F);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.Height = 45;
            dataGridView1.Size = new Size(1025, 450);
            dataGridView1.TabIndex = 0;
            // 
            // Process
            // 
            Process.HeaderText = "Process";
            Process.MinimumWidth = 6;
            Process.Name = "Process";
            Process.Width = 250;
            // 
            // ProcessSize
            // 
            ProcessSize.HeaderText = "ProcessSize";
            ProcessSize.MinimumWidth = 6;
            ProcessSize.Name = "ProcessSize";
            ProcessSize.Width = 250;
            // 
            // AllocationTime
            // 
            AllocationTime.HeaderText = "AllocationTime";
            AllocationTime.MinimumWidth = 6;
            AllocationTime.Name = "AllocationTime";
            AllocationTime.Width = 250;
            // 
            // CompletionTime
            // 
            CompletionTime.HeaderText = "CompletionTime";
            CompletionTime.MinimumWidth = 6;
            CompletionTime.Name = "CompletionTime";
            CompletionTime.Width = 250;
            // 
            // button1
            // 
            button1.Location = new Point(562, 622);
            button1.Name = "button1";
            button1.Size = new Size(131, 42);
            button1.TabIndex = 1;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(516, 38);
            label1.Name = "label1";
            label1.Size = new Size(202, 46);
            label1.TabIndex = 2;
            label1.Text = "Enter Values";
            // 
            // Table
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 703);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Table";
            Text = "Table";
            Load += Table_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Process;
        private DataGridViewTextBoxColumn ProcessSize;
        private DataGridViewTextBoxColumn AllocationTime;
        private DataGridViewTextBoxColumn CompletionTime;
        private Button button1;
        private Label label1;
    }
}