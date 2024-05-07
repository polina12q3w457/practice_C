using System.IO;
using System.Linq;
namespace task1
{
    class Program
    {
        static void Main()
        {
            string path = "№1.txt";
            int[] numbers = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 };

            File.WriteAllLines(path, numbers.Select(n => n.ToString()));

            int[] fileNumbers = File.ReadAllLines(path).Select(int.Parse).ToArray();

            int minNumber = fileNumbers.Min();

            int positiveCount = fileNumbers.Count(n => n > 0);

            Console.WriteLine($"Минимальное число: {minNumber}");
            Console.WriteLine($"Количество положительных элементов: {positiveCount}");
        }
    }
}
