namespace Logger_Library.LoggerImp
{
    public class ConsoleLogger : Logger
    {
        public override LoggerDestination Destination => LoggerDestination.Console;

        protected override void WriteLogs(string message, LoggerLevel level)
        {
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Logger: {Destination}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
