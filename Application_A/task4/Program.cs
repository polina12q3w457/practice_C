namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите коэффициент a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите коэффициент b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите коэффициент c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double x = -b / (2 * a);
            double y = c - (b * b) / (4 * a);

            Console.WriteLine($"Координаты вершины параболы: ({x}, {y})");
        }
    }
}