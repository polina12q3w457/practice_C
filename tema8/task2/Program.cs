namespace task2
{
    enum Position
    {
        Intern = 120,
        JuniorDeveloper = 160,
        SeniorDeveloper = 180,
        Manager = 150,
        Director = 140
    }

    class Program
    {
        static void Main(string[] args)
        {
            foreach (Position position in Enum.GetValues(typeof(Position)))
            {
                Console.WriteLine($"Должность: {position}");
                Console.WriteLine($"Часы в месяц: {(int)position}");
                Console.WriteLine();
            }
        }
    }
}