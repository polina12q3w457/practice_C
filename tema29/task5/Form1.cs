namespace task5
{
    public partial class Form1 : Form
    {
        private int rocketSpeed = 5; 
        private bool isRocketLaunching = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isRocketLaunching)
            {
                isRocketLaunching = true;
                Timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= rocketSpeed;
            if (pictureBox1.Top <= 0)
            {
                Timer.Stop();
                isRocketLaunching = false;
            }
        }
    }
}
