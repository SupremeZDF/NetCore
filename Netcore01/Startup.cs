using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Log4Net.AspNetCore;
using Swashbuckle.AspNetCore;
using Netcore01.Moswl;

namespace Netcore01
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //注入服务
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c=> {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
                {
                    Description = "1",
                    Version = "v1.1.1",
                    Title = "1"
                });
                var pats = AppDomain.CurrentDomain.BaseDirectory;
                string s = System.IO.Path.Combine(pats, "Netcore01.xml");
                c.IncludeXmlComments(s);
            });

            services.AddScoped<iTest, Test>();
            var dd = services.BuildServiceProvider();
            {
                var nam = dd.GetService<iTest>(); //16495015
                nam.i = "dasd";
            }
            {
                var nam = dd.GetService<iTest>(); //16495015
                                                  //var d = dd.CreateScope().ServiceProvider;
                                                  //var s = d.GetService<iTest>().GetHashCode();  //14237410

            }
        }

        //启动服务
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            ILogger<Startup> logger = loggerFactory.CreateLogger<Startup>();
            logger.LogError("哈哈");
            Console.WriteLine(Configuration["d:a"]);
            Console.WriteLine(Configuration["DEJSON:0:Name"]);
            app.UseSwagger();
            app.UseSwaggerUI(c=> {
                c.SwaggerEndpoint("/swagger/v1/swagger.json","dasdasda");
            });
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
