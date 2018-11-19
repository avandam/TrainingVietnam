using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2._OCP
{
    class CircularRoom : Room
    {
        public double Radius { get; private set; }

        public CircularRoom(double radius)
        {
            Radius = radius;
        }


    }
}
