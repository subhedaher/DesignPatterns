using CommandPattern.Interfaces;

namespace CommandPattern.Classes
{
    public class OpenCompany : StockCommand
    {
        private readonly StockMarket stockMarket;

        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty;

        public OpenCompany(StockMarket stockMarket)
        {
            this.stockMarket = stockMarket;
        }
        public void Excute()
        {
            stockMarket.OpenCompany(UserId, Name);
        }
    }
}
