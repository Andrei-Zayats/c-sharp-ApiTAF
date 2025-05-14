using RestSharp;

namespace ApiTAF.ApiClient;

public interface IApiRequest
{
    IApiRequest addPath(string endpoint);
    IApiRequest addHeaders(Dictionary<string, string> headers);
    RestResponse sendRequest();
}