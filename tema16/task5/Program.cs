namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalNumbers = { 20, 10, 4, -1, -2, 0, 0, 0, -10, 41, 62 };
            File.WriteAllLines("original.txt", originalNumbers.Select(n => n.ToString()));

            var numbers = File.ReadAllLines("original.txt").Select(int.Parse).ToList();

            var resultNumbers = new List<int>();
            int sum = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if ((numbers[i] == 0 && sum != 0) || (numbers[i] * sum < 0)) 
                {
                    resultNumbers.Add(sum);
                    sum = numbers[i]; 
                }
                else
                {
                    sum += numbers[i];
                }
            }
            resultNumbers.Add(sum); 

            File.WriteAllLines("result.txt", resultNumbers.Select(n => n.ToString()));

            Console.WriteLine("Файл 'result.txt' успешно создан.");
        }
    }
}
