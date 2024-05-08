using System.Threading;
using ClassLibrary2;
namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bread myBread = new Bread("Багет", 200);
            System.Console.WriteLine(myBread.ToString());
        }
    }
}
