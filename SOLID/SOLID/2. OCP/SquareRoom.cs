namespace SOLID._2._OCP
{
    class SquareRoom : Room
    {
        public double Length { get; private set; }

        public SquareRoom(double length)
        {
            Length = length;
        }

        public override double ComputeArea()
        {
            return Length * Length;
        }
    }
}
