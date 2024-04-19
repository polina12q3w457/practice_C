﻿using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task6
{
    internal class Program
    {
        static void genException()
        {
            Console.WriteLine("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            double b = double.Parse(Console.ReadLine());
            int f = 1;
            try
            {
                for (double i = a; i <= b; ++i)
                {
                    try 
                    {
                        f = checked((int)(f * i));
                        if (Math.Abs(f - 1) < 0.000001)
                        {
                            throw new DivideByZeroException();
                        }
                        Console.WriteLine("y({0})={1:f6}", i, 100 / (f - 1));
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("y({0})= Деление на 0 ", i);
                    }
                }
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("ERROR");
                throw; 
            }
        }
        static void Main()
        {
            try
            {
                genException();
            }
            catch
            {
                Console.WriteLine(" НЕИСПРАВИМАЯ ОШИБКА!!!");
            }
        }
    }
}