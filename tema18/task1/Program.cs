namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "abc#d##c";
            Console.WriteLine("Исходная строка: " + input);
            Console.WriteLine("Преобразованная строка: " + TransformString(input));
        }

        static string TransformString(string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in input)
            {
                if (c == '#')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }
            var arr = stack.ToArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}