using System;

namespace DP3_FactoryPattern_Solved
{
    class VegetarianPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Vegetarian specific preparation technique.");
        }

        public override void Bake()
        {
            Console.WriteLine("Vegetarian specific baking technique.");
        }

        public override void Cut()
        {
            Console.WriteLine("Vegetarian specific cutting technique.");
        }

        public override void Box()
        {
            Console.WriteLine("Vegetarian specific boxing technique.");
        }
    }
}
