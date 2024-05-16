namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            foreach (var item in listBox1.Items)
            {
                string line = item.ToString();
                foreach (char c in line)
                {
                    if (c >= 'à' && c <= 'ÿ')
                    {
                        result += c;
                    }
                }
            }
            label1.Text = result;
        }
    }
}
