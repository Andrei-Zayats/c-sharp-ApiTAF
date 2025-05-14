using ApiTAF.Core.Logging;

namespace ApiTAF.Tests;

public class BaseTest
{
    [SetUp]
    public void Setup()
    {
        Logger.Information($"SetUp test: {TestContext.CurrentContext.Test.Name}");
    }
    
    [TearDown]
    public void TearDown()
    {
        Logger.Information($"TearDown test: {TestContext.CurrentContext.Test.Name}");
    }
    
}