using ApiTAF.Core.Logging;
using RestSharp;

namespace ApiTAF.Core.Validators;

public static class ResponseValidator
{
    public static void ValidateStatusCode(RestResponse response)
    {
        Logging(response);
        Assert.That((int)response.StatusCode, Is.EqualTo(200));
    }

    private static void Logging(RestResponse response)
    {
        Logger.Information($"Response uri: {response.ResponseUri}.");
        Logger.Information($"Response status code: {(int)response.StatusCode}.");
        Logger.Information($"Response body:\n{response.Content}");
    }
    
}