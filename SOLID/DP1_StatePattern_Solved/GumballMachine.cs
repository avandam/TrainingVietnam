using System;
using System.Text;

namespace DP1_StatePattern_Solved
{
    public class GumballMachine
    {
        private const int SoldOut = 0;
        private const int NoQuarter = 1;
        private const int HasQuarter = 2;
        private const int Sold = 3;

        private int state = SoldOut;
        private int count;

        public GumballMachine(int count)
        {
            this.count = count;
            if (count > 0)
            {
                state = NoQuarter;
            }
        }

        public void InsertQuarter()
        {
            if (state == HasQuarter)
            {
                Console.WriteLine("You can't insert another quarter");
            }
            else if (state == NoQuarter)
            {
                state = HasQuarter;
                Console.WriteLine("You inserted a quarter");
            }
            else if (state == SoldOut)
            {
                Console.WriteLine("You can't insert a quarter, the machine is sold out");
            }
            else if (state == Sold)
            {
                Console.WriteLine("Please wait, we're already giving you a gumball");
            }
        }

        public void EjectQuarter()
        {
            if (state == HasQuarter)
            {
                Console.WriteLine("Quarter returned");
                state = NoQuarter;
            }
            else if (state == NoQuarter)
            {
                Console.WriteLine("You haven't inserted a quarter");
            }
            else if (state == Sold)
            {
                Console.WriteLine("Sorry, you already turned the crank");
            }
            else if (state == SoldOut)
            {
                Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
            }
        }

        public void TurnCrank()
        {
            if (state == Sold)
            {
                Console.WriteLine("Turning twice doesn't get you another gumball!");
            }
            else if (state == NoQuarter)
            {
                Console.WriteLine("You turned but there's no quarter");
            }
            else if (state == SoldOut)
            {
                Console.WriteLine("You turned, but there are no gumballs");
            }
            else if (state == HasQuarter)
            {
                Console.WriteLine("You turned...");
                state = Sold;
                Dispense();
            }
        }

        public void Dispense()
        {
            if (state == Sold)
            {
                Console.WriteLine("A gumball comes rolling out the slot");
                count = count - 1;
                if (count == 0)
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    state = SoldOut;
                }
                else
                {
                    state = NoQuarter;
                }
            }
            else if (state == NoQuarter)
            {
                Console.WriteLine("You need to pay first");
            }
            else if (state == SoldOut)
            {
                Console.WriteLine("No gumball dispensed");
            }
            else if (state == HasQuarter)
            {
                Console.WriteLine("No gumball dispensed");
            }
        }

        public void Refill(int numGumBalls)
        {
            count = numGumBalls;
            state = NoQuarter;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");

            result.Append("Inventory: " + count + " gumball");
            if (count != 1)
            {
                result.Append("s");
            }
            result.Append("\nMachine is ");
            if (state == SoldOut)
            {
                result.Append("sold out");
            }
            else if (state == NoQuarter)
            {
                result.Append("waiting for quarter");
            }
            else if (state == HasQuarter)
            {
                result.Append("waiting for turn of crank");
            }
            else if (state == Sold)
            {
                result.Append("delivering a gumball");
            }
            result.Append("\n");
            return result.ToString();
        }
    }
}
