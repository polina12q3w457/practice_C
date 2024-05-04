namespace task1
{
    class Program
    {
        delegate double MyDelegate(double x);

        static double Function1(double x)
        {
            return x * x;
        }

        static double Function2(double x)
        {
            return Math.Sin(x);
        }

        static double Function3(double x)
        {
            if (x == 0)
                throw new DivideByZeroException();
            return 1 / x;
        }

        static void Main()
        {
            MyDelegate[] delegates = { Function1, Function2, Function3 };

            foreach (var del in delegates)
            {
                try
                {
                    Console.WriteLine(del(0.5));
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Произошла ошибка: {e.Message}");
                }
            }
        }
    }
}
