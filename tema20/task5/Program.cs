namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 43, 16, 92 };
            var loopResult = Parallel.ForEach(array, (int N, ParallelLoopState state) =>
            {
                int sum = 0;
                long product = 1;
                for (int i = 1; i <= N; i++)
                {
                    sum += i;
                    product *= i;
                    if (sum > 1000000 || product > 1000000)
                    {
                        Console.WriteLine($"Выполнение прервано для N={N}. Сумма или произведение превысило 10000.");
                        state.Break();
                        return;
                    }
                }
                Console.WriteLine($"Для N={N}, Сумма={sum}, Произведение={product}");
            });

            if (!loopResult.IsCompleted)
            {
                Console.WriteLine("Параллельный цикл был преждевременно остановлен.");
            }

            Console.ReadLine();
        }
    }
}
