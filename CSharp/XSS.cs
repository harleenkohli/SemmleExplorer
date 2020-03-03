using System;
using System.Web;

public class XSSHandler : IHttpHandler {
    public bool IsReusable => throw new NotImplementedException();

    public void ProcessRequest(HttpContext ctx) {
    ctx.Response.Write(
        "The page \"" + ctx.Request.QueryString["page"] + "\" was not found.");
  }
}
