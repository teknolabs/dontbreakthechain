using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TeknoLabs.DontBreakTheChain.Business;
using TeknoLabs.DontBreakTheChain.DataAccess;
using TeknoLabs.DontBreakTheChain.DataAccess.EntityFramework;
using TeknoLabs.DontBreakTheChain.WebUI.Middlewares;

namespace TeknoLabs.DontBreakTheChain.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IHabitService, HabitManager>();
            services.AddScoped<IHabitDal, EfHabitDal>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseNodeModules(env.ContentRootPath); 

            app.UseMvcWithDefaultRoute();
        }
    }
}
