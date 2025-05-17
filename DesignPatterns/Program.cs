using CommandPattern.Classes;

StockMarket stockMarket = new StockMarket();

StockAgent stockAgent = new StockAgent();

BuyShares buyShares = new BuyShares(stockMarket);
buyShares.BuyerId = 1;
buyShares.SellerId = 2;
buyShares.Price = 100;
buyShares.Count = 10;

SellShares sellShares = new SellShares(stockMarket);
sellShares.SellerId = 2;
sellShares.BuyerId = 1;
sellShares.Price = 100;
sellShares.Count = 10;

OpenCompany openCompany = new OpenCompany(stockMarket);
openCompany.Name = "Comp1";
openCompany.UserId = 1;

stockAgent.AddStockCommand(buyShares);
stockAgent.AddStockCommand(sellShares);
stockAgent.AddStockCommand(openCompany);


stockAgent.ExcuteAll();
