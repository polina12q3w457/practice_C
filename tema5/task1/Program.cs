namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 6, 7, 2, 5, 9, 33, 12 };
            int sum = 0;
            foreach (int number in array)
            {
                if (number % 3 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine($"Сумма чисел кратных трём = {sum}" );
        }
    }
}