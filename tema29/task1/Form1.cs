namespace task1
{
    public partial class Form1 : Form
    {
        private int x1, y1, x2, y2, r;
        private double a;
        private Pen pen = new Pen(Color.DarkRed, 2);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(pen, x1, y1, x2, y2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            r = 150;
            a = 0;
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            UpdateArrowPosition();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a -= 0.01; 
            UpdateArrowPosition();
            Invalidate();
        }

        private void UpdateArrowPosition()
        {
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
        }
    }
}
