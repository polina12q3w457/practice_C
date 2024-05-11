namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task1 = Task.Run(() => CalculateNewNumber(046)); 
            Task task2 = task1.ContinueWith(task => Console.WriteLine($"Полученное число: {task.Result}"));
            Task.WaitAll(task1, task2);
        }
        static int CalculateNewNumber(int number)
        {
            int firstDigit = number / 100;
            int lastTwoDigits = number % 100;
            return lastTwoDigits * 10 + firstDigit;
        }
    }
}
