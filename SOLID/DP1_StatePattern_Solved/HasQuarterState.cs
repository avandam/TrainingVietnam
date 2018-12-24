using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_StatePattern_Solved
{
    public class HasQuarterState : State
    {
        private readonly GumballMachine gummballDispenser;

        public HasQuarterState(GumballMachine gummballDispenser)
        {
            this.gummballDispenser = gummballDispenser;
        }


        public override void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gummballDispenser.SetState(gummballDispenser.NoQuarterState);

            
        }

        public override void TurnCrank()
        {
            Console.WriteLine("You turned...");
            gummballDispenser.SetState(gummballDispenser.SoldState);
            gummballDispenser.Dispense();
        }

        public override void Refill()
        {
            Console.WriteLine("First remove the quarter");
        }

        public override void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public override string ToString()
        {
            return "waiting for turn of crank";
        }
    }
}
