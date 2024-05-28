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
    public partial class Table : Form
    {
        int memory, process, blockSize;
        public Table(int memory, int process, int blockSize)
        {
            InitializeComponent();
            this.memory = memory;
            this.process = process;
            this.blockSize = blockSize;
            setTable(process);
        }
        public void setTable(int number)
        {
            for (int i = 0; i < number; i++)
            {
                dataGridView1.Rows.Add("P" + (i + 1));
            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView1.Columns[0].ReadOnly = true;
            this.dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(DataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellDirtyStateChanged += new EventHandler(DataGridView1_CurrentCellDirtyStateChanged);

        }
        private void DataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = SystemColors.WindowText;
            }
        }
        private void Table_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            int[] pSize = new int[dataGridView1.Rows.Count];
            int[] allocation = new int[dataGridView1.Rows.Count];
            int[] completion = new int[dataGridView1.Rows.Count];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!dataGridView1.Rows[i].IsNewRow)
                {
                    try
                    {
                        pSize[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                        allocation[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                        completion[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                        if (pSize[i] == 0 || completion[i] < allocation[i]) dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                    catch { dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red; }
                }
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].DefaultCellStyle.ForeColor == Color.Red) return;
            }
            Memory memory = new Memory(this.memory, blockSize, pSize, allocation, completion);
            this.Hide();
            memory.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
