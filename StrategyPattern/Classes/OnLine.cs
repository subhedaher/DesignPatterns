using StrategyPattern.Interfaces;

namespace StrategyPattern.Classes
{
    public class OnLine : IMobileStrategy
    {
        public void execute()
        {
            Console.WriteLine("Store Data Server");
        }
    }
}
