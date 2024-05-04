namespace task3
{
    public class MyInfo
    {
        private string name;
        public event Action<string> NameChanged;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    NameChanged?.Invoke(name);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyInfo myInfo = new MyInfo();
            myInfo.NameChanged += (newName) => Console.WriteLine("Имя было изменено");
            myInfo.Name = "Полина";
        }
    }
}

