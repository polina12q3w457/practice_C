namespace task3
{
    public class Matrix
    {
        private int[,] _data;

        public int Rows { get; }
        public int Columns { get; }

        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            _data = new int[rows, columns];
        }

        public int this[int i, int j]
        {
            get { return _data[i, j]; }
            set { _data[i, j] = value; }
        }

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

        public void FillMatrix()
        {
            Console.WriteLine("Введите элементы матрицы:");
            for (int i = 0; i < Rows; ++i)
                for (int j = 0; j < Columns; ++j)
                    _data[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Program
    {
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