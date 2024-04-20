namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[7, 7];
            int value = 1;
            int minRowIndex = 0, maxRowIndex = 6;
            int minColIndex = 0, maxColIndex = 6;

            while (value <= 49)
            {
                for (int i = minColIndex; i <= maxColIndex && value <= 49; i++)
                {
                    array[minRowIndex, i] = value++;
                }

                for (int i = minRowIndex + 1; i <= maxRowIndex && value <= 49; i++)
                {
                    array[i, maxColIndex] = value++;
                }

                for (int i = maxColIndex - 1; i >= minColIndex && value <= 49; i--)
                {
                    array[maxRowIndex, i] = value++;
                }

                for (int i = maxRowIndex - 1; i > minRowIndex && value <= 49; i--)
                {
                    array[i, minColIndex] = value++;
                }

                minRowIndex++;
                minColIndex++;
                maxRowIndex--;
                maxColIndex--;
            }

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}