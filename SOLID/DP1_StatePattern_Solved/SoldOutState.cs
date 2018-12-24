using System;

namespace DP1_StatePattern_Solved
{
    class SoldOutState : State
    {
        private readonly GumballMachine gummballDispenser;

        public SoldOutState(GumballMachine gummballDispenser)
        {
            this.gummballDispenser = gummballDispenser;
        }

        public override  void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public override void TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }

        public override void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public override void Refill()
        {
            gummballDispenser.RefillMachine(5);
            Console.WriteLine("MAchine is refilled");
        }

        public override String ToString()
        {
            return "sold out";
        }
    }
}
