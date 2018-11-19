using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3._LSP
{
    class Square : Rectangle
    {
        public Square(int width) : base(width, width)
        {
        }

        public override void SetWidth(int width)
        {
            SetSide(width);
        }

        public override void SetHeight(int height)
        {
            SetSide(height);
        }

        private void SetSide(int length)
        {
            Width = length;
            Height = length;
        }
    }
}
