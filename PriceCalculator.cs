using System;
using System.Linq;


namespace CoffeeShop
{
    public class PriceCalculator
    {
        public decimal GetPrice(Order order, decimal taxs)
        {
            var price = GetPriceOfCoffees(order);
          
            return price;
        }


        private decimal GetPriceOfCoffees(Order order)
        {
            return order.GetBasePrice();
        }
    }
}
