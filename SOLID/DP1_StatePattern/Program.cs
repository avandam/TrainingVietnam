using System;

namespace DP1_StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(2);
            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.InsertQuarter();

            Console.Read();
        }
    }
}
