namespace ASP_Homework_Product.Models
{
    public class Product
    {
        private static int unicId;
        public int Id { get; }
        public string Name { get; }
        public decimal Cost { get; }
        public string Description { get; }
        public Product(string name, decimal cost, string description)
        {
            Name = name;
            Cost = cost;
            Description = description;
            Id = unicId++;
        }

        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Cost}\n";
        }
    }
}
