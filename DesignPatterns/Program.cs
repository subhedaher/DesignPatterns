using StrategyPattern.Classes;

LowBattery lowBattery = new LowBattery();

ChargeBattery chargeBattery = new ChargeBattery();

OffLine offLine = new OffLine();

OnLine onLine = new OnLine();


MobileOperation mobileOperation = new MobileOperation();

mobileOperation.SetCurrentStrategy(lowBattery);

mobileOperation.Process();

mobileOperation.SetCurrentStrategy(offLine);

mobileOperation.Process();

