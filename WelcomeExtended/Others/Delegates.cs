using Microsoft.Extensions.Logging;
using WelcomeExtended.Helpers;

namespace WelcomeExtended.Others;

public class Delegates
{
    private static readonly ILogger Logger = LoggerHelper.GetLogger("UserDisplay Logger");

    public static void Log(string error)
    {
        Logger.LogError(error);
    } 
    
    public static void Log2(string error)
    {
        Console.WriteLine("- DELEGATES -");
        Console.WriteLine($"{error}");
        Console.WriteLine("- DELEGATES -");
    }

    public delegate void ActionOnError(string errorMessage);
    
}