namespace SOLID._4._ISP
{
    class Shop
    {
        public void CardTransaction(IBankAccountShop account, double amount)
        {
            account.PayByCard(amount);
        }
    }
}
