using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Web;

public class LogForgingHandler : IHttpHandler {
  private ILogger logger;

    public bool IsReusable => throw new NotImplementedException();

    public void ProcessRequest(HttpContext ctx) {
    String username = ctx.Request.QueryString["username"];
    // BAD: User input logged as-is
    logger.LogWarning(username + " log in requested.");

    // GOOD: User input logged with new-lines removed
    logger.LogWarning(username.Replace(Environment.NewLine, "") + " log in requested");
  }
}
