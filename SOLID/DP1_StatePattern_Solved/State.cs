using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_StatePattern_Solved
{
    public abstract class State
    {
        public abstract void InsertQuarter();
        public abstract void EjectQuarter();
        public abstract void TurnCrank();
        public abstract void Refill();
        public abstract void Dispense();
    }
}
