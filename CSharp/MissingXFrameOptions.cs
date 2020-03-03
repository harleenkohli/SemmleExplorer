using System;
using System.Web;

public class MissingXFrameOptions
{
    protected void Application_BeginRequest(object sender, EventArgs e)
    {
        HttpContext.Current.Response.AddHeader("X-Frame-Options", "DENY");
    }
}
