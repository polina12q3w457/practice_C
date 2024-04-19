﻿namespace task4
{
    internal class Program
    {
        static void Main()
        {
            byte x = 200; byte y = 200;
            try
            {
                byte result = (byte)(x + y);
                Console.WriteLine("1: {0}", result);
                result = checked((byte)(x + y));
                Console.WriteLine("2:", result);
            }
            catch (OverflowException)
            {
                Console.WriteLine("возникло переполнение");
            }
        }
    }
}
