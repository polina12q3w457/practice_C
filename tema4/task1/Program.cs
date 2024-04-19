namespace task1
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Введите значение x: ");
                double x = Convert.ToDouble(Console.ReadLine());

                double y1 = 1 - 4 / (4 * x + 8);
                Console.WriteLine($"Значение выражения a: {y1}");

                double y2 = Math.Tan(x) * Math.Tan(x) + 1 / (x - 1);
                Console.WriteLine($"Значение выражения b: {y2}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: некорректный формат ввода.");
            }
        }
    }
}