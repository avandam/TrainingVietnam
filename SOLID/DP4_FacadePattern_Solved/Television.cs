using System;

namespace DP4_FacadePattern_Solved
{
    class Television
    {
        private readonly String description;

        public Television(String description)
        {
            this.description = description;
        }

        public void On()
        {
            Console.WriteLine(description + " on");
        }

        public void Off()
        {
            Console.WriteLine(description + " off");
        }

        public void WideScreenMode()
        {
            Console.WriteLine(description + " in widescreen mode (16x9 aspect ratio)");
        }

        public void TvMode()
        {
            Console.WriteLine(description + " in tv mode (4x3 aspect ratio)");
        }

        public override string ToString()
        {
            return description;
        }
    }
}
