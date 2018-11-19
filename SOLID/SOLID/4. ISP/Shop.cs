using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4._ISP
{
    class Shop
    {
        public void CardTransaction(BankAccount account, double amount)
        {
            account.PayByCard(amount);
        }
    }
}
