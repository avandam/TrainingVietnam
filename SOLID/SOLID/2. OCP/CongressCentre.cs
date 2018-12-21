using System;
using System.Collections.Generic;

namespace SOLID._2._OCP
{
    class CongressCentre
    {
        List<Room> rooms = new List<Room>();

        public double ComputeTotalArea()
        {
            double totalArea = 0;

            foreach (Room room in rooms)
            {
                totalArea += room.ComputeArea();
            }

            return totalArea;
        }
    }
}
