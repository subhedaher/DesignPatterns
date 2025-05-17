using CommandPattern.Interfaces;

namespace CommandPattern.Classes
{
    public class BuyShares : StockCommand
    {
        private readonly StockMarket stockMarket;
        public int BuyerId { get; set; }
        public int SellerId { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }

        public BuyShares(StockMarket stockMarket)
        {
            this.stockMarket = stockMarket;
        }

        public void Excute()
        {
            stockMarket.BuyShares(BuyerId, SellerId, Count, Price);
        }
    }
}
