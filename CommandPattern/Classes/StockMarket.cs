namespace CommandPattern.Classes
{
    public class StockMarket
    {
        public void BuyShares(int buyerId, int sellerId, int count, int price)
        {
            Console.WriteLine($"{sellerId} , {sellerId} , {count}, {price}");
        }

        public void SellShares(int buyerId, int sellerId, int count, int price)
        {
            Console.WriteLine($"{buyerId} , {sellerId} , {count}, {price}");
        }

        public void OpenCompany(int userId, string name)
        {
            Console.WriteLine($"{userId} , {name}");
        }
    }
}
