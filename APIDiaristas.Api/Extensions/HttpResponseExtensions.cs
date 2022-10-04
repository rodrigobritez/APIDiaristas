namespace APIDiaristas.Api.Extensions;

public static class HttpResponseExtensions
{
    public static void AddApplicationError(this HttpResponse response, string message)
    {
        response.Headers.Add("Application-Error", message);
        response.Headers.Add("access-control-expose-headers", "Application-Error"); // CORS
    }
}