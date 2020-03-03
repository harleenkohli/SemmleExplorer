using System.Web;

class ValueShadowingServerVariable
{
    public bool IsHttps(HttpRequest request)
    {
        string https = request["HTTPS"];
        return https == "ON";
    }
}
