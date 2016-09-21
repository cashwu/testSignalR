using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(testSignalR.Startup))]

namespace testSignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR<TrackerConnection>("/tracker");
        }
    }
}
