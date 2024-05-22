using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace task5
{
    class TestDrawing : Control
    {
        protected override void OnRender(DrawingContext drawingContext)
        {
            Point p1 = new Point(50, 50);
            Point p2 = new Point(100, 100);
            Point p3 = new Point(150, 50);

            Pen pen = new Pen(Brushes.Black, 2);
            drawingContext.DrawLine(pen, p1, p2);
            drawingContext.DrawLine(pen, p2, p3);
            drawingContext.DrawLine(pen, p3, p1);

           
            Pen pen1 = new Pen(Brushes.Black, 2);
            drawingContext.DrawEllipse(Brushes.Blue, pen1, new Point(100,50), 100, 60);

            drawingContext.DrawEllipse(Brushes.Green, null, new Point(350, 50), 60,60);

            Rect rect = new Rect(new Point(50, 100), new Size(100, 80));
            drawingContext.DrawRectangle(Brushes.Red, null, rect);

            Point center = new Point(150, 200);
            double radius = 50;
            double startAngle = 30; 
            double endAngle = 120; 

            StreamGeometry sectorGeometry = new StreamGeometry();
            using (StreamGeometryContext context = sectorGeometry.Open())
            {
                context.BeginFigure(center, true, true);
                context.ArcTo(center, new Size(radius, radius), startAngle, false, SweepDirection.Clockwise, true, true);
                context.LineTo(center, true, true);
            }

            Pen pen2 = new Pen(Brushes.Orange, 2);
            drawingContext.DrawGeometry(Brushes.Yellow, pen2, sectorGeometry);
        }
    }
}
