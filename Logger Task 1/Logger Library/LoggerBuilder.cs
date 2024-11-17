using Logger_Library.LoggerImp;

namespace Logger_Library
{
    public class LoggerBuilder
    {
        public static Logger Create(LoggerDestination destination = LoggerDestination.Console) => destination switch
        {
            LoggerDestination.Console => new ConsoleLogger(),
            LoggerDestination.Database => new DatabaseLogger(),
            LoggerDestination.TextFile => new TextfileLogger(),
            _ => throw new NotImplementedException()
        };
    }
}
