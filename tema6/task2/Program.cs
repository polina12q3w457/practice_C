using System.Text;

namespace task2
{
    class Class
    {
        static void Main()
        {
            Console.WriteLine("Введите строку: ");
            StringBuilder a = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Исходная строка: " + a);

            char x = 'Z';
            char y = 'z';

            for (int i = 0; i < a.Length; ++i)
                if (a[i] == x)
                {
                    a.Insert(i + 1, y);
                    ++i;
                }

            Console.WriteLine("Измененная строка: " + a);
        }
    }
}