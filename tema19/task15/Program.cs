using System.Linq;
using System.IO;

namespace task6
{
    /// <summary>
    /// Основной класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            // Путь к файлу.
            string path = "file.txt";
            // Чтение всего текста из файла.
            string text = File.ReadAllText(path);
            // Разделение текста на слова.
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Буква для поиска слов, начинающихся с неё.
            char letter = 'a';
            // Длина для поиска слов этой длины.
            int length = 5;

            // Поиск слов, начинающихся на заданную букву.
            var wordsStartWithLetter = words.Where(word => word.StartsWith(letter));
            Console.WriteLine($"Слова, начинающиеся на букву '{letter}': {string.Join(", ", wordsStartWithLetter)}");

            // Поиск слов заданной длины.
            var wordsWithLength = words.Where(word => word.Length == length);
            Console.WriteLine($"Слова длиной {length}: {string.Join(", ", wordsWithLength)}");

            // Поиск слов, начинающихся и заканчивающихся на одну и ту же букву.
            var wordsStartEndWithSameLetter = words.Where(word => word.First() == word.Last());
            Console.WriteLine($"Слова, начинающиеся и заканчивающиеся на одну и ту же букву: {string.Join(", ", wordsStartEndWithSameLetter)}");

            // Первая буква последнего слова.
            char lastWordFirstLetter = words.Last().First();
            // Поиск слов, начинающихся на ту же букву, что и первая буква последнего слова.
            var wordsStartWithLastWordFirstLetter = words.Where(word => word.StartsWith(lastWordFirstLetter));
            Console.WriteLine($"Слова, начинающиеся на ту же букву, что и первая буква последнего слова: {string.Join(", ", wordsStartWithLastWordFirstLetter)}");
        }
    }
}

