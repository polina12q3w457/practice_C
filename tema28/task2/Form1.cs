namespace task2
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
            g.DrawEllipse(Pens.Black, 150, 150, 150, 150);
            g.DrawEllipse(Pens.Black, 160, 160, 130, 130);
            g.DrawEllipse(Pens.Black, 170, 170, 110, 110);
        }
    }
}
