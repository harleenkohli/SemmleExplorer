using System;
using System.Web;
using System.Web.Security;


public class AbandonSession
{
    public void Login(HttpContext ctx, string username, string password)
    {
        if (FormsAuthentication.Authenticate(username, password))
        {
            // BAD: Reusing the previous session
            ctx.Session["Mode"] = GetModeForUser(username);
        }
    }

    object GetModeForUser(string username)
    {
        throw new NotImplementedException();
    }
}