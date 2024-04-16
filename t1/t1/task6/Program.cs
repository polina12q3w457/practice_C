namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 0.5; 
            double B = 1.0; 
            int M = 10;     

            double H = (B - A) / M; 

            Console.WriteLine("x\tF(x)");

            for (int i = 0; i <= M; i++)
            {
                double x = A + H * i;
                double Fx;

                if (x >= -1 && x <= 1)
                {
                    Fx = Math.Acos(x);
                    Console.WriteLine($"{x}\t{Fx}");
                }
                else
                {
                    Console.WriteLine($"Значение {x} выходит за область определения функции арккосинуса.");
                    continue;
                }
            }
        }
    }
}