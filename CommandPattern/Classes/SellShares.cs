using CommandPattern.Interfaces;

namespace CommandPattern.Classes
{
    public class SellShares : StockCommand
    {
        private readonly StockMarket stockMarket;
        public int SellerId { get; set; }
        public int BuyerId { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }

        public SellShares(StockMarket stockMarket)
        {
            this.stockMarket = stockMarket;
        }

        public void Excute()
        {
            stockMarket.SellShares(BuyerId, SellerId, Count, Price);
        }
    }
}
