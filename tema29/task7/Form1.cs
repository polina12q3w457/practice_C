namespace task7
{
    public partial class Form1 : Form
    {
        private float centerX; 
        private float centerY; 
        private float radius = 50; 
        private float amplitude = 100; 
        private float frequency = 0.02f; 
        private float time = 0;
        public Form1()
        {
            InitializeComponent();
            centerX = ClientSize.Width / 2;
            centerY = ClientSize.Height / 2;
            timer1.Interval = 20; 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 0.1f; 
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            float x = centerX + radius * (float)Math.Cos(frequency * time);
            float y = centerY + amplitude * (float)Math.Sin(frequency * time);
            e.Graphics.FillEllipse(Brushes.Blue, x - radius, y - radius, 2 * radius, 2 * radius);
        }
    }
}
