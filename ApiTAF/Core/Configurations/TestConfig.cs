using ApiTAF.Core.Configurations;
using ApiTAF.Core.Logging;
using Newtonsoft.Json;

public class TestConfig
{
    private static TestConfig _instance;
    public static TestConfig Instance => _instance ??= LoadConfig();
    public ApiConfig Api { get; set; }
    public AppConfig App { get; set; }

    private static string EnvironmentName
    {
        get
        {
            if (Environment.GetEnvironmentVariable("TEST_ENV") == null)
            {
                Logger.Information("Environment variable 'TEST_ENV' not found.");
                Logger.Information("Environment variable 'TEST_ENV' set default value 'dev'.");
                return "dev";
            }
            Logger.Information("Environment variable 'TEST_ENV' found.");
            return Environment.GetEnvironmentVariable("TEST_ENV");
        }
    }

    private static TestConfig LoadConfig()
    {
        try
        {
            var configText = File.ReadAllText($"config.{EnvironmentName}.json");
            Logger.Information("Config file was found.");
            return JsonConvert.DeserializeObject<TestConfig>(configText);
        }
        catch (IOException e)
        {
            Logger.Error("Config file error: ", e);
            throw;
        }
    }
}