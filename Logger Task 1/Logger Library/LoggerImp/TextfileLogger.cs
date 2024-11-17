namespace Logger_Library.LoggerImp
{
    public class TextfileLogger : Logger
    {
        public override LoggerDestination Destination => LoggerDestination.TextFile;

        protected override void WriteLogs(string message, LoggerLevel level)
        {
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"My {Destination} Logger: {message}");
        }
    }
}
