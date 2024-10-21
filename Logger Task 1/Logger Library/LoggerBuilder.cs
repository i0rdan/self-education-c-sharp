using Logger_Library.LoggerImp;

namespace Logger_Library
{
    public class LoggerBuilder
    {
        public static Logger Create()
        {
            return new ConsoleLogger();
        }

        public static Logger Create(LoggerDestination destination) { 
            switch (destination)
            {
                case LoggerDestination.Console:
                {
                    return new ConsoleLogger();
                }
                case LoggerDestination.Database:
                {
                    return new DatabaseLogger();
                }
                case LoggerDestination.TextFile:
                {
                    return new TextfileLogger();
                }
                default:
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
