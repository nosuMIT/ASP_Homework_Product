namespace ASP_Homework_Product.Models
{
    public class Product
    {
        public Product(int id, string name, string description, double cost)
        {
            Id = id;
            Name = name;
            Description = description;
            Cost = cost;
        }

        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public double Cost { get; }

        public override string ToString()
        {
            return $"ID: {Id}\nNAME: {Name}\nDESCRIPTION: {Description}\nCOST: {Cost}";
        }


    }
}
