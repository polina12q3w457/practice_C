namespace task2
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                Console.Write("Введите вещественное число x: ");
                string input = Console.ReadLine();
                double x = double.Parse(input);

                if (x <= 0 || x > 3)
                {
                    throw new ArgumentOutOfRangeException("x", "Значение x должно быть в диапазоне (0, 3].");
                }

                double f;
                if (x < 1)
                {
                    f = x - 4;
                }
                else
                {
                    if (2 * x - 2 == 0)
                    {
                        throw new DivideByZeroException("Знаменатель равен нулю.");
                    }
                    f = x / (2 * x - 2);
                }

                Console.WriteLine($"Значение функции f: {f}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введенное значение не является вещественным числом.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}