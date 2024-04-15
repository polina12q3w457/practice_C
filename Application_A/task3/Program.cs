namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 2;
            double y = Math.Tan(Math.Log(Math.Pow(Math.E, x + 1))) / ((3 + Math.Sin(Math.Pow(x, 2))) / (Math.Sin(Math.Pow(x, 2)) - Math.Cos(Math.Pow(x, 2))));
            Console.WriteLine($"Значение функции: {y}");
        }
    }
}