namespace SOLID._2._OCP
{
    class RectangleRoom : Room
    {
        public double Length { get; private set; }
        public double Width { get; private set; }

        public RectangleRoom(double length, double width)
        {
            Length = length;
            Width = width;
        }
    }
}
