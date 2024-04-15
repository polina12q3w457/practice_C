namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            string input = Console.ReadLine();

            int number;
            if (!Int32.TryParse(input, out number))
            {
                Console.WriteLine("Введенное значение не является числом.");
            }
            else if (number < 100 || number > 999)
            {
                Console.WriteLine("Введенное число не является трехзначным.");
            }
            else
            {
                int firstDigit = number / 100;
                int secondDigit = (number / 10) % 10;
                int thirdDigit = number % 10;

                int product = firstDigit * secondDigit * thirdDigit;

                Console.WriteLine($"Произведение цифр числа: {product}");
            }
        }
    }
}