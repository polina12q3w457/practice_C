namespace task2
{
    class Program
    {
        static void Main()
        {
            string path = "file.txt"; 
            Queue<char> nonDigits = new Queue<char>();
            Queue<char> digits = new Queue<char>();

            using (StreamReader sr = new StreamReader(path))
            {
                int c;
                while ((c = sr.Read()) != -1)
                {
                    char character = (char)c;
                    if (Char.IsDigit(character))
                    {
                        digits.Enqueue(character);
                    }
                    else
                    {
                        nonDigits.Enqueue(character);
                    }
                }
            }

            while (nonDigits.Count > 0)
            {
                Console.Write(nonDigits.Dequeue());
            }

            while (digits.Count > 0)
            {
                Console.Write(digits.Dequeue());
            }
        }
    }
}