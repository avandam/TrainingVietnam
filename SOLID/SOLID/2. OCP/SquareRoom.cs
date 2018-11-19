using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2._OCP
{
    class SquareRoom : Room
    {
        public double Length { get; private set; }

        public SquareRoom(double length)
        {
            Length = length;
        }
    }
}
