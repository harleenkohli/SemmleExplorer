using System.Web;
using System.Xml;

public class XMLHandler : IHttpHandler {
    public bool IsReusable => throw new System.NotImplementedException();

    public void ProcessRequest(HttpContext ctx) {
    // BAD: XmlTextReader is insecure by default, and the payload is user-provided data
    XmlTextReader reader = new XmlTextReader(ctx.Request.QueryString["document"]);
  }
}

