using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2_ObserverPattern_Solved
{
    public interface IObserver
    {
        void Update(int temperature, int humidity, int pressure);
    }
}
