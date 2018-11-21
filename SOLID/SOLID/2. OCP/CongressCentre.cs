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
                if (room is SquareRoom)
                {
                    SquareRoom squareRoom = room as SquareRoom;
                    totalArea += squareRoom.Length * squareRoom.Length;
                }
                else if (room is RectangleRoom)
                {
                    RectangleRoom rectangleRoom = room as RectangleRoom;
                    totalArea += rectangleRoom.Length * rectangleRoom.Width;
                }
                else if (room is CircularRoom)
                {
                    CircularRoom circularRoom = room as CircularRoom;
                    totalArea += circularRoom.Radius * circularRoom.Radius * Math.PI;
                }
            }

            return totalArea;
        }
    }
}
