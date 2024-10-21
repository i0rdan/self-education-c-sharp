using Logger_Library;

ILogger consoleLogger = LoggerBuilder.Create();
ILogger dbLogger = LoggerBuilder.Create(LoggerDestination.Database);
ILogger textFileLogger = LoggerBuilder.Create(LoggerDestination.TextFile);

ILogger[] arr = new ILogger[] {
    dbLogger,
    consoleLogger,
    textFileLogger,
};

foreach (var item in arr)
{
    item.Info("info test");
    item.Error("error test");
    item.Warning("warning test");
    item.Error(new Exception("test error"));
}

Console.ReadKey();