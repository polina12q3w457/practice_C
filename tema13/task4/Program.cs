namespace task4
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();
            Subscriber1 sub1 = new Subscriber1();
            Subscriber2 sub2 = new Subscriber2();

            pub.MyEvent += sub1.OnEvent;
            pub.MyEvent += sub1.OnAnotherEvent;
            pub.MyEvent += sub2.OnEvent;

            pub.DoSomething();

            Console.WriteLine("Удаляем один обработчик события...");
            pub.MyEvent -= sub1.OnAnotherEvent;

            pub.DoSomething();

            Console.ReadKey();
        }
    }

    class Publisher
    {
        public delegate void MyDelegate();
        public event MyDelegate MyEvent;

        public void DoSomething()
        {
            MyEvent?.Invoke();
        }
    }

    class Subscriber1
    {
        public void OnEvent()
        {
            Console.WriteLine("Subscriber1: Обработчик события OnEvent вызван!");
        }

        public void OnAnotherEvent()
        {
            Console.WriteLine("Subscriber1: Обработчик события OnAnotherEvent вызван!");
        }
    }

    class Subscriber2
    {
        public void OnEvent()
        {
            Console.WriteLine("Subscriber2: Обработчик события OnEvent вызван!");
        }
    }
}
