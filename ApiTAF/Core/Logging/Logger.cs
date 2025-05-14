using Serilog;

namespace ApiTAF.Core.Logging;

public static class Logger
{
    static Logger()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("Logs\\log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();
    }

    public static void Information(string message)
    {
        Log.Information(message);
    }

    public static void Error(string message, Exception ex)
    {
        Log.Error(ex, message);
    }
}