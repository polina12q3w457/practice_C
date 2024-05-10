using System.IO;
using System.Linq;

/// <summary>
/// Пространство имен для задачи 10.
/// </summary>
namespace task10
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static void Main()
        {
            // Путь к файлу
            string path = "№1.txt";
            // Массив чисел
            int[] numbers = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 };

            // Запись чисел в файл
            File.WriteAllLines(path, numbers.Select(n => n.ToString()));

            // Чтение чисел из файла
            int[] fileNumbers = File.ReadAllLines(path).Select(int.Parse).ToArray();

            // Нахождение минимального числа
            int minNumber = fileNumbers.Min();

            // Подсчет количества положительных чисел
            int positiveCount = fileNumbers.Count(n => n > 0);

            // Вывод минимального числа
            Console.WriteLine($"Минимальное число: {minNumber}");
            // Вывод количества положительных чисел
            Console.WriteLine($"Количество положительных элементов: {positiveCount}");
        }
    }
}

