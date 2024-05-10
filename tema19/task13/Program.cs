namespace task13
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа для приложения.
        /// </summary>
        /// <param name="args">Массив аргументов командной строки.</param>
        static void Main(string[] args)
        {
            // Имена файлов для операций копирования.
            string file1 = "file1.txt";
            string file2 = "file2.txt";
            string tempFile = "temp.txt";

            // Копирование содержимого file1 в tempFile.
            File.Copy(file1, tempFile, true);
            // Копирование содержимого file2 в file1.
            File.Copy(file2, file1, true);
            // Копирование содержимого tempFile в file2.
            File.Copy(tempFile, file2, true);
            // Удаление временного файла.
            File.Delete(tempFile);
        }
    }
}
