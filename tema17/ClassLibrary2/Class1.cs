namespace ClassLibrary2
{
    public class Bread
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public Bread(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Хлеб {Name} весит {Weight} грамм.";
        }
    }
}