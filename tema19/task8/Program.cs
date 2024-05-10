namespace task3
{
    class Program
    {
        /// <summary>
        /// Делегат для выполнения операций над строками.
        /// </summary>
        /// <param name="s">Входная строка.</param>
        public delegate string StringDelegate(string s);

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main(string[] args)
        {
            StringDelegate SD;

            SD = ToUpper;
            Console.WriteLine(SD("hello"));

            SD = ToLower;
            Console.WriteLine(SD("HELLO"));

            SD = Reverse;
            Console.WriteLine(SD("hello"));
        }

        /// <summary>
        /// Преобразует входную строку в верхний регистр.
        /// </summary>
        /// <param name="s">Входная строка.</param>
        /// <returns>Строка в верхнем регистре.</returns>
        public static string ToUpper(string s)
        {
            return s.ToUpper();
        }

        /// <summary>
        /// Преобразует входную строку в нижний регистр.
        /// </summary>
        /// <param name="s">Входная строка.</param>
        /// <returns>Строка в нижнем регистре.</returns>
        public static string ToLower(string s)
        {
            return s.ToLower();
        }

        /// <summary>
        /// Переворачивает входную строку.
        /// </summary>
        /// <param name="s">Входная строка.</param>
        /// <returns>Перевернутая строка.</returns>
        public static string Reverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}

