using RestSharp;

namespace ApiTAF.ApiClient;

public class PostRequest : IApiRequest, IApiBody
{
    private RestClient _client;
    private RestRequest _request;
    private string baseUrl = TestConfig.Instance.Api.BaseUrl;
    
    public PostRequest()
    {
        _client = new RestClient(baseUrl);
        _request = new RestRequest("/", Method.Post);
    }
    
    public IApiRequest withBody(object body)
    {
        _request.AddJsonBody(body);
        return this;
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
        return _client.Execute(_request);
    }
}