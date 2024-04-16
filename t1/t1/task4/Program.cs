namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            for (int i = B; i >= A; i--)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
        }
    }
}