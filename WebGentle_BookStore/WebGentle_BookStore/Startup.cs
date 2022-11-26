using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGentle_BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
          //  services.AddMvc(); // Tells that we are adding MVC To Application
            services.AddControllersWithViews();  //
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async (context, next) =>   // Middleware 1
            //{
            //    await context.Response.WriteAsync("This is Book Store First Middleware Application");
            //    await next();// Point/Execute the Next middleware

            //    await context.Response.WriteAsync("This is Book Store in First Middleware after Executing Second Middleware ");
            //});

            //app.Use(async (context, next) =>   //Middleware 2
            //{
            //    await context.Response.WriteAsync("This is Book Store Second Middleware Application");
            //    await next();// Point/Execute the Next middleware

            //    await context.Response.WriteAsync("This is Book Store in Second Middleware after Executing Third Middleware ");
            //});

            //app.Use(async (context, next) =>   // Middleware 3
            //{
            //    await context.Response.WriteAsync("This is Book Store Third Middleware Application");
            //    await next();
            //});

            app.UseRouting();  // This must be Placed First Among all following End Points

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapDefaultControllerRoute();// Telling to Start with Controller

                //endpoints.MapGet("/", async context =>   // MapGet can handle only Get Response 
                //{
                //   // if(env.IsDevelopment()) //if(env.IsDevelopment("Development"))
                //   // {
                //   //     await context.Response.WriteAsync("Hello Development");
                //   // }
                //   //else if (env.IsProduction())
                //   // {
                //   //     await context.Response.WriteAsync("Hello Production");
                //   // }
                //   // else if (env.IsStaging())
                //   // {
                //   //     await context.Response.WriteAsync("Hello Staging");
                //   // }
                //   // else
                //   // await context.Response.WriteAsync(env.EnvironmentName);
                  
                //});
            });
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/vinay", async context =>  // Map will handle all Responses plz use /vinay in URL
            //    {
            //        await context.Response.WriteAsync("Hello Vinay!");
            //    });
            //});
        }
    }
}
