using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4._ISP
{
    public class BankAccount
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string AccountNumber { get; }
        public double Balance { get; private set; }

        public BankAccount(string name, string address, string accountNumber)
        {
            Name = name;
            Address = address;
            AccountNumber = accountNumber;
            Balance = 0;
        }

        public void ChangeName(string newName)
        {
            Name = newName;
        }

        public void ChangeAddress(string newAddress)
        {
            Address = newAddress;
        }

        public void TransferMoneyToAccount(BankAccount otherAccount, double amount)
        {
            otherAccount.ReceiveMoneyFromAccount(amount);
            Balance -= amount;
        }

        public void ReceiveMoneyFromAccount(double amount)
        {
            Balance += amount;
        }

        public void PayByCard(double amount)
        {
            Balance -= amount;
        }

        public void DepositMoney(double amount)
        {
            Balance += amount;
        }
    }
}
