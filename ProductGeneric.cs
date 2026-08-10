namespace CSharpLearning
{
    public class ProductGeneric
    {
        public string Name { get; set; } = "";
        public decimal Price { get; set; }

        public ProductGeneric() { }

        public ProductGeneric(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Product: {Name}, Price: {Price}";
        }
    }
}