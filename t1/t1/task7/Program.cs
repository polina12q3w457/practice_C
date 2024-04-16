namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string number = Console.ReadLine();

            bool isAscending = true;
            for (int i = 0; i < number.Length - 1; i++)
            {
                if (number[i] < number[i + 1])
                {
                    isAscending = false;
                    break;
                }
            }

            if (isAscending)
            {
                Console.WriteLine("Цифры числа упорядочены по возрастанию справа налево.");
            }
            else
            {
                Console.WriteLine("Цифры числа не упорядочены по возрастанию справа налево.");
            }
        }
    }
}