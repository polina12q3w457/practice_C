namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 5;
            int B = 15;
            Parallel.For(A, B + 1, i =>
            {
                double result = CalculateFunction(i);
                Console.WriteLine($"Arccos({i}) = {result}");
            });
        }
        static double CalculateFunction(int x)
        {
            if (x >= -5 && x <= 20)
            {
                return Math.Acos(x);
            }
            else
            {
                throw new ArgumentException("Значение x должно быть в диапазоне [-5, 20] для функции Arccos.");
            }
        }
    }
}
