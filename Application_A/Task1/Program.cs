namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Введите целое число.");
                Console.Write("a= ");
            }

            Console.Write("b= ");
            int b;
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Введите целое число.");
                Console.Write("b= ");
            }

            int product = a * b;

            Console.WriteLine($"{a}*{b}= {product}");
        }
    }
}