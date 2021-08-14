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
using Microsoft.AspNetCore.Builder.Extensions;
using System.Security.Claims;
using System.Reflection;
using AssemblyModel.Model;
using Netcore2.AutoReflection;
using Microsoft.Extensions.Options;
using AssemblyModel.DataModel;
using AssemblyModel.Run;

namespace Netcore2
{

    public class YUI<T>
    {

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
                //Assembly assembly = null;
                //var c = Assembly.GetAssembly(typeof(ExceptionFilter)).Location;
                //var cc = Assembly.GetAssembly(typeof(ExceptionFilter))!.GetTypes().Count();
                //var ts = Assembly.GetAssembly(typeof(ExceptionFilter))?.GetName().Name;
                //var tss = Assembly.Load(Assembly.GetAssembly(typeof(ExceptionFilter))?.GetName()).GetTypes().Where(x=>x.Name == "ExceptionFilter").FirstOrDefault();
                //var yus = Assembly.GetAssembly(typeof(ExceptionFilter)).GetTypes().Where(x => x.Name == "ExceptionFilter").FirstOrDefault();
                //services.AddControllers();
                //var c = typeof(IOneReflectionB).GetInterfaces();
                //var a = Assembly.GetAssembly(typeof(TwoReflection)).GetTypes().Count();
                //var b = Assembly.Load(Assembly.GetAssembly(typeof(TwoReflection))?.GetName()).GetTypes().Count();
                //var c = Assembly.GetAssembly(typeof(TwoReflection))?.GetName().Name;
                //var g = Assembly.Load(Assembly.GetAssembly(typeof(TwoReflection))?.GetName().Name).GetTypes().Where(x => x.Name == "Assmmodel").FirstOrDefault();
                //var gg = Assembly.GetAssembly(typeof(TwoReflection));
                //var g = new ServiceCollection();
                {

                    //var ts = gg.Location;
                    //ts = gg.CodeBase;
                    //services.AddSingleton<TwoReflection>();
                    ////services.AddScoped<ExceptionFilter>();

                    //var tto = services.BuildServiceProvider();
                    //var intance = tto.CreateScope().ServiceProvider.GetService<TwoReflection>();
                    //intance.Name = "123";
                    //Console.WriteLine(intance.GetHashCode());
                    //var gggu = tto.CreateScope().ServiceProvider.GetService<TwoReflection>();
                    //var biu = tto.CreateScope().ServiceProvider;
                    //Console.WriteLine(gggu.GetHashCode());
                    //var bi = 1;
                    {
                        //ServiceCollection serviceDescriptors = new ServiceCollection();
                        //var hu = tto.GetService<ExceptionFilter>();
                        //hu.Name = "432";
                        //Console.WriteLine(hu.GetHashCode());
                        //Console.WriteLine(services.BuildServiceProvider().CreateScope().ServiceProvider.GetService<ExceptionFilter>().GetHashCode());
                    }
                    {
                        //var hu = tto.GetService<ExceptionFilter>();
                        //hu.Name = "432";
                        //Console.WriteLine(hu.GetHashCode());
                        //Console.WriteLine(services.BuildServiceProvider().CreateScope().ServiceProvider.GetService<ExceptionFilter>().GetHashCode());
                    }
                }
                //var d = Assembly.Load(Assembly.GetAssembly(typeof(ExceptionFilter))?.GetName()).GetTypes().Where(x => x.GetInterface("IOneReflection") != null).ToList();
                //var dd = d.Count();
                //var uo = typeof(ui).IsClass;
                //services.AddOptions();
                //services.Configure<OneTest>(Configuration.GetSection("www"));
                ////var yuis = typeof(YUI<string>).IsClass;
                //var fyt = services.Where(x => x.ServiceType.Name == "AutofacController").FirstOrDefault();
                //var tt = services.Where(x => x.ServiceType.Name == "AutofacController").FirstOrDefault();
                //services.AddScoped<IoneTestA, OneTestA>();
                //services.AddSingleton<IOnetestB, OnetestB>();
                //ContainerBuilder configurationBuilder = new ContainerBuilder() { };
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
                //List<Assmmodel> assmmodels = new List<Assmmodel>();
                //var t = assmmodels.GetHashCode(); //1707556
                //assmmodels.Add(new Assmmodel());
                //assmmodels.Add(new Assmmodel());
                //assmmodels.Add(new Assmmodel());
                //assmmodels.Add(new Assmmodel());
                //assmmodels.Add(new Assmmodel());
                //assmmodels.Add(new Assmmodel());
                //t = assmmodels.GetHashCode(); //1707556
                //Name(assmmodels);
                //t = assmmodels.GetHashCode();
                //var uu = assmmodels;
                //var yu = services.Where(x => x.ServiceType.Name == "IApplicationBuilder").FirstOrDefault();
                //var yusw = services.Where(x => x.ServiceType.Name == "IWebHostEnvironment").FirstOrDefault();
            }

            services.AddControllers().AddControllersAsServices();
            services.AddMvc(o =>
            {
                o.Filters.Add(typeof(ExceptionFilter));
                o.Filters.Add(typeof(CustomerResouceAttrbute));
                o.Filters.Add(typeof(AuthorizationFilter));
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

            {
                //var ser = new ServiceCollection();
                ////var d = ser.BuildServiceProvider().GetService<OneTest>();
                //ser.AddTransient<IoneTestA, OneTestA>();
                //ser.AddTransient<IOnetestB, OnetestB>();
                //ser.AddTransient<IOnetestC, OnetestC>();
                //var f = new ContainerBuilder();
                //f.Populate(ser);
                //f.RegisterType<OneTest>().As<IoneTestA>().InstancePerLifetimeScope().PropertiesAutowired();
                //f.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).Where(x => x.BaseType == typeof(OneTestA)).As(t => t.GetInterfaces()[0]).PropertiesAutowired();
                //var d = f.Build();
                ////List<OnetestB> onetestBs = new List<OnetestB>();
                //ServiceProvider serviceProvider = ser.BuildServiceProvider();
                //IServiceProvider service = new AutofacServiceProvider(d);
                //var gg = service.GetServices<IoneTestA>();
            }
            { 
                //services.scan
            }
            {
                //Assembly assembly = Assembly.GetExecutingAssembly();
                //var dd = assembly.GetTypes().Where(x => x.Name == "aaaaaaa").Count();
                //var t = assembly.GetTypes().Where(x => x.Name == "aaaaaaa");
                //var cc = typeof(aaaaaaa).DeclaringType;
                //OneRun.Run();
                //var t = assembly.GetTypes().Where( x => x.Name);
                //var con = new ContainerBuilder();

                var c = new ContainerBuilder();
                var oo = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsInterface).ToList() ;
                var h = typeof(OneTestA).BaseType;
                var xx = typeof(OneTestA).GetInterfaces();
                var xxx = xx.FirstOrDefault();

                var o = c.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                    .Where(
                    x => 
                    x.BaseType.Name
                    == 
                    typeof(Base).Name);
                c.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                    .Where(x => x.BaseType.Name == typeof(Base).Name)
                    .AsImplementedInterfaces()//暴露所有接口
                    .As(x => x.GetInterfaces().FirstOrDefault()).InstancePerLifetimeScope();
                var n = c.Build();
                var tt = n.Resolve<IOnetestD>(); 
            }

            {
                var x = new ServiceCollection();
                //x.BuildServiceProvider();
                var de = new ContainerBuilder();
                de.Populate(x);
                var xx = new AutofacServiceProvider(de.Build());
            }
        }

        public void ConfigureContainer(ContainerBuilder containerBuilder)
        {
            // containerBuilder.RegisterModule<ContainerBuiderModel>();
            containerBuilder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).Where(x => x.BaseType.Name == typeof(Base).Name)
                .As(x => x.GetInterfaces())
                //.AsImplementedInterfaces().//暴露所有接口
                //.InstancePerLifetimeScope()// 作用域
                //.SingleInstance()// 单列
                .InstancePerDependency(); //顺势
        }

        public static void Name(List<Assmmodel> assmmodels)
        {
            {
                //List<Assmmodel> assmmodels2 = new List<Assmmodel>();

                //assmmodels2.Add(assmmodels.FirstOrDefault());
                //assmmodels2.Remove(assmmodels.FirstOrDefault());
                //var w = assmmodels2.GetHashCode(); //15368010
                //assmmodels2.Add(new Assmmodel());  //
                //w = assmmodels2.GetHashCode();   //15368010
                //foreach (var i in assmmodels) 
                //{
                //    assmmodels2.Add(i);
                //}
                //w = assmmodels2.GetHashCode();   //15368010
                ////assmmodels2 = assmmodels;
                //w = assmmodels2.GetHashCode();  //1707556 
                //w = assmmodels.GetHashCode();   //1707556
                //List<Assmmodel> assmmodels1 = new List<Assmmodel>();
                //foreach (var i in assmmodels) 
                //{
                //    assmmodels1.Add(i);
                //}
                //foreach (var i in assmmodels1) 
                //{
                //    assmmodels2.Remove(i);
                //}
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IOptions<OneTest> options)
        {
            {
                //var ts = options.Value;
                //HostingBuireder.OneTest();

                //List<Assmmodel> assmmodels = new List<Assmmodel>();
                //assmmodels.Add(new Assmmodel());
                //OneTest();
                //var dd = AppDomain.CurrentDomain.GetAssemblies();
                #region
                //app.Map("/test", Name);

                //app.MapWhen();

                //app.Use();
                //app.Run();
                //app.Use();

                //app.UseWhen()

                //Func<int, Task<int>> func = async c => { return await Task.Run(()=> { return 1; }); };
                #endregion
                //C:\Program Files\dotnet\packs\Microsoft.AspNetCore.App.Ref\3.1.8\ref\netcoreapp3.1\Microsoft.AspNetCore.Http.dll
                //ApplicationBuilder
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); //new MapMiddleware
            }

            app.UseMiddleware<OneModelWale>();
            app.UseMiddleware<TwoMiddleware>();
            app.UseMiddleware<ThreeMiidleWale>();

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


            app.Map("/map",
                x =>
                {
                    x.Use(y =>
                    {
                        var cliarm = new ClaimsIdentity();
                        Console.WriteLine("xxx");
                        return
                        async u =>
                        {
                            Console.WriteLine("xxx");
                            await y.Invoke(u);
                            Console.WriteLine("xxxx");
                        };
                    });
                    x.UseHttpsRedirection();
                    //x.UseEndpoints(endpoints =>
                    //{
                    //    endpoints.MapControllers();
                    //});
                });

            app.MapWhen(x => x.Request.Query.ContainsKey("Name"),
                x =>
                {
                    x.Use(
                        y =>
                        {
                            Console.WriteLine();
                            return async u =>
                            {
                                Console.WriteLine("xxx");
                                await y.Invoke(u);
                                Console.WriteLine("xxx");
                            };
                        });
                });

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

        public static void OneTest()
        {
            {
                //List<Type> TypeItemList = new List<Type>();
                //var ResultTypeList = Assembly.GetEntryAssembly();
                //if (ResultTypeList == null)
                //{
                //    ResultTypeList = Assembly.GetCallingAssembly();
                //    var ItemList = ResultTypeList.GetReferencedAssemblies().Where(p => p.GetType() == typeof(BaseService));                
                //}
                //Assembly[] AssbyCustmList = System.AppDomain.CurrentDomain.GetAssemblies();
                //var count = AssbyCustmList.Count();
                //var a = Assembly.LoadFile(@"E:\学习\GitHubProject\NetCore\Netcore2\bin\Debug\netcoreapp3.1\netcoreapp3.1\Netcore2.dll");
                //var b = Assembly.LoadFrom(@"E:\学习\GitHubProject\NetCore\Netcore2\bin\Debug\netcoreapp3.1\netcoreapp3.1\Netcore2.dll");
                //var w = a.GetTypes().Count();
                //var ww = b.GetTypes().Count();
                //var t = a.GetTypes().Where(x => x == typeof(Assmmodel)).FirstOrDefault();

                //var tt = b.GetTypes().Where(x => x == typeof(Assmmodel)).FirstOrDefault();
                //foreach (Assembly assItem in AssbyCustmList)
                //{
                //    //TypeItemList.AddRange(assItem.GetTypes().Where(x => x.BaseType == typeof(BaseService)).ToList());
                //}
                //IEnumerable<Type> TypeItemList = CurType.Assembly.GetExportedTypes().Where(x => x.BaseType == typeof(BaseService)).ToList();
                //IEnumerable<Type> TypeItemList = ResultTypeList.GetTypes().Where(x => x.BaseType == typeof(BaseService)).ToList();
                //BaseService TarService = null;
                //foreach (Type typeitem in TypeItemList)
                //{
                //    if (_Reporttory.Count(p => p.GetType() == typeitem) == 0)
                //    {
                //        TarService = (Activator.CreateInstance(typeitem) as BaseService);
                //    }
                //    else
                //    {
                //        TarService = _Reporttory.First(p => p.GetType() == typeitem);
                //    }
                //    TarService.Start();
                //}
            }
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
