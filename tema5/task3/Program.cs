namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы N (N < 10): ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[N, N];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rand.Next(a, b + 1);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int p = 1;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        p *= matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Произведение нечетных элементов: " + p);

            Console.Write("Введите номер строки k: ");
            int k = Convert.ToInt32(Console.ReadLine()) - 1;
            int sum = 0;
            for (int j = 0; j < N; j++)
            {
                sum += matrix[k, j];
            }
            Console.WriteLine("Сумма элементов " + (k + 1) + "-й строки: " + sum);
        }
    }
}