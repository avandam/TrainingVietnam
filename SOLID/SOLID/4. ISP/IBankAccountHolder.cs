namespace SOLID._4._ISP
{
    public interface IBankAccountHolder
    {
        void TransferMoneyToAccount(BankAccount otherAccount, double amount);
        void DepositMoney(double amount);
    }
}