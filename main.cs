using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Script.Serialization; //we are able to convert JSON<->Object in order to getting order request data from client side                                           
//by adding System.Web.Extensions.dll reference as well
namespace CoffeeShop
{
    class Program
    {

        static void Main(string[] args)
        {
            var coffee = new Coffee(DrinkSize.blackCoffee, 15, new Content("Milk", 10, 1));
            var order = new Order(coffee);

            var calculator = new PriceCalculator();
            decimal myResult = calculator.GetPrice(order, 0);

                   
          // Example Test Case and Call
         // int myResult = 5; 
          decimal Expected = 25; 
          EvaluateTestResult(1, myResult == Expected);

          Expected = 26; 
          coffee = new Coffee(DrinkSize.Mocha, 10, new Content("Chocalate sauce", 8, 2));
                      order = new Order(coffee);

            calculator = new PriceCalculator();
            myResult  = calculator.GetPrice(order, 0);
          
          EvaluateTestResult(2, myResult == Expected);
          
          Expected = 20; 
          coffee = new Coffee(DrinkSize.Latte, 5, new Content("Hazelnut Syrup", 10, 1), new Content("Milk", 5, 1));
            order = new Order(coffee);

            calculator = new PriceCalculator();
            myResult = calculator.GetPrice(order, 0);

             EvaluateTestResult(3, myResult == Expected);
        }

        private static void EvaluateTestResult(int testCaseNumber, bool compareResult)
        {
            string result = compareResult ? "SUCCESS" : "FAIL";
            Console.WriteLine("TestCase" + testCaseNumber + ": " + result);
        }
    }


}
