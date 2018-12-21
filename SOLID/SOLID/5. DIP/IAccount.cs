namespace SOLID._5._DIP
{
    public interface IAccount
    {
        string Name { get; }
        string Address { get; }
        string AccountNumber { get; }
        double Balance { get; }
        void TransferMoneyToAccount(double amount, Account targetAccount);
        void ReceiveMoneyFromAccount(double amount, Account sourceAccount);
        void DepositMoney(double amount);
    }
}