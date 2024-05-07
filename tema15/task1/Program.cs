namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            Console.WriteLine("Элементы в списке:");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.WriteLine($"Общее количество элементов: {myList.Count}");
        }
    }

    public class MyList<T>
    {
        private T[] array;
        private int count = 0;

        public MyList()
        {
            array = new T[10];
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                {
                    return array[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public void Add(T item)
        {
            if (count == array.Length)
            {
                T[] newArray = new T[array.Length * 2];
                Array.Copy(array, newArray, count);
                array = newArray;
            }

            array[count] = item;
            count++;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }
    }
}
