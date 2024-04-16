namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int i = A; i <= B; i++)
            {
                Console.WriteLine(i);
                count++;
            }

            Console.WriteLine("Количество чисел: " + count);
        }
    }
}