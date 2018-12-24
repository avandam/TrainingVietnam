using System;

namespace DP3_FactoryPattern_Solved
{
    class CheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Cheese specific preparation technique.");
        }

        public override void Bake()
        {
            Console.WriteLine("Cheese specific baking technique.");
        }

        public override void Cut()
        {
            Console.WriteLine("Cheese specific cutting technique.");
        }

        public override void Box()
        {
            Console.WriteLine("Cheese specific boxing technique.");
        }
    }
}
