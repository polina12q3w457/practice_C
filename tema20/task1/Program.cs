namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task1 = new Task<int>(() => MultiplyDigits(123));
            Task<int> task2 = Task.Factory.StartNew(() => MultiplyDigits(123));
            Task<int> task3 = Task.Run(() => MultiplyDigits(123));

            task1.Start();
            Task.WhenAll(task1, task2, task3).Wait();
            Console.WriteLine($"Результат задачи 1: {task1.Result}");
            Console.WriteLine($"Результат задачи 2: {task2.Result}");
            Console.WriteLine($"Результат задачи 3: {task3.Result}");
        }
        static int MultiplyDigits(int number)
        {
            int product = 1;
            while (number > 0)
            {
                product *= number % 10;
                number /= 10;
            }
            return product;
        }
    }
}
