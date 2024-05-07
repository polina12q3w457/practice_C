using System.IO;
namespace task7
{
    class Program
    {
        static void Main()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.Name == "E:\\")
                {
                    Console.WriteLine($"Файлы на диске {"E:\\"}:");
                    try
                    {
                        string[] files = Directory.GetFiles("E:\\", "*.*", SearchOption.AllDirectories);
                        foreach (string file in files)
                        {
                            Console.WriteLine(file);
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.WriteLine("Нет доступа к одной или нескольким папкам.");
                    }
                }
            }

            string directoryPath = "Exmple_36tp"; 
            Directory.CreateDirectory(directoryPath);

            string sourceDirectory = "source";
            string[] sourceFiles = Directory.GetFiles(sourceDirectory).Take(3).ToArray();
            foreach (string sourceFile in sourceFiles)
            {
                string destinationFile = Path.Combine(directoryPath, Path.GetFileName(sourceFile));
                File.Copy(sourceFile, destinationFile);

                File.SetAttributes(destinationFile, FileAttributes.Hidden);

                string linkPath = destinationFile + ".lnk";
                using (StreamWriter writer = new StreamWriter(linkPath))
                {
                    writer.WriteLine(destinationFile);
                }
            }
        }
    }
}


