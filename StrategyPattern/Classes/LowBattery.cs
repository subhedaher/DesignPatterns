using StrategyPattern.Interfaces;

namespace StrategyPattern.Classes
{
    public class LowBattery : IMobileStrategy
    {
        public void execute()
        {
            Console.WriteLine("no download, no update");
        }
    }
}
