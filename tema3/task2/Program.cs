namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число K: ");
            int K = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите цифру D1: ");
            int D1 = Convert.ToInt32(Console.ReadLine());
            AddRightDigit(D1, ref K);
            Console.WriteLine($"Результат после добавления D1: {K}");

            Console.Write("Введите цифру D2: ");
            int D2 = Convert.ToInt32(Console.ReadLine());
            AddRightDigit(D2, ref K);
            Console.WriteLine($"Результат после добавления D2: {K}");
        }

        static void AddRightDigit(int D, ref int K)
        {
            if (D >= 0 && D <= 9)
            {
                K = K * 10 + D;
            }
            else
            {
                Console.WriteLine("Цифра D должна быть в диапазоне от 0 до 9.");
            }
        }
    }
}