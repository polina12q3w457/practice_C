using System.IO;
using System.Linq;

/// <summary>
/// Пространство имен для задачи 12.
/// </summary>
namespace task12
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// <param name="args">Массив аргументов командной строки.</param>
        static void Main(string[] args)
        {
            // Массив строк для записи в файл
            string[] lines = { "Первая строка", "Вторая строка", "Третья строка", "Четвертая строка", "Пятая строка" };

            // Запись строк в файл
            File.WriteAllLines("file.txt", lines);

            // Вывод содержимого файла
            Console.WriteLine("Содержимое файла:");
            foreach (string line in File.ReadLines("file.txt"))
            {
                Console.WriteLine(line);
            }

            // Подсчет количества строк в файле
            int lineCount = File.ReadLines("file.txt").Count();
            Console.WriteLine($"Количество строк: {lineCount}");

            // Вывод количества символов в каждой строке
            foreach (string line in File.ReadLines("file.txt"))
            {
                Console.WriteLine($"Количество символов в строке '{line}': {line.Length}");
            }

            // Создание нового файла с копией всех строк, кроме последней
            File.WriteAllLines("new_file.txt", File.ReadLines("file.txt").Take(lineCount - 1));

            // Вывод строк с s1 по s2
            int s1 = 1, s2 = 3;
            foreach (string line in File.ReadLines("file.txt").Skip(s1 - 1).Take(s2 - s1 + 1))
            {
                Console.WriteLine(line);
            }

            // Нахождение и вывод длины самой длинной строки
            int maxLength = File.ReadLines("file.txt").Max(line => line.Length);
            Console.WriteLine($"Длина самой длинной строки: {maxLength}");

            // Вывод строк, начинающихся с определенного символа
            char startChar = 'П';
            foreach (string line in File.ReadLines("file.txt").Where(line => line.StartsWith(startChar)))
            {
                Console.WriteLine(line);
            }

            // Создание нового файла с обратным порядком строк
            File.WriteAllLines("reversed_file.txt", File.ReadLines("file.txt").Reverse());
        }
    }
}

