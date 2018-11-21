using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP3_FactoryPattern
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
