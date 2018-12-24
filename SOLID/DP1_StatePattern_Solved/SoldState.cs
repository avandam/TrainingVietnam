using System;

namespace DP1_StatePattern_Solved
{
    class SoldState : State
    {
        private readonly GumballMachine gummballDispenser;

        public SoldState(GumballMachine gummballDispenser)
        {
            this.gummballDispenser = gummballDispenser;
        }


        public override void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public override void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public override void Dispense()
        {
            gummballDispenser.ReleaseBall();
            if (gummballDispenser.Count > 0)
            {
                gummballDispenser.SetState(gummballDispenser.NoQuarterState);
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                gummballDispenser.SetState(gummballDispenser.SoldOutState);
            }
        }

        public override void Refill()
        {
            Console.WriteLine("Cannot refill when giving out gumballs");
        }

        public override String ToString()
        {
            return "dispensing a gumball";
        }
    }
}
