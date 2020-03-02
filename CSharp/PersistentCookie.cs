using System;
using System.Web;

namespace System.Web {
    public class HttpCookie {
        public HttpCookie(string name) {}
        public string Value { set {} }
        public DateTime Expires { set {} }
    }
}

namespace PersistentCookie
{
    class Main
    {
        static public void AddCookie() {
            HttpCookie aCookie = new HttpCookie("lastVisit");
            aCookie.Value = DateTime.Now.ToString();
            aCookie.Expires = DateTime.Now.AddDays(1);  // VIOLATION
            aCookie.Expires = DateTime.Now.Add(new TimeSpan(1000));  // VIOLATION
            aCookie.Expires = DateTime.Now.AddMinutes(10);  // VIOLATION
            aCookie.Expires = DateTime.Now.AddMinutes(-10.9);  // NON-VIOLATION
            aCookie.Expires = DateTime.Now.AddSeconds(109);  // NON-VIOLATION
            aCookie.Expires = DateTime.Now;  // NON-VIOLATION
        }
    }
}
