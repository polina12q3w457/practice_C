namespace task3
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
            g.DrawRectangle(Pens.Black, 50, 50, 70, 80);
            g.DrawRectangle(Pens.Black, 90, 90, 70, 80);
            g.DrawRectangle(Pens.Black, 130, 130, 70, 80);
            g.DrawRectangle(Pens.Black, 170, 170, 70, 80);
            g.DrawRectangle(Pens.Black, 210, 210, 70, 80);
        }
    }
}
