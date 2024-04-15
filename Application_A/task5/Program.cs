namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление площади треугольника.");
            Console.WriteLine("Введите исходные данные:");

            double a = GetNumber("Основание (см)");
            double h = GetNumber("Высота (см)");

            double area = 0.5 * a * h;

            Console.WriteLine($"Площадь треугольника {area:F2} кв.см.");
        }

        static double GetNumber(string measurementName)
        {
            while (true)
            {
                Console.Write($"{measurementName} — ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Ошибка: введено не число. Пожалуйста, попробуйте еще раз.");
                }
            }
        }
    }
}