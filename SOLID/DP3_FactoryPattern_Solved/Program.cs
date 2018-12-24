using System;

namespace DP3_FactoryPattern_Solved
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new PizzaStore();

            pizzaStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine(string.Empty);
            pizzaStore.OrderPizza(PizzaType.Vegetarian);

            Console.Read();
        }
    }
}
