namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> Add = (x, y) => x + y;

            Func<double, double, double> Sub = (x, y) => x - y;

            Func<double, double, double> Mul = (x, y) => x * y;

            Func<double, double, double> Div = (x, y) => y != 0 ? x / y : throw new DivideByZeroException();

            Console.WriteLine("Add: " + Add(5, 3));
            Console.WriteLine("Sub: " + Sub(5, 3));
            Console.WriteLine("Mul: " + Mul(5, 3));
            try
            {
                Console.WriteLine("Div: " + Div(5, 0));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
            }
        }
    }
}
