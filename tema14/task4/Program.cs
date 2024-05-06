using System.Linq;
using System.Threading;
namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Enumerable.Range(0, 100).ToArray(); // Замените этот массив на вашу последовательность чисел
            int threadCount = 4; // Замените это на количество потоков, которые вы хотите создать

            int chunkSize = numbers.Length / threadCount;
            int[] sums = new int[threadCount];
            Thread[] threads = new Thread[threadCount];

            for (int i = 0; i < threadCount; i++)
            {
                int threadIndex = i;
                threads[i] = new Thread(() =>
                {
                    int start = threadIndex * chunkSize;
                    int end = (threadIndex == threadCount - 1) ? numbers.Length : start + chunkSize;
                    for (int j = start; j < end; j++)
                    {
                        if (numbers[j] % 2 == 0)
                        {
                            sums[threadIndex] += numbers[j];
                        }
                    }
                });
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            int totalSum = sums.Sum();
            Console.WriteLine("Общая сумма четных чисел: " + totalSum);
        }
    }
}

