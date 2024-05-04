namespace task3
{
    class Program
    {
        public delegate string StringDelegate(string s);

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

        public static string ToUpper(string s)
        {
            return s.ToUpper();
        }

        public static string ToLower(string s)
        {
            return s.ToLower();
        }

        public static string Reverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
