using System.Text.RegularExpressions;
namespace task1
{

    class Program
    {
        static void Main()
        {
            string text = "В сетевом журнале были замечены следующие IP-адреса, подозреваемые в неавторизованной активности:\r\n- 192.168.1.15 - попытка доступа к закрытому порту.\r\n- 172.16.254.3 - множественные запросы к веб-серверу за короткий промежуток времени.\r\n- 10.0.0.27 - необычно большое количество данных отправлено на этот адрес.\r\nЭти адреса были временно заблокированы, и начато их дальнейшее расследование.";
            string pattern = @"\b(?:[0-9]{1,3}\.){3}[0-9]{1,3}\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine($"IP-адрес: {match.Value}");
            }
        }
    }
}
 