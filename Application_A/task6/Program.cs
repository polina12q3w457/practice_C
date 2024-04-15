namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= 100 && number <= 999)
            {
                int a = number / 100;
                int bc = number % 100;

                int newNumber = bc * 10 + a;

                Console.WriteLine($"Полученное число: {newNumber}");
            }
            else
            {
                Console.WriteLine("Ошибка: введено не трехзначное число. Пожалуйста, попробуйте еще раз.");
            }
        }
    }
}