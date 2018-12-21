namespace SOLID._4._ISP
{
    public interface IBankAccountBank
    {
        string AccountNumber { get; }
        void ChangeName(string newName);
        void ChangeAddress(string newAddress);
        void ReceiveMoneyFromAccount(double amount);
    }
}