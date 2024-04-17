namespace task1
{
    public class A
    {
        public int a { get; set; }
        public int b { get; set; }

        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public double CalculateExpression()
        {
            return 1 / (1 + (double)(a + b) / 2);
        }

        public int SquareDifference()
        {
            return (a - b) * (a - b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A(5, 3);
            Console.WriteLine("Вычисление выражения: " + obj.CalculateExpression());
            Console.WriteLine("Возведение в квадрат разности: " + obj.SquareDifference());
        }
    }
}