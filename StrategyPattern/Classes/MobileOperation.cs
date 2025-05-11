using StrategyPattern.Interfaces;

namespace StrategyPattern.Classes
{
    public class MobileOperation
    {
        private IMobileStrategy strategy;

        public void SetCurrentStrategy(IMobileStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Process()
        {
            strategy.execute();
        }

    }
}
