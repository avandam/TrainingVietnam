namespace SOLID._4._ISP
{
    class AccountHolder
    {
        private IBankAccountHolder account;

        public AccountHolder()
        {
            account = new BankAccount("Peter Test", "SomeStreet 1", "12345");
        }

        public void Deposit(double amount)
        {
            account.DepositMoney(amount);
        }

        public void Transfer(double amount, BankAccount otherAccount)
        {
            account.TransferMoneyToAccount(otherAccount, amount);
        }
    }
}
