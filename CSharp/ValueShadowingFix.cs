using System.Web;

class ValueShadowingFix
{
    public bool checkCSRF(HttpRequest request)
    {
        string postCSRF = request.Form["csrf"];
        string cookieCSRF = request.Cookies["csrf"].ToString();
        return postCSRF.Equals(cookieCSRF);
    }
}
