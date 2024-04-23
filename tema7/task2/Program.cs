using System.Text.RegularExpressions;
namespace task2
{
    class Program
    {
        static void Main()
        {
            string text = "Однажды, в тихом озере, жил одинокий омар. Он любил обсервировать облака, отражающиеся на поверхности воды. Он всегда мечтал о большом океане, о котором слышал в старых омарьих легендах.";
            string pattern = "о";

            string newText = Regex.Replace(text, pattern, "оОк");

            Console.WriteLine(newText);
        }
    }
}
D