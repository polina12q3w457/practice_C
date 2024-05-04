namespace task4
{
    using System;

    class Program
    {
        delegate int MyDelegate();

        static void Main()
        {
            MyDelegate[] delegates = new MyDelegate[5];

            Random rand = new Random();
            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i] = delegate () { return rand.Next(1, 100); };
            }

            Func<MyDelegate[], double> average = delegate (MyDelegate[] dels)
            {
                double sum = 0;
                for (int i = 0; i < dels.Length; i++)
                {
                    sum += dels.Length;
                }
                return sum / dels.Length;
            };

            Console.WriteLine("Среднее значение: " + average(delegates));
        }
    }
}


