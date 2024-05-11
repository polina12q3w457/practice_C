namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<double>[] tasks = new Task<double>[2];
            tasks[0] = Task.Run(() => CalculateFunction1(2, 5)); 
            tasks[1] = Task.Run(() => CalculateFunction2(4));  
            Task.WaitAll(tasks);
            Console.WriteLine($"Значение функции 1: {tasks[0].Result}");
            Console.WriteLine($"Значение функции 2: {tasks[1].Result}");
            int taskIndex = Task.WaitAny(tasks);
            Console.WriteLine($"Первая завершенная задача: {taskIndex + 1}, ее значение: {tasks[taskIndex].Result}");
        }

        static double CalculateFunction1(double x, double a)
        {
            Thread.Sleep(1000);  
            return (Math.Sqrt(2 * x + 2) - Math.Pow(x, 3) - a) / (Math.Sqrt(Math.Pow(x, 3)) - x + 2);
        }

        static double CalculateFunction2(double b)
        {
            Thread.Sleep(2000);  
            return 1 / Math.Sqrt(b + 2);
        }
    }
}
