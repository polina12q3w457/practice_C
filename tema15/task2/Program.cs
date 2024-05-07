using System.Collections.Generic;
namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("one", 1);
            myDictionary.Add("two", 2);
            myDictionary.Add("three", 3);

            Console.WriteLine("Элементы в словаре:");
            Console.WriteLine($"one: {myDictionary["one"]}");
            Console.WriteLine($"two: {myDictionary["two"]}");
            Console.WriteLine($"three: {myDictionary["three"]}");

            Console.WriteLine($"Общее количество пар ключ-значение: {myDictionary.Count}");
        }
    }

    public class MyDictionary<TKey, TValue>
    {
        private List<TKey> keys;
        private List<TValue> values;

        public MyDictionary()
        {
            keys = new List<TKey>();
            values = new List<TValue>();
        }

        public TValue this[TKey key]
        {
            get
            {
                int index = keys.IndexOf(key);
                if (index == -1)
                {
                    throw new KeyNotFoundException();
                }
                return values[index];
            }
        }

        public void Add(TKey key, TValue value)
        {
            if (keys.Contains(key))
            {
                throw new ArgumentException("An element with the same key already exists in the MyDictionary");
            }
            keys.Add(key);
            values.Add(value);
        }

        public int Count
        {
            get
            {
                return keys.Count;
            }
        }
    }
}

