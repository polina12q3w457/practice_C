using System.IO;

namespace task16
{
    /// <summary>
    /// Основной класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            // Перебор всех доступных дисков.
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                // Проверка, готов ли диск и является ли он диском E:\
                if (drive.IsReady && drive.Name == "E:\\")
                {
                    Console.WriteLine($"Файлы на диске {"E:\\"}:");
                    try
                    {
                        // Получение всех файлов на диске E:\
                        string[] files = Directory.GetFiles("E:\\", "*.*", SearchOption.AllDirectories);
                        // Вывод всех файлов на диске E:\
                        foreach (string file in files)
                        {
                            Console.WriteLine(file);
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        // Обработка исключения, если доступ к одной или нескольким папкам отсутствует.
                        Console.WriteLine("Нет доступа к одной или нескольким папкам.");
                    }
                }
            }

            // Путь к создаваемой директории.
            string directoryPath = "Exmple_36tp";
            // Создание директории.
            Directory.CreateDirectory(directoryPath);

            // Путь к исходной директории.
            string sourceDirectory = "source";
            // Получение первых трех файлов из исходной директории.
            string[] sourceFiles = Directory.GetFiles(sourceDirectory).Take(3).ToArray();
            // Копирование файлов в новую директорию.
            foreach (string sourceFile in sourceFiles)
            {
                // Путь к файлу в новой директории.
                string destinationFile = Path.Combine(directoryPath, Path.GetFileName(sourceFile));
                // Копирование файла.
                File.Copy(sourceFile, destinationFile);

                // Установка атрибута "Скрытый" для файла.
                File.SetAttributes(destinationFile, FileAttributes.Hidden);

                // Путь к файлу-ссылке.
                string linkPath = destinationFile + ".lnk";
                // Создание файла-ссылки.
                using (StreamWriter writer = new StreamWriter(linkPath))
                {
                    // Запись пути к файлу в файл-ссылку.
                    writer.WriteLine(destinationFile);
                }
            }
        }
    }
}

