using System;
using System.Collections;
namespace task4
{
    class CD
    {
        public string Title { get; set; }
        public ArrayList Songs { get; set; }

        public CD(string title)
        {
            Title = title;
            Songs = new ArrayList();
        }

        public void AddSong(string song)
        {
            Songs.Add(song);
        }

        public void RemoveSong(string song)
        {
            Songs.Remove(song);
        }

        public void DisplaySongs()
        {
            Console.WriteLine("Songs in CD " + Title + ":");
            foreach (string song in Songs)
            {
                Console.WriteLine(song);
            }
        }
    }

    class CDCatalog
    {
        private Hashtable cds;

        public CDCatalog()
        {
            cds = new Hashtable();
        }

        public void AddCD(string title)
        {
            cds[title] = new CD(title);
        }

        public void RemoveCD(string title)
        {
            cds.Remove(title);
        }

        public void AddSong(string cdTitle, string song)
        {
            CD cd = (CD)cds[cdTitle];
            if (cd != null)
            {
                cd.AddSong(song);
            }
        }

        public void RemoveSong(string cdTitle, string song)
        {
            CD cd = (CD)cds[cdTitle];
            if (cd != null)
            {
                cd.RemoveSong(song);
            }
        }

        public void DisplayCatalog()
        {
            foreach (DictionaryEntry entry in cds)
            {
                CD cd = (CD)entry.Value;
                cd.DisplaySongs();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CDCatalog catalog = new CDCatalog();

            catalog.AddCD("CD1");
            catalog.AddSong("CD1", "Song1");
            catalog.AddSong("CD1", "Song2");

            catalog.AddCD("CD2");
            catalog.AddSong("CD2", "Song3");
            catalog.AddSong("CD2", "Song4");

            catalog.DisplayCatalog();

            catalog.RemoveSong("CD1", "Song1");
            catalog.RemoveCD("CD2");

            catalog.DisplayCatalog();
        }
    }
}


