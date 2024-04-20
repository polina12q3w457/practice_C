namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[25];
            int[] b = new int[25];

            Random rand = new Random();
            for (int i = 0; i < 25; i++)
            {
                a[i] = rand.Next(1, 60);
                b[i] = rand.Next(1, 60);
            }

            Array.Sort(a);

            Console.WriteLine("Отсортированный массив a: " + string.Join(", ", a));

            Console.Write("Введите число k для поиска: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int index = Array.BinarySearch(a, k);
            if (index < 0)
                Console.WriteLine($"Число {k} не найдено в массиве a.");
            else
                Console.WriteLine($"Число {k} найдено в массиве a.");

            for (int i = 0; i < 25; i++)
            {
                if (a.Contains(b[i]))
                    b[i] *= 10;
                else
                    b[i] = 0;
            }

            Console.WriteLine("Преобразованный массив b: " + string.Join(", ", b));
        }
    }
}