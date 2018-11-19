namespace SOLID._5._DIP
{
    public class Account
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string AccountNumber { get; }
        public double Balance { get; private set; }

        public Account(string name, string address, string accountNumber)
        {
            Name = name;
            Address = address;
            AccountNumber = accountNumber;
            Balance = 0;
        }

        public void TransferMoneyToAccount(Account otherAccount, double amount)
        {
            otherAccount.ReceiveMoneyFromAccount(amount);
            Balance -= amount;
        }

        public void ReceiveMoneyFromAccount(double amount)
        {
            Balance += amount;
        }

        public void DepositMoney(double amount)
        {
            Balance += amount;
        }
    }
}
