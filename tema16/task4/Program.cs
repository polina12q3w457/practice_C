namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file1 = "file1.txt";
            string file2 = "file2.txt";
            string tempFile = "temp.txt";

            File.Copy(file1, tempFile, true);
            File.Copy(file2, file1, true);
            File.Copy(tempFile, file2, true);
            File.Delete(tempFile);
        }
    }
}
    