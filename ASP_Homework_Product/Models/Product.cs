namespace ASP_Homework_Product.Models
{
    public class Product
    {
        static int unicId = 0;
        public int Id { get; }
        public string Name { get; }
        public int Cost { get; }
        public string Description { get; }

        public Product(string name, int cost, string description)
        {
            unicId++;
            Name = name;
            Cost = cost;
            Description = description;
            Id = unicId;
        }

        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Cost}\n{Description}";
        }
    }
}