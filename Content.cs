
namespace CoffeeShop
{
    public class Content
    {
        public readonly string Name;

        public readonly decimal Price;

        public readonly decimal Size;

        public Content(string name, decimal price,decimal size)
        {
            Name = name;
            Price = price;
            Size = size;
        }
    }
}
