using System;
using System.Text;

namespace task1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите арифметическое выражение:");
            string expression = Console.ReadLine();
            bool right = CheckBrackets(expression);
            if (right)
                Console.WriteLine("Скобки в выражении расставлены правильно.");
            else
                Console.WriteLine("Скобки в выражении расставлены неправильно.");
        }

        static bool CheckBrackets(string expression)
        {
            StringBuilder brackets = new StringBuilder();
            foreach (char ch in expression)
            {
                if (ch == '(')
                {
                    brackets.Append(ch);
                }
                else if (ch == ')')
                {
                    if (brackets.Length == 0 || brackets[brackets.Length - 1] != '(')
                        return false;
                    brackets.Remove(brackets.Length - 1, 1);
                }
            }
            return brackets.Length == 0;
        }
    }
}