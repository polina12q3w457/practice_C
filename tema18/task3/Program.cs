namespace task3
{
    public class Sport<T>
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void RemoveItem(T item)
        {
            items.Remove(item);
        }

        public Sport<T> Clone()
        {
            Sport<T> clone = new Sport<T>();
            clone.items = new List<T>(this.items);
            return clone;
        }

        public void DisplayItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Sport<string> sports = new Sport<string>();
            sports.AddItem("Football");
            sports.AddItem("Basketball");
            sports.DisplayItems();
            Sport<string> clonedSports = sports.Clone();
            clonedSports.DisplayItems();
            sports.RemoveItem("Football");
            sports.DisplayItems();
            int? nullableInt = null;
            Console.WriteLine("Nullable Int: " + nullableInt);
            List<int> list = new List<int> { 1, 2, 3 };
            Dictionary<string, int> dictionary = new Dictionary<string, int> { { "One", 1 }, { "Two", 2 } };
        }
    }
}
