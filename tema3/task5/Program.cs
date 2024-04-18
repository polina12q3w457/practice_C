namespace task5
{
    public class Matrix
    {
        private double[,] _matrix;

        public Matrix(int rows, int cols)
        {
            _matrix = new double[rows, cols];
        }

        public double this[int i, int j]
        {
            get { return _matrix[i, j]; }
            set { _matrix[i, j] = value; }
        }

        public bool IsSquare()
        {
            return _matrix.GetLength(0) == _matrix.GetLength(1);
        }

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