using System.IO;
using System.Linq;
namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "Первая строка", "Вторая строка", "Третья строка", "Четвертая строка", "Пятая строка" };
            File.WriteAllLines("file.txt", lines);
            Console.WriteLine("Содержимое файла:");
            foreach (string line in File.ReadLines("file.txt"))
            {
                Console.WriteLine(line);
            }
            int lineCount = File.ReadLines("file.txt").Count();
            Console.WriteLine($"Количество строк: {lineCount}");

            foreach (string line in File.ReadLines("file.txt"))
            {
                Console.WriteLine($"Количество символов в строке '{line}': {line.Length}");
            }
            File.WriteAllLines("new_file.txt", File.ReadLines("file.txt").Take(lineCount - 1));

            int s1 = 1, s2 = 3; 
            foreach (string line in File.ReadLines("file.txt").Skip(s1 - 1).Take(s2 - s1 + 1))
            {
                Console.WriteLine(line);
            }
            int maxLength = File.ReadLines("file.txt").Max(line => line.Length);
            Console.WriteLine($"Длина самой длинной строки: {maxLength}");

            char startChar = 'П'; 
            foreach (string line in File.ReadLines("file.txt").Where(line => line.StartsWith(startChar)))
            {
                Console.WriteLine(line);
            }
            File.WriteAllLines("reversed_file.txt", File.ReadLines("file.txt").Reverse());
        }
    }
}