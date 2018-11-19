namespace SOLID._5._DIP
{
    class AccountHolder
    {
        private Account account;

        public AccountHolder()
        {
            account = new Account("Peter Test", "SomeStreet 1", "12345");
        }

        public void Deposit(double amount)
        {
            account.DepositMoney(amount);
        }

        public void Transfer(double amount, Account otherAccount)
        {
            account.TransferMoneyToAccount(otherAccount, amount);
        }
    }
}
