namespace task2
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

        static void ExecuteDelegate(MyDelegate del, double value)
        {
            try
            {
                Console.WriteLine(del(value));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Произошла ошибка: {e.Message}");
            }
        }

        static void Main()
        {
            MyDelegate[] delegates = { Function1, Function2, Function3 };

            foreach (var del in delegates)
            {
                ExecuteDelegate(del, 0.5);
            }
        }
    }
}

