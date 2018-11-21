using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP3_FactoryPattern
{
    class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            if (type == "Cheese")
            {
                pizza = new CheesePizza();
            }
            else if (type == "Clam")
            {
                pizza = new ClamPizza();
            }
            else if (type == "Pepperoni")
            {
                pizza = new PepperoniPizza();
            }
            else if (type == "Vegetarian")
            {
                pizza = new VegetarianPizza();
            }
            else
            {
                throw new Exception("Pizza type does not exist");
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
