namespace task3
{

    public class Program
    {
        public static void Main()
        {
            try
            {
                int[] numbers = new int[5] { 456, 195, 456, 666, 24 };

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Original number: {numbers[i]}");
                    numbers[i] = InvertDigits(numbers[i]);
                    Console.WriteLine($"Inverted number: {numbers[i]}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введенное значение не является целым числом.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static int InvertDigits(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number", "Число должно быть положительным.");
            }

            int invertedNumber = 0;
            while (number > 0)
            {
                invertedNumber = invertedNumber * 10 + number % 10;
                number /= 10;
            }

            return invertedNumber;
        }
    }
}
