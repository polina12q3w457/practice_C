using System.Threading;
namespace task3
{
    class Program
    {
        static Mutex mutex = new Mutex();
        static void Main(string[] args)
        {
            Console.Write("Введите значение A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Thread thread1 = new Thread(() => Method1(A, N));
            Thread thread2 = new Thread(() => Method1(A, N));
            Thread thread3 = new Thread(() => Method2(A, N));

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();
        }

        static void Method1(int A, int N)
        {
            int result = 0;
            for (int i = 1; i <= N; i++)
            {
                result += A + i;
            }
            Console.WriteLine("Результат первого метода: " + result);
        }

        static void Method2(int A, int N)
        {
            mutex.WaitOne();
            int result = 1;
            for (int i = 1; i <= N; i++)
            {
                result *= A * i;
            }
            Console.WriteLine("Результат второго метода: " + result);
            mutex.ReleaseMutex();
        }
    }
}

