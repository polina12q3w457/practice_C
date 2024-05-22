namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point[] points = { new Point(50, 50), new Point(100, 100), new Point(150, 50) };
            g.DrawPolygon(Pens.Black, points);
            g.DrawEllipse(Pens.Black, 100, 100, 100, 60);
            g.FillRectangle(Brushes.Green, 150, 170, 100, 80);
            g.FillPie(Brushes.Red, 200, 200, 100, 100, 0, 90);
        }
    }
}
