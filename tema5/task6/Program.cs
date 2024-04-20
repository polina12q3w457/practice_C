namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double result = Factorial(n - 1) / Factorial(n);
            Console.WriteLine($"f({n}) = {result}");
        }

        static double Factorial(int number)
        {
            if (number <= 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }
    }
}
