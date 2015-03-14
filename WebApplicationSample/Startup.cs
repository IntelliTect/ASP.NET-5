using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace WebApplicationSample
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app)
        {
           app.Run((context) =>
           {
               context.Response.StatusCode = 200;
               context.Response.ContentType = "text/plain";
               return context.Response.WriteAsync("Hello World");
           });
        }
    }
}
