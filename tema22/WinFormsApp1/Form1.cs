using System.Globalization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0,1722";
            textBox2.Text = "6,33";
            textBox3.Text = "3,25E-4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            double y = double.Parse(textBox2.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(textBox3.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            double a = Math.Exp(x - y) * Math.Abs(x + y) / (Math.Atan(x) + Math.Atan(z));
            double b = Math.Sqrt(Math.Pow(y, 6) + Math.Log(y));
            double u = a + b;
            textBox4.Text += Environment.NewLine + "Результат U = " + u.ToString();
        }
    }
}
