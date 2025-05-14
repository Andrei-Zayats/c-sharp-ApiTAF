using Allure.Net.Commons;
using Allure.NUnit;
using Allure.NUnit.Attributes;
using ApiTAF.ApiClient;
using ApiTAF.Core.Validators;
using ApiTAF.Tests;
using RestSharp;

[Parallelizable(ParallelScope.All)]
[AllureNUnit]
[AllureEpic("Api Tests")]
[AllureFeature("Base Api Tests")]
public class Tests : BaseTest
{
    
    [TestCase(3)]
    [TestCase(1)]
    [AllureSeverity(SeverityLevel.critical)]
    [AllureTag("API", "Smoke")]
    [AllureStory("Get Endpoint Should Return Success")]
    public void GetEndpoint_ShouldReturnSuccess(int timeout)
    {
        var response = new ApiRequestFactory().CreateRequest(Method.Get).addPath($"/delay/{timeout}").sendRequest();
        ResponseValidator.ValidateStatusCode(response);
    }
    
    [TestCase(3)]
    [TestCase(1)]
    [AllureSeverity(SeverityLevel.normal)]
    [AllureTag("API", "Smoke")]
    [AllureStory("Post Endpoint Should Return Success")]
    public void PostEndpoint_ShouldReturnCreated(int timeout)
    {
        var response = new ApiRequestFactory().CreateRequest(Method.Post).addPath($"/delay/{timeout}").sendRequest();
        ResponseValidator.ValidateStatusCode(response);
    }
}