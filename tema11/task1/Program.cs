﻿namespace task1
{
    using System;

    public class Vector
    {
        public string Name { get; set; }

        public Vector(string name)
        {
            Name = name;
        }

        public virtual void DisplayResults()
        {
            Console.WriteLine($"Название: {Name}");
        }

        public virtual double Length()
        {
            return 0;
        }
    }

    public class TwoDimensionalVector : Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public TwoDimensionalVector(string name, double x, double y) : base(name)
        {
            X = x;
            Y = y;
        }

        public override void DisplayResults()
        {
            base.DisplayResults();
            Console.WriteLine($"Компоненты вектора: X = {X}, Y = {Y}");
        }

        public override double Length()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }

    public class ThreeDimensionalVector : Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public ThreeDimensionalVector(string name, double x, double y, double z) : base(name)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override void DisplayResults()
        {
            base.DisplayResults();
            Console.WriteLine($"Компоненты вектора: X = {X}, Y = {Y}, Z = {Z}");
        }

        public override double Length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector[] vectors = new Vector[5]
            {
            new Vector("Вектор1"),
            new TwoDimensionalVector("2DВектор1", 3, 4),
            new ThreeDimensionalVector("3DВектор1", 3, 4, 5),
            new TwoDimensionalVector("2DВектор2", 5, 12),
            new ThreeDimensionalVector("3DВектор2", 5, 12, 13)
            };

            foreach (var vector in vectors)
            {
                vector.DisplayResults();
                Console.WriteLine($"Длина вектора: {vector.Length()}\n");
            }

            Console.ReadKey();
        }
    }
}
