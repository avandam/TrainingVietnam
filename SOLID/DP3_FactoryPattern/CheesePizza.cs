using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP3_FactoryPattern
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
