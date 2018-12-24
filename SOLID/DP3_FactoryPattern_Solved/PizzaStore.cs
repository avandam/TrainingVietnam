using System;

namespace DP3_FactoryPattern_Solved
{
    class PizzaStore
    {
        public Pizza OrderPizza(PizzaType type)
        {
            Pizza pizza = PizzaFactory.GetSpecificPizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
