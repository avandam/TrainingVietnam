using System;

namespace DP1_StatePattern_Solved
{
    public class NoQuarterState : State
    {
        private readonly GumballMachine gummballDispenser;

        public NoQuarterState(GumballMachine gummballDispenser)
        {
            this.gummballDispenser = gummballDispenser;
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gummballDispenser.SetState(gummballDispenser.HasQuarterState);
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public override void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }

        public override void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public override void Refill()
        {
            gummballDispenser.RefillMachine(5);
            Console.WriteLine("Machine refilled");
        }

        public override String ToString()
        {
            return "waiting for quarter";
        }
    }
}
