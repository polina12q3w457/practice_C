namespace task5
{
    /// <summary>
    /// Класс для работы с матрицами.
    /// </summary>
    public class Matrix
    {
        private double[,] _matrix;

        /// <summary>
        /// Конструктор для создания матрицы.
        /// </summary>
        /// <param name="rows">Количество строк в матрице.</param>
        /// <param name="cols">Количество столбцов в матрице.</param>
        public Matrix(int rows, int cols)
        {
            _matrix = new double[rows, cols];
        }

        /// <summary>
        /// Индексатор для доступа к элементам матрицы.
        /// </summary>
        public double this[int i, int j]
        {
            get { return _matrix[i, j]; }
            set { _matrix[i, j] = value; }
        }

        /// <summary>
        /// Проверяет, является ли матрица квадратной.
        /// </summary>
        /// <returns>Возвращает true, если матрица квадратная.</returns>
        public bool IsSquare()
        {
            return _matrix.GetLength(0) == _matrix.GetLength(1);
        }

        /// <summary>
        /// Проверяет, является ли матрица диагональной.
        /// </summary>
        /// <returns>Возвращает true, если матрица диагональная.</returns>
        public bool IsDiagonal()
        {
            if (!IsSquare())
                return false;

            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    if (i != j && _matrix[i, j] != 0)
                        return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Оператор для сравнения двух матриц на равенство.
        /// </summary>
        public static bool operator ==(Matrix m1, Matrix m2)
        {
            if (m1._matrix.GetLength(0) != m2._matrix.GetLength(0) || m1._matrix.GetLength(1) != m2._matrix.GetLength(1))
                return false;

            for (int i = 0; i < m1._matrix.GetLength(0); i++)
            {
                for (int j = 0; j < m1._matrix.GetLength(1); j++)
                {
                    if (m1._matrix[i, j] != m2._matrix[i, j])
                        return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Оператор для сравнения двух матриц на неравенство.
        /// </summary>
        public static bool operator !=(Matrix m1, Matrix m2)
        {
            return !(m1 == m2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(3, 3);
            Matrix matrix2 = new Matrix(3, 3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix1[i, j] = i * 3 + j;
                    matrix2[i, j] = i * 3 + j;
                }
            }

            Console.WriteLine(matrix1.IsDiagonal() ? "Матрица диагональная" : "Матрица не диагональная");

            Console.WriteLine(matrix1 == matrix2 ? "Матрицы равны" : "Матрицы не равны");
        }
    }
}

