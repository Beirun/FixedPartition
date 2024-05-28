namespace FixedPartition
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int memory = 0;
            int process = 0;
            int blockSize = 0;
            try
            {
                memory = Convert.ToInt32(textBox1.Text);
                process = Convert.ToInt32(textBox2.Text);
                blockSize = Convert.ToInt32(textBox3.Text);
            }
            catch (Exception ex)
            {
                if (memory == 0) textBox1.ForeColor = Color.Red;
                if (process == 0) textBox2.ForeColor = Color.Red;
                if (blockSize == 0) textBox3.ForeColor = Color.Red;
                return;
            }
            if (memory < 100) {textBox1.ForeColor = Color.Red; return; }
            if (process < 0){ textBox2.ForeColor = Color.Red; return; }
            if(blockSize < 0 && blockSize> memory) { textBox3.ForeColor = Color.Red; return; }
            Table table = new Table(memory, process, blockSize);

            table.Visible = true;
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = SystemColors.WindowText;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = SystemColors.WindowText;
        }
    }
}
