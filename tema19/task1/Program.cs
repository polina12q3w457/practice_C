namespace task1
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение h: ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n x \t y");
            for (double x = a; x <= b; x += h)
            {
                double y = Function(x, a, b);
                Console.WriteLine($"{x} \t {y}");
            }
        }

        /// <summary>
        /// Функция для вычисления значения по заданной формуле.
        /// </summary>
        /// <param name="x">Значение x.</param>
        /// <param name="a">Значение a.</param>
        /// <param name="b">Значение b.</param>
        /// <returns>Возвращает результат вычисления формулы.</returns>
        static double Function(double x, double a, double b)
        {
            if (2 * x <= -5)
            {
                return Math.Pow(Math.Cos(2 + x), 2) / a;
            }
            else if (-5 <= 2 * x && 2 * x <= 0)
            {
                return Math.Pow(b * x, 2) - a;
            }
            else // 0 < 2 * x
            {
                return (5 * Math.Pow(x, 2) + a * x) / Math.Pow(x, 3);
            }
        }
    }
}
