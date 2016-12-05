using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using Reindawn.Domain.Models;
using Reindawn.Repository.Context;

[assembly: OwinStartup(typeof(ReindawnApi.Startup))]
namespace ReindawnApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
        
    }
}