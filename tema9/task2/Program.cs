using System.Collections.Generic;
namespace task2
{
    public class NotebookEntry : IComparable<NotebookEntry>
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }

        public int CompareTo(NotebookEntry other)
        {
            return Name.CompareTo(other.Name);
        }
    }

    public class Notebook
    {
        private List<NotebookEntry> entries = new List<NotebookEntry>();

        public void AddEntry(NotebookEntry entry)
        {
            entries.Add(entry);
        }

        public bool RemoveEntryByName(string name)
        {
            var entry = entries.Find(e => e.Name == name);
            if (entry != null)
            {
                entries.Remove(entry);
                return true;
            }
            return false;
        }

        public NotebookEntry FindEntryByName(string name)
        {
            return entries.Find(entry => entry.Name == name);
        }

        public void SortEntries()
        {
            entries.Sort();
        }

        public NotebookEntry GetEntryByIndex(int index)
        {
            return entries[index];
        }

        public int GetEntryCount()
        {
            return entries.Count;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Notebook notebook = new Notebook();

            while (true)
            {
                Console.WriteLine("Введите имя, дату рождения и номер телефона (или 'exit' для выхода):");
                string name = Console.ReadLine();

                if (name.ToLower() == "exit")
                {
                    break;
                }

                DateTime birthDate = DateTime.Parse(Console.ReadLine());
                string phoneNumber = Console.ReadLine();

                NotebookEntry entry = new NotebookEntry { Name = name, BirthDate = birthDate, PhoneNumber = phoneNumber };
                notebook.AddEntry(entry);

                Console.WriteLine("Запись добавлена.");
            }

            Console.WriteLine("Введите имя для удаления:");
            string deleteName = Console.ReadLine();
            if (notebook.RemoveEntryByName(deleteName))
            {
                Console.WriteLine("Запись удалена.");
            }
            else
            {
                Console.WriteLine("Запись не найдена.");
            }

            Console.WriteLine("Сортировка записей по имени:");
            notebook.SortEntries();
            for (int i = 0; i < notebook.GetEntryCount(); i++)
            {
                var entry = notebook.GetEntryByIndex(i);
                Console.WriteLine($"{entry.Name}, {entry.BirthDate}, {entry.PhoneNumber}");
            }
        }
    }
}