namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox1.Text);
            double f_x = Convert.ToDouble(textBox3.Text); 
            textBox4.Text += "При X = " + textBox2.Text + Environment.NewLine;
            textBox4.Text += "При B = " + textBox1.Text + Environment.NewLine;
            textBox4.Text += "При F(X) = " + textBox3.Text + Environment.NewLine;
            double s;
            if (x <= b / 10)
            {
                s = Math.Exp(f_x);
            }
            else if (12 < x && x <= b / 40)
            {
                s = Math.Sqrt(f_x + 4 * b);
            }
            else
            {
                s = b / (f_x * f_x);
            }
            textBox4.Text += "S = " + s.ToString() + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
        }
    }
}
