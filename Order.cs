using System.Linq;

namespace CoffeeShop
{
    public class Order
    {
        public readonly Coffee[] Coffees;

        public Order(params Coffee[] coffees)
        {
            Coffees = coffees;
        }


        public decimal GetBasePrice()
        {
            return Coffees.Sum(x => x.Price);
        }
    }
}
