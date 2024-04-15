namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 5; 

            double numerator1 = Math.Pow(x, 2) + 2 * x - 3 + (x + 1) * Math.Sqrt(Math.Pow(x, 2) - 9);
            double denominator1 = Math.Pow(x, 2) - 2 * x - 3 + (x - 1) * Math.Sqrt(Math.Pow(x, 2) - 9);
            double z1 = numerator1 / denominator1;

            double z2 = (x + 3) / (Math.Sqrt(x - 3));

            Console.WriteLine($"Для x={x}:");
            Console.WriteLine($"z1={z1}");
            Console.WriteLine($"z2={z2}");
        }
    }
}