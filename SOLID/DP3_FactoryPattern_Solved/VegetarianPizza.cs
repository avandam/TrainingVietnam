using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP3_FactoryPattern
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
