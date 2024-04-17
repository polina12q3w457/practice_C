namespace task3
{
    public class Дата
    {
        private DateTime дата;

        public Дата(int год, int месяц, int день)
        {
            if (DateTime.TryParse($"{год}/{месяц}/{день}", out DateTime tempДата))
            {
                дата = tempДата;
            }
            else
            {
                throw new ArgumentException("Введена недопустимая дата.");
            }
        }

        public void ИзменитьГод(int новыйГод)
        {
            if (новыйГод >= 1 && новыйГод <= 9999)
            {
                дата = new DateTime(новыйГод, дата.Month, дата.Day);
            }
            else
            {
                throw new ArgumentException("Введен недопустимый год.");
            }
        }

        public void ИзменитьМесяц(int новыйМесяц)
        {
            if (новыйМесяц >= 1 && новыйМесяц <= 12)
            {
                дата = new DateTime(дата.Year, новыйМесяц, дата.Day);
            }
            else
            {
                throw new ArgumentException("Введен недопустимый месяц.");
            }
        }

        public void ИзменитьДень(int новыйДень)
        {
            if (новыйДень >= 1 && новыйДень <= DateTime.DaysInMonth(дата.Year, дата.Month))
            {
                дата = new DateTime(дата.Year, дата.Month, новыйДень);
            }
            else
            {
                throw new ArgumentException("Введен недопустимый день.");
            }
        }

        public void ИзменитьДатуНаДни(int дни)
        {
            дата = дата.AddDays(дни);
        }

        public void ИзменитьДатуНаМесяцы(int месяцы)
        {
            дата = дата.AddMonths(месяцы);
        }

        public void ИзменитьДатуНаГоды(int годы)
        {
            дата = дата.AddYears(годы);
        }

        public override string ToString()
        {
            return дата.ToString("dd/MM/yyyy");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Дата дата = new Дата(2024, 4, 17);
            Console.WriteLine("Исходная дата: " + дата);

            дата.ИзменитьГод(2025);
            Console.WriteLine("Дата после изменения года: " + дата);

            дата.ИзменитьМесяц(12);
            Console.WriteLine("Дата после изменения месяца: " + дата);

            дата.ИзменитьДень(31);
            Console.WriteLine("Дата после изменения дня: " + дата);

            дата.ИзменитьДатуНаДни(7);
            Console.WriteLine("Дата после добавления 7 дней: " + дата);

            дата.ИзменитьДатуНаМесяцы(2);
            Console.WriteLine("Дата после добавления 2 месяцев: " + дата);

            дата.ИзменитьДатуНаГоды(1);
            Console.WriteLine("Дата после добавления 1 года: " + дата);
        }
    }
}