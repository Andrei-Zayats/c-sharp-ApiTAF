namespace ApiTAF.ApiClient;

public interface IApiBody
{
    IApiRequest withBody(object body);
}