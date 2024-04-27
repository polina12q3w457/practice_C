namespace task1
{
        interface Ix
        {
            void IxF0(int w);
            void IxF1();
        }

        interface Iy
        {
            void F0(int w);
            void F1();
        }

        interface Iz
        {
            void F0(int w);
            void F1();
        }

        class TestClass : Ix, Iy, Iz
        {
            public int w;

            public TestClass()
            {
                w = 125;
            }

            public TestClass(int key)
            {
                w = key;
            }

            public void IxF0(int key)
            {
                w = key * 10;
                Console.WriteLine("IxF0({0})...", w);
            }

            public void IxF1()
            {
                w = w * 10;
                Console.WriteLine("IxF1({0})...", w);
            }

            public void F0(int key)
            {
                w = key - 10;
                Console.WriteLine("(Iy)F0({0})...", w);
            }

            public void F1()
            {
                w = w - 10;
                Console.WriteLine("(Iy)F1({0})...", w);
            }

            void Iz.F0(int key)
            {
                w = key / 10;
                Console.WriteLine("(Iz)F0({0})...", w);
            }

            void Iz.F1()
            {
                w = w / 10;
                Console.WriteLine("(Iz)F1({0})...", w);
            }
        }

        class Class1
        {
            static void Main(string[] args)
            {
                TestClass x0 = new TestClass();
                TestClass x1 = new TestClass(5);

                x0.IxF0(10);
                x1.IxF1();

                x0.F0(5);
                x1.F1();

                (x0 as Iy).F0(7);
                (x1 as Iz).F1();

                Console.WriteLine("==========Prism test==========");
                Console.WriteLine("==========Ix==========");
                Ix ix = x1;
                ix.IxF0(5);
                ix.IxF1();

                Console.WriteLine("==========Iy==========");
                Iy iy = x1;
                iy.F0(5);
                iy.F1();

                Console.WriteLine("==========Iz==========");
                Iz iz = x1;
                iz.F0(5);
                iz.F1();
            }
        }
    }
