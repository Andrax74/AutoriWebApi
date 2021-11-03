using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoriWebApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AutoriWebApi
{
    public class Startup
    {
         // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IAutoriRepository,AutoriRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //var WebAppUri = System.Environment.GetEnvironmentVariable("WEBAPP_URI");

            app.UseCors(options =>
                options
                    .AllowAnyOrigin() //TODO Da Eliminare al più presto
                    //.WithOrigins(WebAppUri)
                    //.WithMethods("POST","PUT","DELETE","GET")
                    .AllowAnyMethod()
                    .AllowAnyHeader()
            );

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
