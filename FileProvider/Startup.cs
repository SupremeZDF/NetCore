using FileProvider.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace FileProvider
{

    public class NameLoa
    {
        public string Name { get; set; }

        public string Age { get; set; }
    }

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
            {
                var g = ",dadae3ed4,";
                var h = g.Split(",");
                //var c = new PdfExporter();
                var dd = new List<NameLoa>()
               {
                 new NameLoa(){  Age = "1" , Name = "1"},
                  new NameLoa(){  Age = "2" , Name = "1"},
                   new NameLoa(){  Age = "3" , Name = "1"},
                    new NameLoa(){  Age = "2" , Name = "1"},
                     new NameLoa(){  Age = "3" , Name = "1"}
               };

                var ww = dd.Where(x => x.Age == "2").ToList();
                ww.ForEach(x => x.Name = "2222222222222222222222222222");

                dd.ForEach(xx => xx.Age = "111111111111111111111111");
            }

            services.AddControllers();
            services.AddSwaggerGen(services =>
            {
                services.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
                {
                    Version = "v1",
                    Title = "1"
                });

                var u = AppDomain.CurrentDomain.BaseDirectory;
                var pa = System.IO.Path.Combine(u, "FileProvider.xml");
                services.IncludeXmlComments(pa);
            });

            {
                //FileInfo file =new FileInfo("");
                //DirectoryInfo directoryInfo = new DirectoryInfo("");
                //foreach (var ij in directoryInfo.GetFiles()) 
                //{
                //    ij.Directory;
                //}
                //new FileStream();
                var c = Assembly.GetExecutingAssembly();
                IServiceCollection serviceDescriptors = new ServiceCollection();
                serviceDescriptors.AddSingleton<IFileProvider>(new PhysicalFileProvider(@"E:\Ñ§Ï°\js¿ò¼Ü\Layui"));
                serviceDescriptors.AddSingleton<IFileProvider>(new EmbeddedFileProvider(Assembly.GetExecutingAssembly()));
                serviceDescriptors.AddSingleton<OneRun>();
                serviceDescriptors.AddSingleton<TwoModel>();
                var i = serviceDescriptors.BuildServiceProvider();

                //var instan = i.GetService<OneRun>();
                //instan.Conso();
                var ty = i.GetService<TwoModel>();
                var txt = ty.GetFileName(@"E:\Ñ§Ï°\js¿ò¼Ü\Layui");
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            //IFileProvider fileProvider = new FileProvider;
            app.UseHttpsRedirection();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "dasdas");
            });
            app.UseRouting();
            //app.Use();
            //ApplicationBuilder applicationBuilder = new ApplicationBuilder();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
