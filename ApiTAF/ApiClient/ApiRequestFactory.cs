using RestSharp;

namespace ApiTAF.ApiClient;

public class ApiRequestFactory
{
    public IApiRequest CreateRequest(Method method) => method switch
    {
        Method.Get => new GetRequest(),
        Method.Post => new PostRequest(),
        Method.Put => new PutRequest(),
        Method.Patch => new PatchRequest(),
        Method.Delete => new DeleteRequest(),
        _ => throw new ArgumentException("Unsupported HTTP method")
    };
}
