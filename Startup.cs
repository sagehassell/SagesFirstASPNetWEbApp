using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SagesFirstASPNetWEbApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //Add a nice arror page
            }
            
            app.UseNodeModules();
            //ordermatters for these 2
            //app.UseDefaultFiles(); //sends it straight to the index.html
            app.UseStaticFiles();  //allows us to use files in our subdirectories. 
            
            app.UseRouting(); //this means we no longer want users to have to type in the exact name of the page
            
            app.UseEndpoints(cfg =>
            {
                app.UseDeveloperExceptionPage();
                cfg.MapControllerRoute("Default",
                    "{controller}/{action}/{id?}",
                    new { controller = "Home", action = "Index" });
            }
            );
        }
    }
}
