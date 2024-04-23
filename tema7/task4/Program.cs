using System.Text;
using System.Text.RegularExpressions;
namespace task4
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            string text = "Я посетил магазин электроники и увидел новый ноутбук, который стоил 1200$. Затем я пошел в книжный магазин, где купил книгу за 15€. После этого я пошел на рынок и купил яблоки за 3$. В конце дня я посетил ресторан, где обед обошелся мне в 20€.";
            Regex regex = new Regex(@"(\d+(?:[.,]\d{1,2})?)\s*(€|\$)");
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}