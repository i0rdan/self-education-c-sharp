namespace Logger_Library
{
    public abstract class Logger : ILogger
    {
        public abstract LoggerDestination Destination
        {
            get;
        }

        public virtual void Error(Exception ex)
        {
            WriteLogs(ex.Message, LoggerLevel.Error);
        }

        public virtual void Error(string message)
        {
            WriteLogs(message, LoggerLevel.Error);
        }

        public virtual void Info(string message)
        {
            WriteLogs(message, LoggerLevel.Info);
        }

        public virtual void Warning(string message)
        {
            WriteLogs(message, LoggerLevel.Warning);
        }

        protected abstract void WriteLogs(string message, LoggerLevel level);
    }
}