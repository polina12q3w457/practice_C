namespace task3
{
    /// <summary>
    /// Класс, представляющий матрицу.
    /// </summary>
    public class Matrix
    {
        private int[,] _data;

        /// <summary>
        /// Количество строк в матрице.
        /// </summary>
        public int Rows { get; }

        /// <summary>
        /// Количество столбцов в матрице.
        /// </summary>
        public int Columns { get; }

        /// <summary>
        /// Конструктор, создающий матрицу заданного размера.
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="columns">Количество столбцов.</param>
        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            _data = new int[rows, columns];
        }

        /// <summary>
        /// Индексатор для доступа к элементам матрицы.
        /// </summary>
        /// <param name="i">Индекс строки.</param>
        /// <param name="j">Индекс столбца.</param>
        /// <returns>Элемент матрицы.</returns>
        public int this[int i, int j]
        {
            get { return _data[i, j]; }
            set { _data[i, j] = value; }
        }

        /// <summary>
        /// Оператор умножения двух матриц.
        /// </summary>
        /// <param name="a">Первая матрица.</param>
        /// <param name="b">Вторая матрица.</param>
        /// <returns>Результат умножения.</returns>
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.Columns != b.Rows)
                throw new InvalidOperationException("Матрицы не согласованы для умножения.");

            var result = new Matrix(a.Rows, b.Columns);
            for (int i = 0; i < a.Rows; ++i)
                for (int j = 0; j < b.Columns; ++j)
                    for (int k = 0; k < a.Columns; ++k)
                        result[i, j] += a[i, k] * b[k, j];

            return result;
        }

        /// <summary>
        /// Метод для заполнения матрицы.
        /// </summary>
        public void FillMatrix()
        {
            Console.WriteLine("Введите элементы матрицы:");
            for (int i = 0; i < Rows; ++i)
                for (int j = 0; j < Columns; ++j)
                    _data[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }

    /// <summary>
    /// Главный класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            var matrix1 = new Matrix(2, 3);
            var matrix2 = new Matrix(3, 2);

            Console.WriteLine("Заполните первую матрицу:");
            matrix1.FillMatrix();
            Console.WriteLine("Заполните вторую матрицу:");
            matrix2.FillMatrix();

            var result = matrix1 * matrix2;

            Console.WriteLine("Результат умножения:");
            for (int i = 0; i < result.Rows; ++i)
            {
                for (int j = 0; j < result.Columns; ++j)
                    Console.Write(result[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}

