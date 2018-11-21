using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP3_FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new PizzaStore();

            pizzaStore.OrderPizza("Cheese");
            Console.WriteLine(string.Empty);
            pizzaStore.OrderPizza("Vegetarian");

            Console.Read();
        }
    }
}
