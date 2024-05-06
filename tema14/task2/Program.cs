using System.Diagnostics;
using System.Threading;
namespace task2
{
    class Program
    {
        static void Main()
        {
            Thread t1 = new Thread(SumNumbers);
            Thread t2 = new Thread(SumNumbers);

            Stopwatch stopwatch1 = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();

            stopwatch1.Start();
            t1.Start();
            t1.Join();
            stopwatch1.Stop();

            stopwatch2.Start();
            t2.Start();
            t2.Join();
            stopwatch2.Stop();

            Console.WriteLine($"Время выполнения первого потока: {stopwatch1.ElapsedMilliseconds} мс");
            Console.WriteLine($"Время выполнения второго потока: {stopwatch2.ElapsedMilliseconds} мс");
        }

        static void SumNumbers()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Сумма чисел от 1 до 10: {sum}");
        }
    }
}
