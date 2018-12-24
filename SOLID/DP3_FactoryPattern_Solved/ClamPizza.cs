using System;

namespace DP3_FactoryPattern_Solved
{
    class ClamPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Clam specific preparation technique.");
        }

        public override void Bake()
        {
            Console.WriteLine("Clam specific baking technique.");
        }

        public override void Cut()
        {
            Console.WriteLine("Clam specific cutting technique.");
        }

        public override void Box()
        {
            Console.WriteLine("Clam specific boxing technique.");
        }
    }
}
