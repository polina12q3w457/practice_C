using System;

namespace task8
{
    public partial class Form1 : Form
    {
        private int[] A = new int[30];
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.Next(1, 70);
            }

            textBox1.Text = string.Join(", ", A);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var filteredNumbers = A.Where(x => x % 5 == 0 && x % 7 != 0).ToList();
            int count = filteredNumbers.Count;
            int sum = filteredNumbers.Sum();

            textBox2.Text = $"Количество: {count} Сумма: {sum}";
        }
    }
}
