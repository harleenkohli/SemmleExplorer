using System.Web;

class ValueShadowing
{
    public bool checkCSRF(HttpRequest request)
    {
        string postCSRF = request["csrf"];
        string cookieCSRF = request.Cookies["csrf"].ToString();
        return postCSRF.Equals(cookieCSRF);
    }
}
