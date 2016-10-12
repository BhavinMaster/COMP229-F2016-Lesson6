using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

//required for owin startup
using Microsoft.AspNet.Identity;    //authorisation
using Microsoft.Owin.Security.Cookies; //use owin

[assembly: OwinStartup(typeof(COMP229_F2016_Lesson6.Startup1))]

namespace COMP229_F2016_Lesson6
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Login.aspx")
            });
        }
    }
}
