using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP4_FacadePattern
{
    class Tuner
    {
        private readonly string description;
        private Amplifier amplifier;
        private double frequency;

        public Tuner(String description, Amplifier amplifier)
        {
            this.description = description;
            this.amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine(description + " on");
        }

        public void Off()
        {
            Console.WriteLine(description + " off");
        }

        public void SetFrequency(double newFrequency)
        {
            Console.WriteLine(description + " setting frequency to " + newFrequency);
            this.frequency = newFrequency;
        }

        public void SetAm()
        {
            Console.WriteLine(description + " setting AM mode");
        }

        public void SetFm()
        {
            Console.WriteLine(description + " setting FM mode");
        }

        public override string ToString()
        {
            return description;
        }

    }
}
