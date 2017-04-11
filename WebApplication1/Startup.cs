using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace WebApplication1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())//is middleware
            {
                app.UseDeveloperExceptionPage();
            }


           app.UseFileServer(enableDirectoryBrowsing: env.IsDevelopment());// also turns on directory browser when looking at browser

            /*Extension Methods
             * Feature and Property of Extension Methods 
                The following list contains basic features and properties of extension methods:

                It is a static method.
                It must be located in a static class.
                It uses the "this" keyword as the first parameter with a type in .NET and this method will be called by a given type instance on the client side.
                It also shown by VS intellisense. When we press the dot (.) after a type instance, then it comes in VS intellisense.
                An extension method should be in the same namespace as it is used or you need to import the namespace of the class by a using statement.
                You can give any name for the class that has an extension method but the class should be static.
                If you want to add new methods to a type and you don't have the source code for it, then the solution is to use and implement extension methods of that type.
                If you create extension methods that have the same signature methods as the type you are extending, then the extension methods will never be called.
                */
           // app.UseDefaultFiles();//turns off the secret hello file to use your files
           // app.UseStaticFiles();//triggers the index.html to "flip on" in ASP.NET everything is off by default and controlled by this middleware
            

            app.Run(async (context) =>
            {
                //throw new Exception("FUCK YOU IT'S BROKEN!!!!");
                await context.Response.WriteAsync($"Hello {env.EnvironmentName}");
            });
        }
    }
}
