namespace task9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void spWin_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows is cascade";
        }

        private void spData_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows is horizontal";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
