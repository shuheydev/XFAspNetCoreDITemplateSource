using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace XFAspNetCoreDITemplate
{
    public class Startup
    {
        public static IServiceProvider ServiceProvider { get; set; }
        
        public static void Init()
        {

        }

        private void ConfigureServices(HostBuilderContext context,IServiceCollection services)
        {

        }
    }
}
