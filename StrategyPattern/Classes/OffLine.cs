using StrategyPattern.Interfaces;

namespace StrategyPattern.Classes
{
    public class OffLine : IMobileStrategy
    {
        public void execute()
        {
            Console.WriteLine("Store Data Local");
        }
    }
}
