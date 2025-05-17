using CommandPattern.Interfaces;

namespace CommandPattern.Classes
{
    public class StockAgent
    {
        private readonly List<StockCommand> stockCommands;

        public StockAgent()
        {
            stockCommands = new List<StockCommand>();
        }

        public void AddStockCommand(StockCommand command)
        {
            stockCommands.Add(command);
        }

        public void ExcuteAll()
        {
            foreach (var command in stockCommands)
                command.Excute();
        }
    }
}
