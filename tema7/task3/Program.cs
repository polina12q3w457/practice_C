using System.Text.RegularExpressions;
namespace task3
{
    class Program
    {
        static void Main()
        {
            string text = "Вчера я купил 3 яблока и 2 банана. Затем я пошел в парк, где провел 4 часа. После этого я посетил 5 магазинов, прежде чем вернуться домой";
            Regex regex = new Regex(@"\d+");
            MatchCollection matches = regex.Matches(text);

            long product = 1;
            foreach (Match match in matches)
            {
                product *= long.Parse(match.Value);
            }

            Console.WriteLine("Произведение всех чисел в тексте: " + product);
        }
    }
}