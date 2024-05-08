namespace ClassLibrary1
{
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    public class Triangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double GetArea()
        {
            double semiPerimeter = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3));
        }

        public override double GetPerimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public string GetTriangleType()
        {
            if (Side1 == Side2 && Side2 == Side3)
            {
                return "Equilateral";
            }
            else if (Side1 == Side2 || Side1 == Side3 || Side2 == Side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }

    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }

        public override double GetPerimeter()
        {
            return 2 * (Length + Width);
        }
    }
}

