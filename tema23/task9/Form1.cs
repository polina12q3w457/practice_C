namespace task9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3; 
            dataGridView1.ColumnCount = 4;  
            int[,] a = new int[3, 4]; 
            int i, j; 
            Random rand = new Random();
            for (i = 0; i < 3; i++)
                for (j = 0; j < 4; j++)
                    a[i, j] = rand.Next(-100, 100);
            for (i = 0; i < 3; i++)
                for (j = 0; j < 4; j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
            int count = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (a[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            textBox1.Text = Convert.ToString(count);
        }
    }
}
