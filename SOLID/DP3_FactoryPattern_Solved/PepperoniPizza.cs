using System;

namespace DP3_FactoryPattern_Solved
{
    class PepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Pepperoni specific preparation technique.");
        }

        public override void Bake()
        {
            Console.WriteLine("Pepperoni specific baking technique.");
        }

        public override void Cut()
        {
            Console.WriteLine("Pepperoni specific cutting technique.");
        }

        public override void Box()
        {
            Console.WriteLine("Pepperoni specific boxing technique.");
        }
    }
}
