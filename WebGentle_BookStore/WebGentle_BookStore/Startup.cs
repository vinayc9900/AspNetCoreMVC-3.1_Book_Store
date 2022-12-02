using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebGentle_BookStore.Data;
using WebGentle_BookStore.Repository;

namespace WebGentle_BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
          //  services.AddMvc(); // Tells that we are adding MVC To Application
            services.AddControllersWithViews();
            services.AddDbContext<BookStoreContext>(
                options=>options.UseSqlServer("Server=.\\SQLEXPRESS;Database=BookStore;Integrated Security=True;"));

            #if DEBUG   // Only apply for Development Environment
             services.AddRazorPages().AddRazorRuntimeCompilation();//For  Razor file compilation 

            //plz dont use below code for 'Production Environment' bcz it disabled client-side validation 
            //services.AddRazorPages().AddRazorRuntimeCompilation().AddViewOptions(options => {
            //    options.HtmlHelperOptions.ClientValidationEnabled = false; // now it will not do client-side validation
            //}) ; 
             #endif

            services.AddScoped<BookRepository, BookRepository>(); //Dependency Injection
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // To use Static files like images,css from Static Directory etc

            app.UseStaticFiles(); // For wwwroot static Directory
            app.UsePathBase("/css");// Reads the css/Site.css file
            //app.UseStaticFiles(new StaticFileOptions
            //{
            //    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "MyStaticFiles")),
            //    RequestPath = "/MyStaticFiles"

            //});

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

                //endpoints.MapControllerRoute(   // Use while Working With anchor Tag Helper
                //        name:"Default",
                //        pattern:"bookApp/{controller=Home}/{action=Index}/{id?}"
                //    );

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
