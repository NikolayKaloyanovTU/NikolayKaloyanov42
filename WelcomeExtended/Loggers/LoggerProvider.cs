using Microsoft.Extensions.Logging;

namespace WelcomeExtended.Loggers;

public class LoggerProvider : ILoggerProvider
{
    public LoggerProvider()
    {
        // return new HashLogger(categoryName);
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public ILogger CreateLogger(string categoryName)
    {
        throw new NotImplementedException();
    }
}