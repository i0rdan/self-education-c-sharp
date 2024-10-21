namespace Logger_Library.LoggerImp
{
    public class DatabaseLogger : Logger
    {
        public override LoggerDestination Destination => LoggerDestination.Database;

        protected override void WriteLogs(string message, LoggerLevel level) =>
            Console.WriteLine($"{Destination} Logger '{level} Message': {message}");
    }
}
