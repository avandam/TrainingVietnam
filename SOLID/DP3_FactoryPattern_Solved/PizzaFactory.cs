using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP3_FactoryPattern_Solved
{
    class PizzaFactory
    {
        public static Pizza GetSpecificPizza(PizzaType type)
        {
            Pizza pizza;

            switch (type)
            {
                case PizzaType.Cheese:
                   pizza = new CheesePizza();
                    break;
                case PizzaType.Clam:
                    pizza = new ClamPizza();
                    break;
                case PizzaType.Pepperoni:
                    pizza = new PepperoniPizza();
                    break;
                case PizzaType.Vegetarian:
                    pizza = new VegetarianPizza();
                    break;
                default:
                    throw new Exception("Pizza type does not exist");
            }

            return pizza;

        }
    }
}
