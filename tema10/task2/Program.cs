namespace task2
{
    using System;

    class A
    {
        private int a = 5;
        private int b = 10;

        public A() { }

        public int C
        {
            get { return a + b; }
        }
    }

    class B : A
    {
        private int d = 20;

        public B() : base() { }

        public B(int d)
        {
            this.d = d;
        }

        public int C2
        {
            get
            {
                switch (d)
                {
                    case 10:
                        return this.C + d;
                    default:
                        return this.C - d;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine("Значение свойства C класса A: " + a.C);

            B b1 = new B();
            Console.WriteLine("Значение свойства C2 класса B (по умолчанию): " + b1.C2);

            B b2 = new B(10);
            Console.WriteLine("Значение свойства C2 класса B (собственный конструктор): " + b2.C2);
        }
    }
}
