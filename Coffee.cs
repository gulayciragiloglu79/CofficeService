using System.Linq;


namespace CoffeeShop
{
    public enum DrinkSize { blackCoffee, Mocha, Latte,Tea};

    public class Coffee
    {
        public readonly DrinkSize DrinkSize;

        public readonly Content[] Contents;

        public readonly decimal Price;

        public Coffee(DrinkSize drinksize, decimal crustPrice, params Content[] contents)
        {
            DrinkSize = drinksize;
            Contents = contents;
            Price = crustPrice + contents.Sum(x => x.Price* x.Size);
        }
    }
}
