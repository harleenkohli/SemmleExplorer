using Microsoft.AspNet.Identity;
using System;
using System.Web;
using System.Web.Security;

public class HardCodedCredentialHandler : IHttpHandler {
    public bool IsReusable => throw new NotImplementedException();

    public void ProcessRequest(HttpContext ctx) {
    string password = ctx.Request.QueryString["password"];

    // BAD: Inbound authentication made by comparison to string literal
    if (password == "myPa55word") {
      ctx.Response.Redirect("login");
    }

    string hashedPassword = loadPasswordFromSecretConfig();

        // GOOD: Inbound authentication made by comparing to a hash password from a config

        var passwordHasher = new PasswordHasher();

        if (passwordHasher.VerifyHashedPassword(hashedPassword, password) == PasswordVerificationResult.Success)
        {
            ctx.Response.Redirect("login");
        }

    // BAD: Set the password to a hardcoded string literal
    // MembershipUser user = loadMembershipUser();
    // user.ChangePassword(password, "myNewPa55word");
  }

    private string loadPasswordFromSecretConfig()
    {
        throw new NotImplementedException();
    }
}
