namespace task4
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            Console.Write("Введите a1: ");
            int a1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите a2: ");
            int a2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите b2: ");
            int b2 = Convert.ToInt32(Console.ReadLine());

            long result = SumFor(a1) * SumFor(a2, b2);
            Console.WriteLine($"Результат: {result}");
        }

        /// <summary>
        /// Вычисляет сумму чисел от 1 до a.
        /// </summary>
        /// <param name="a">Конечное число диапазона.</param>
        /// <returns>Сумма чисел от 1 до a.</returns>
        static long SumFor(int a)
        {
            return (long)a * (a + 1) / 2;
        }

        /// <summary>
        /// Вычисляет сумму чисел от a до b.
        /// </summary>
        /// <param name="a">Начальное число диапазона.</param>
        /// <param name="b">Конечное число диапазона.</param>
        /// <returns>Сумма чисел от a до b.</returns>
        static long SumFor(int a, int b)
        {
            return SumFor(b) - SumFor(a - 1);
        }
    }
}

