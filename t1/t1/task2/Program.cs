namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 100 || number > 999)
            {
                Console.WriteLine("Введенное число не является трехзначным.");
                return;
            }

            int s1 = number / 100;
            int s2 = (number / 10) % 10;
            int s3 = number % 10;

            if (s1 == s2 && s2 == s3)
            {
                Console.WriteLine("Все цифры числа одинаковы.");
            }
            else
            {
                Console.WriteLine("Цифры числа не одинаковы.");
            }
        }
    }
}