using RestSharp;

namespace ApiTAF.ApiClient;

public class PutRequest : IApiRequest, IApiBody
{
    public IApiRequest addPath(string endpoint)
    {
        throw new NotImplementedException();
    }

    public IApiRequest addHeaders(Dictionary<string, string> headers)
    {
        throw new NotImplementedException();
    }

    public RestResponse sendRequest()
    {
        throw new NotImplementedException();
    }

    public IApiRequest withBody(object body)
    {
        throw new NotImplementedException();
    }
}