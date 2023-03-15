using Microsoft.Extensions.Logging;
using WelcomeExtended.Loggers;

namespace WelcomeExtended.Helpers;

public static class LoggerHelper
{
    public static ILogger GetLogger(string categoryName)
    {
        var loggerFactory = new LoggerFactory();
        
        loggerFactory.AddProvider(new LoggerProvider(categoryName));
        return loggerFactory.CreateLogger(categoryName);
    }
}