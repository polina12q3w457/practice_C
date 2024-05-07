using System.Linq;
using System.IO;
namespace task6
{
    class Program
    {
        static void Main()
        {
            string path = "file.txt"; 
            string text = File.ReadAllText(path);
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            char letter = 'a';
            int length = 5; 

            var wordsStartWithLetter = words.Where(word => word.StartsWith(letter));
            Console.WriteLine($"Слова, начинающиеся на букву '{letter}': {string.Join(", ", wordsStartWithLetter)}");

            var wordsWithLength = words.Where(word => word.Length == length);
            Console.WriteLine($"Слова длиной {length}: {string.Join(", ", wordsWithLength)}");

            var wordsStartEndWithSameLetter = words.Where(word => word.First() == word.Last());
            Console.WriteLine($"Слова, начинающиеся и заканчивающиеся на одну и ту же букву: {string.Join(", ", wordsStartEndWithSameLetter)}");

            char lastWordFirstLetter = words.Last().First();
            var wordsStartWithLastWordFirstLetter = words.Where(word => word.StartsWith(lastWordFirstLetter));
            Console.WriteLine($"Слова, начинающиеся на ту же букву, что и первая буква последнего слова: {string.Join(", ", wordsStartWithLastWordFirstLetter)}");
        }
    }
}