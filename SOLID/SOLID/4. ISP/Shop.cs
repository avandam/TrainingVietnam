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
