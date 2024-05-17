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
            // Создаем объекты Pen и SolidBrush с различными цветами и стилями
            Pen blackPen = new Pen(Color.Black, 3);
            Pen dashedPen = new Pen(Color.Blue, 2) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
            SolidBrush redBrush = new SolidBrush(Color.Red);

            // Рисуем контур стула
            g.DrawRectangle(blackPen, 50, 100, 100, 100); // основание стула
            g.DrawRectangle(blackPen, 60, 40, 80, 100); // спинка стула

            // Рисуем ножки стула
            g.DrawLine(dashedPen, 50, 200, 50, 300); // нижняя левая ножка
            g.DrawLine(dashedPen, 150, 200, 150, 300); // нижняя правая ножка

            // Закрашиваем основание стула
            g.FillRectangle(redBrush, 51, 101, 99, 99);

            // Освобождаем ресурсы
            blackPen.Dispose();
            dashedPen.Dispose();
            redBrush.Dispose();
        }
    }
}
