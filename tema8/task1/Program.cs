using System;
using System.Linq;
namespace task1
{
    struct TRAIN
    {
        public string Destination;
        public int TrainNumber;
        public DateTime DepartureTime;
    }

    class Program
    {
        static void Main(string[] args)
        {
            TRAIN[] trains = new TRAIN[8];

            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Введите название пункта назначения:");
                trains[i].Destination = Console.ReadLine();

                Console.WriteLine("Введите номер поезда:");
                trains[i].TrainNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите время отправления (формат: чч:мм):");
                trains[i].DepartureTime = DateTime.Parse(Console.ReadLine());
            }

            trains = trains.OrderBy(t => t.Destination).ToArray();

            Console.WriteLine("Введите время для поиска поездов (формат: чч:мм):");
            DateTime searchTime = DateTime.Parse(Console.ReadLine());

            var foundTrains = trains.Where(t => t.DepartureTime > searchTime).ToArray();

            if (foundTrains.Length == 0)
            {
                Console.WriteLine("Поездов, отправляющихся после указанного времени, не найдено.");
            }
            else
            {
                foreach (var train in foundTrains)
                {
                    Console.WriteLine($"Поезд №{train.TrainNumber}, пункт назначения: {train.Destination}, время отправления: {train.DepartureTime.ToShortTimeString()}");
                }
            }

            Console.ReadKey();
        }
    }
}