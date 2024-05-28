using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixedPartition
{
    public partial class Memory : Form
    {
        int memory;
        int blockSize;
        int remainder;
        int internalFragmentation = 0;
        int seconds = 0;
        bool[] hasEntered;
        bool[] isEntered;
        int[] pSize;
        int[] allocation;
        int[] completion;
        int stopsec;
        int numberPanels;
        Panel[] panels;
        Label[] labels;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Memory(int memory, int blockSize, int[] pSize, int[] allocation, int[] completion)
        {
            InitializeComponent();
            this.memory = memory;
            this.blockSize = blockSize;
            this.pSize = pSize;
            this.allocation = allocation;
            this.completion = completion;
            osPanel();
            blocks();

        }
        public void osPanel()
        {
            panel1.Height = (600 * 97) / memory;
            label5.Text = memory + " KB";
            label1.Location = new Point(panel1.Width / 2 - label1.Width / 2, panel1.Height / 2 - label1.Height / 2);
            label5.Font = label4.Font;

        }
        public void blocks()
        {
            numberPanels = (memory-100) / blockSize;
            remainder = (memory - 100) % blockSize;
            panels = new Panel[numberPanels];
            isEntered = new bool[numberPanels];
            hasEntered = new bool[pSize.Length];
            labels = new Label[numberPanels];
            for(int i = 0; i < panels.Length; i++)
            {
                Panel panel = panels[i] = new Panel();
                Label label = labels[i] = new Label();
                panel.BackColor = Color.Gray;
                label.Font = label4.Font;
                panel.Size = new Size(panel1.Width, (600 * (blockSize - 6)) / memory);
                panel.Margin = new Padding(3, 3, 3, 0);
                if(i == panels.Length - 1) panel.Size = new Size(panel1.Width, (600 * (blockSize + remainder -( 6 +(remainder > 0 ? 3:0)))) / memory);
                flowLayoutPanel1.Controls.Add(panel);
                label.Text = (100 + (i*blockSize)) + " KB";
                label.Location = new Point(label4.Left, label4.Top + panel1.Height+3);
                if (i != 0) label.Top = labels[i-1].Top + panels[i-1].Height+3;
                Controls.Add(label);
            }
            for (int i = 0; i < pSize.Length; i++) if (completion[i] > stopsec) stopsec = completion[i];
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (seconds > stopsec) 
            {
                label7.Text = internalFragmentation + " KB";
                label7.Visible = true;
                label6.Visible = true;
                label7.Location = new Point( label6.Left + label6.Width / 2 - label7.Width / 2, label7.Top);

                timer.Stop(); 
            }
            label8.Text = seconds + " msec";
            for (int i = 0; i < pSize.Length; i++){

                if (allocation[i] == seconds && !hasEntered[i] && (pSize[i] > blockSize && (pSize[i] > blockSize + remainder && !isEntered[numberPanels - 1])))
                {
                    label2.Visible = true;
                    dataGridView1.Visible = true;
                    dataGridView1.Rows.Add("P" + (i + 1), pSize[i]);
                    hasEntered[i] = true;
                    continue;
                }
                if (allocation[i]==seconds && !hasEntered[i])
                {
                    
                    for (int j = 0; j < numberPanels; j++)
                    {
                        if (!isEntered[j] && (pSize[i] <= blockSize || (j== numberPanels-1 && pSize[i]<=blockSize+remainder)))
                        {
                            hasEntered[i] = true;
                            isEntered[j] = true;
                            Panel panel = new Panel();
                            panel.BackColor = Color.Blue;
                            panel.Size = new Size(panels[j].Width, (600 * (pSize[i] - 6)) / memory);
                            panel.Margin = new Padding(0, 0, 0, 0);
                            panels[j].Controls.Add(panel);


                            Label label1 = new Label();
                            label1.Text = "P" + (i + 1);
                            label1.Size = TextRenderer.MeasureText(label1.Text, label1.Font);
                            label1.Location = new Point(panel.Width/2 - label1.Width/2, panel.Height/2 - label1.Height);
                            Label label2 = new Label();
                            label2.Text = pSize[i] + " KB";
                            label2.Size = TextRenderer.MeasureText(label2.Text, label2.Font);
                            label2.Location = new Point(panel.Width / 2 - label2.Width / 2, label1.Top + label1.Height+2);

                            panel.Controls.Add(label1);
                            panel.Controls.Add(label2);

                            internalFragmentation += pSize[i] > blockSize ? blockSize+remainder - pSize[i] : blockSize - pSize[i];

                            if (pSize[i] != blockSize)
                            {
                                Label label = new Label();
                                label.Text = (Convert.ToInt32(labels[j].Text.Substring(0, labels[j].Text.Length - 3)) + pSize[i]) + " KB";
                                label.Font = label4.Font;
                                label.Location = new Point(labels[j].Left - flowLayoutPanel1.Width - label.Width/2 - 2, labels[j].Top + panel.Height);
                                Controls.Add(label);
                            }
                            break;
                        }
                    }
                    

                }
            }
            seconds++;
        }

        private void Memory_Load(object sender, EventArgs e)
        {
        }
    }
}
