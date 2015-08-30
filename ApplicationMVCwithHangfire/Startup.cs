using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Hangfire;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ApplicationMVCwithHangfire.Startup))]

namespace ApplicationMVCwithHangfire
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //Reference connection string for data base of hangfire
            GlobalConfiguration.Configuration.UseSqlServerStorage("myConnectionString");
            app.UseHangfireServer();
            //activate dashboard of hangfire in application
            app.UseHangfireDashboard();
        }
    }
}