using System;
using SOLID._3._LSP;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 5);
            Console.WriteLine(rectangle.ComputeArea());

            Square square = new Square(10);
            Console.WriteLine(square.ComputeArea());

            Rectangle rectangle2 = new Square(10);
            rectangle2.SetHeight(3);
            Console.WriteLine(rectangle2.ComputeArea());

            Console.Read();
        }
    }
}
