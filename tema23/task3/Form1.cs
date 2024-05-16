namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input1 = textBox1.Text;
            int x = int.Parse(textBox2.Text);
            int y = int.Parse(textBox3.Text);

            Control newControl = null;

            if (input1.Contains("Ê"))
            {
                newControl = new Button { Text = "Dynamic Button", Location = new Point(x, y), BackColor = Color.Aqua };
            }
            else if (input1.Contains("Ï"))
            {
                newControl = new TextBox { Text = "Dynamic TextBox", Location = new Point(x, y), BackColor = Color.LightGreen };
            }
            else if (input1.Contains("Ì"))
            {
                newControl = new Label { Text = "Dynamic Label", Location = new Point(x, y), BackColor = Color.LightPink };
            }

            if (newControl != null)
            {
                newControl.MouseHover += (s, ev) => Controls.Remove(newControl);
                Controls.Add(newControl);
            }
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}