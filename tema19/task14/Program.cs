namespace task14
{
    /// <summary>
    /// Основной класс программы.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            // Исходный массив чисел.
            int[] originalNumbers = { 20, 10, 4, -1, -2, 0, 0, 0, -10, 41, 62 };
            // Запись исходного массива чисел в файл.
            File.WriteAllLines("original.txt", originalNumbers.Select(n => n.ToString()));

            // Чтение чисел из файла.
            var numbers = File.ReadAllLines("original.txt").Select(int.Parse).ToList();

            // Результат обработки чисел.
            var resultNumbers = new List<int>();
            int sum = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                // Если текущее число равно нулю и сумма не равна нулю, или знак текущего числа отличается от знака суммы.
                if ((numbers[i] == 0 && sum != 0) || (numbers[i] * sum < 0))
                {
                    // Добавление суммы в результат.
                    resultNumbers.Add(sum);
                    // Сброс суммы.
                    sum = numbers[i];
                }
                else
                {
                    // Накопление суммы.
                    sum += numbers[i];
                }
            }
            // Добавление последней суммы в результат.
            resultNumbers.Add(sum);

            // Запись результата в файл.
            File.WriteAllLines("result.txt", resultNumbers.Select(n => n.ToString()));

            // Вывод сообщения об успешном создании файла.
            Console.WriteLine("Файл 'result.txt' успешно создан.");
        }
    }
}

