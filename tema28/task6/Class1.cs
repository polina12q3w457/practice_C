using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace task6
{
    class Class1: Control
    {
        protected override void OnRender(DrawingContext drawingContext)
        {
            Pen pen1 = new Pen(Brushes.Black, 2);
            drawingContext.DrawEllipse(Brushes.Transparent, pen1, new Point(100, 50), 60, 60);
            drawingContext.DrawEllipse(Brushes.Transparent, pen1, new Point(102, 52), 50, 50);
            drawingContext.DrawEllipse(Brushes.Transparent, pen1, new Point(104, 54), 40, 40);
        }
    }
}
