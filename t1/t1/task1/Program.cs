namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y;

            if (x >= 4 && x <= 6)
            {
                y = x;
            }
            else if (x > 6)
            {
                y = 3 * x + 4 * Math.Pow(x, 2);
            }
            else
            {
                Console.WriteLine("Значение x вне допустимого диапазона.");
                return;
            }

            Console.WriteLine($"Значение y для данного x равно: {y}");
        }
    }
}