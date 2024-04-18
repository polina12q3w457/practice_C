namespace task4
{
    class Program
    {
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

        static long SumFor(int a)
        {
            return (long)a * (a + 1) / 2;
        }

        static long SumFor(int a, int b)
        {
            return SumFor(b) - SumFor(a - 1);
        }
    }
}