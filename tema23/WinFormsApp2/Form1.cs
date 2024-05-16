using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsApp2
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
            double Xmin = double.Parse(textBox2.Text);
            double Xmax = double.Parse(textBox1.Text);
            double Step = double.Parse(textBox3.Text);
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
            double[] x = new double[count];
            double[] y = new double[count];
            for (int i = 0; i < count; i++)
            {
                x[i] = Xmin + Step * i;
                y[i] = Math.Sqrt(x[i]);
            }
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            chart1.Series[0].ChartType = SeriesChartType.Line;

            chart1.Series[0].Points.DataBindXY(x, y);
            chart1.Invalidate();
        }
    }
}
