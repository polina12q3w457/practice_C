using System.Numerics;

namespace task4
{
    public partial class Form1 : Form
    {
        System.Drawing.Bitmap sky, plane;
        Graphics g; 
        int dx;
        Rectangle rct;
        Boolean demo = true;
        System.Random rnd;
        public Form1()
        {
            InitializeComponent();
            try
            {
                  sky = new Bitmap("sky.bmp");	 
                  plane = new Bitmap("plane.bmp"); 
                  this.BackgroundImage = new Bitmap("sky.bmp");
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(),
                    "�����",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.Close(); 
                return;
            }
            plane.MakeTransparent();
            this.ClientSize =
                new System.Drawing.Size(
                    new Point(BackgroundImage.Width,
                    BackgroundImage.Height));
            this.FormBorderStyle =
                 System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            g = Graphics.FromImage(BackgroundImage);
            rnd = new System.Random();
            rct.X = -40;
            rct.Y = 20 + rnd.Next(20);

            rct.Width = plane.Width;
            rct.Height = plane.Height;

            dx = 2;		

            timer2.Interval = 20;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            g.DrawImage(sky, new Point(0, 0));
            if (rct.X < this.ClientRectangle.Width)
                rct.X += dx;
            else
            {
                rct.X = -40;
                rct.Y = 20 +
                    rnd.Next(this.ClientSize.Height - 40 - plane.Height);
                dx = 2 + rnd.Next(4);
            }
            g.DrawImage(plane, rct.X, rct.Y);
            if (!demo)
                this.Invalidate(rct);
            else
            {
                Rectangle reg =
                     new Rectangle(20, 20,
                           sky.Width - 40, sky.Height - 40);
                g.DrawRectangle(Pens.Black,
                    reg.X, reg.Y, reg.Width - 1, reg.Height - 1);

                this.Invalidate(reg); 
            }
        }
    }
}
