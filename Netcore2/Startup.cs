using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Netcore2.Controllers;
using Netcore2.Instance;
using Netcore2.Interface;
using Swashbuckle.AspNetCore;
using Autofac.Extensions.DependencyInjection;
using Autofac;
using Netcore2.Tool;
using Netcore2.Middleware;

namespace Netcore2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddControllers();
            services.AddControllers().AddControllersAsServices();
            services.AddMvc(o =>
            {
                o.Filters.Add(typeof(ExceptionFilter));
                o.Filters.Add(typeof(CustomerResouceAttrbute));
            }).AddRazorRuntimeCompilation(); //动态编译
            services.AddSwaggerGen(services =>
            {
                services.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
                {
                    Version = "v1",
                    Title = "1"
                });

                var u = AppDomain.CurrentDomain.BaseDirectory;
                var pa = System.IO.Path.Combine(u, "Netcore2.xml");
                services.IncludeXmlComments(pa);
            });
            services.AddScoped<IoneTestA, OneTestA>();
            services.AddSingleton<IOnetestB, OnetestB>();

            ContainerBuilder configurationBuilder = new ContainerBuilder() { };

            //configurationBuilder.RegisterType<OneTestA>().As<IoneTestA>();
            //configurationBuilder.RegisterType<OnetestB>().As<IOnetestB>();
            //configurationBuilder.RegisterType<OnetestC>().As<IOnetestC>();
            ////configurationBuilder.RegisterType<OnetestD>().As<IOnetestD>();
            //configurationBuilder.RegisterModule<ContainerBuiderModel>();
            //IContainer container = configurationBuilder.Build();
            //configurationBuilder.Populate(services); //容器迁移
            //return
            //var c = new AutofacServiceProvider(container);
            //return c;
        }

        public void ConfigureContainer(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule<ContainerBuiderModel>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            #region
            //app.Map("/test", Name);

            //app.MapWhen();

            //app.Use();
            //app.Run();
            //app.Use();

            //app.UseWhen()

            //Func<int, Task<int>> func = async c => { return await Task.Run(()=> { return 1; }); };
            #endregion

            app.UseMiddleware<OneModelWale>();
            app.UseMiddleware<TwoMiddleware>();
            app.UseMiddleware<ThreeMiidleWale>();
            //C:\Program Files\dotnet\packs\Microsoft.AspNetCore.App.Ref\3.1.8\ref\netcoreapp3.1\Microsoft.AspNetCore.Http.dll
            //ApplicationBuilder
            app.Use(c =>
            {
                Console.WriteLine("dasdasd");
                return async x =>
                {

                    Console.WriteLine("xxx");
                    await c.Invoke(x);
                    Console.WriteLine("xxx");

                };
            });
            //app.Run
            Func<int, int, int> func = (c, x) => { return c + x; };


            app.Map("/map", x => { x.Use(y => { Console.WriteLine("xxx"); return async u => { Console.WriteLine("xxx"); await y.Invoke(u); Console.WriteLine("xxxx"); }; }); });

            app.MapWhen(x => x.Request.Query.ContainsKey("Name"), x => { x.Use(y => { Console.WriteLine(); return async u => { Console.WriteLine("xxx"); await y.Invoke(u); Console.WriteLine("xxx"); }; }); });

            app.Use(async (x, c) =>
            {

                Console.WriteLine("x");
                await c.Invoke();
                Console.WriteLine("x");
            });

            app.UseWhen(
                x =>
                {
                    return x.Request.Query.ContainsKey("name");
                },
                x =>
             {
                 x.Use(c =>
                 {
                     Console.WriteLine("xxxx");
                     return async x =>
                     {
                         Console.WriteLine("xxxx");
                         await c.Invoke(x);   //下一个委托
                        Console.WriteLine("xxxxx");
                     };
                 });
             });

            app.Use(c =>
            {
                Console.WriteLine("xxxx");
                return async x =>
                {
                    Console.WriteLine("xxxx");
                    await c.Invoke(x);
                    Console.WriteLine("xxxx");
                };
            });
            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "dasdas");
            });

            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public void Name(IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Run(async c =>
            {
                Console.WriteLine("终结点结束");
            });
        }
    }
}
