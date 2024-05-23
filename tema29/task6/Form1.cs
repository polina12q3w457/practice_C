using System.Windows.Forms;

namespace task6
{
    public partial class Form1 : Form
    {
        private Pen myPen = new Pen(Color.Red, 5);
        private float x2 = 175;
        private float y2 = 50;
        private int fi = -90;
        private int r = 125;
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            timer1.Interval = 1000; 
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(myPen, 50, 50, 250, 250); 
            e.Graphics.DrawLine(myPen, 175, 175, x2, y2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fi += 6; 
            float cosFi = (float)Math.Cos((Math.PI * fi) / 180);
            float sinFi = (float)Math.Sin((Math.PI * fi) / 180);
            x2 = 175 + r * cosFi; 
            y2 = 175 + r * sinFi;
            this.Invalidate();
        }
    }
}
