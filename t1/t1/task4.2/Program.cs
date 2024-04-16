namespace task4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            int i = B;
            while (i >= A)
            {
                Console.WriteLine(Math.Pow(i, 3));
                i--;
            }
        }
    }
}