using System.Globalization;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double X0 = Convert.ToDouble(textBox1.Text);
            double Xk = Convert.ToDouble(textBox2.Text);
            double Dx = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);
            double x = X0;
            while (x <= (Xk + Dx / 2))
            {
                double y = 9 * (x + 15 * Math.Sqrt(x) + Math.Pow(b, 3));
                textBox5.Text += "x=" + Convert.ToString(x) + "; y=" + Convert.ToString(y) +
                Environment.NewLine;

                x = x + Dx;
            }
        }
    }
}
