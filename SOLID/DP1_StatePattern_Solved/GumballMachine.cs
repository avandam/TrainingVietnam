using System;
using System.Resources;
using System.Text;

namespace DP1_StatePattern_Solved
{
    public class GumballMachine
    {
        public State HasQuarterState { get; }
        public State NoQuarterState { get;  }
        public State SoldOutState { get;  }
        public State SoldState { get;  }

        private State state;
        public int Count { get; private set; }

        public GumballMachine(int count)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            this.Count = count;
            if (count > 0)
            {
                state = NoQuarterState;
            }
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        public void TurnCrank()
        {
            state.TurnCrank();
        }

        public void Dispense()
        {
            state.Dispense();
        }


        public void Refill()
        {
            state.Refill();
        }

        public void RefillMachine(int numGumBalls)
        {
            Count = numGumBalls;
            state = NoQuarterState;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count != 0)
            {
                Count--;
            }
        }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");

            result.Append("Inventory: " + Count + " gumball");
            if (Count != 1)
            {
                result.Append("s");
            }
            result.Append("\nMachine is ");
            result.Append(state.ToString());
            result.Append("\n");
            return result.ToString();
        }

        public void SetState(State newState)
        {
            state = newState;
        }
    }
}
