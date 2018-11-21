namespace SOLID._3._LSP
{
    class Rectangle
    {
        public int Width { get; protected set; }
        public int Height { get; protected set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public virtual void SetWidth(int width)
        {
            Width = width;
        }

        public virtual void SetHeight(int height)
        {
            Height = height;
        }

        public int ComputeArea()
        {
            return Width * Height;
        }
    }
}
