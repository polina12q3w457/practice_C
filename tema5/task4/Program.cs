namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] array = new int[3, 3]; 

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 50); 
                }
            }

            Console.Write("Введите номер столбца: ");
            int columnNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число для проверки: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, columnNumber];
            }

            bool isDivisible = sum % number == 0;

            Console.WriteLine(isDivisible ? "Сумма элементов столбца кратна заданному числу" : "Сумма элементов столбца не кратна заданному числу");

        }
    }
}