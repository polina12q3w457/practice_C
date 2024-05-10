using System;
namespace task9
{

    class Program
    {
        /// <summary>
        /// Делегат для выполнения операций.
        /// </summary>
        delegate int MyDelegate();

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            // Массив делегатов.
            MyDelegate[] delegates = new MyDelegate[5];

            // Генератор случайных чисел.
            Random rand = new Random();
            for (int i = 0; i < delegates.Length; i++)
            {
                // Инициализация делегатов случайными числами.
                delegates[i] = delegate () { return rand.Next(1, 100); };
            }

            // Функция для вычисления среднего значения.
            Func<MyDelegate[], double> average = delegate (MyDelegate[] dels)
            {
                double sum = 0;
                for (int i = 0; i < dels.Length; i++)
                {
                    sum += dels.Length;
                }
                return sum / dels.Length;
            };

            // Вывод среднего значения.
            Console.WriteLine("Среднее значение: " + average(delegates));
        }
    }
}

