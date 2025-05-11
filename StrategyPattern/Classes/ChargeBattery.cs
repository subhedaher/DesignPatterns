using StrategyPattern.Interfaces;

namespace StrategyPattern.Classes
{
    public class ChargeBattery : IMobileStrategy
    {
        public void execute()
        {
            Console.WriteLine("download, update");
        }
    }
}
