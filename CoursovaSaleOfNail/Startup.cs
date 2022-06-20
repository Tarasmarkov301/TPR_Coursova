using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using CoursovaSaleOfNail.Data.Interfaces;
using CoursovaSaleOfNail.Data.Mock;


namespace CoursovaSaleOfNail
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc();
            services.AddTransient<iReadNail, ReadNail>();
            services.AddTransient<iDataCheck, DataCheck>();
            services.AddTransient<iRWSale, RWSale>();
            services.AddTransient<iRWClient, RWClient>();
            services.AddTransient<iDBConn, DBConn>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
