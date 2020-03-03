using System.Web;

class ValueShadowingServerVariableFix
{
    public bool isHTTPS(HttpRequest request)
    {
        string https = request.ServerVariables["HTTPS"];
        return https == "ON";
    }
}
