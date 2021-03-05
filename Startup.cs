using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebLiveChat.Startup))]
namespace WebLiveChat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();

        }
    }
}
