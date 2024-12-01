## Logger

### Short Description
Create a simple Logger.

### Requirements
1. Code style
2. Create a class Logger which implements the next interface:
    ```cs
    public interface ILogger
    {
      void Error(string message);
      void Error(Exception ex);
      void Warning(string message);
      void Info(string message);
    }
    ```
3. Logger should be able to write logs to different destinations (console, text file, database etc.)
4. If there are no logging destinations provided, logger should write logs to console
5. Logger and each of logging destinations should be configurable to write logs of particular level (Error, Warning, Info)
