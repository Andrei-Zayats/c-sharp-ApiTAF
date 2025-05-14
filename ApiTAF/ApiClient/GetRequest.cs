using ApiTAF.Core.Logging;
using RestSharp;

namespace ApiTAF.ApiClient;

public class GetRequest : IApiRequest
{
    private RestClient _client;
    private RestRequest _request;
    private string baseUrl = TestConfig.Instance.Api.BaseUrl;

    public GetRequest()
    {
        Logger.Information($"Create RestClient with url: {baseUrl}");
        _client = new RestClient(baseUrl);
        _request = new RestRequest("/", Method.Get);
    }

    public IApiRequest addPath(string endpoint)
    {
        _request.Resource = endpoint;
        return this;
    }

    public IApiRequest addHeaders(Dictionary<string, string> headers)
    {
        _request.AddHeaders(headers);
        return this;
    }

    public RestResponse sendRequest()
    {
        Logger.Information($"Creat RestRequest with parameters: {_request.Parameters}");
        return _client.Execute(_request);
    }
}