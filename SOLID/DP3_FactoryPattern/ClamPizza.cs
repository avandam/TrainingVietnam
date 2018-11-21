using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP3_FactoryPattern
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
