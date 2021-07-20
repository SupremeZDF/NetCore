using AssemblyModel.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Netcore2.Middleware
{
    public class OneHosingServer : IHostedService
    {

        public  Timer timer;

        public Task StartAsync(CancellationToken cancellationToken)
        {
            timer = new Timer(x => { Console.WriteLine(DateTime.Now.ToString()); },null,0 ,1000);
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            timer?.Dispose();
            return Task.CompletedTask;
        }
    }

    public class HostingBuireder 
    {
        public static void OneTest(string[] args) 
        {
            var b = new HostBuilder()
                .ConfigureHostConfiguration( x => x.AddCommandLine(args) )
                .ConfigureAppConfiguration((c,budder)=> 
                {
                    budder.AddJsonFile("appsettings.json",false).
                    AddJsonFile($"appsettings.{c.HostingEnvironment.EnvironmentName}.json",true);
                })
                .ConfigureServices((c,
                x) => x.AddSingleton<IHostedService, OneHosingServer>()
                .AddOptions()
                .Configure<Assmmodel>(c.Configuration.GetSection(""))
                .AddHostedService<OneHosingServer>()
                .AddSingleton<A,ServerceInstance>()
                .AddTransient<B,ServerceInstance>()
                .AddScoped<C,ServerceInstance>()
                ).Build();
            b.Run();
        }
    }

    public interface A 
    {
        void A();
    }
    public interface B
    {
        void b();
    }
    public interface C
    {
        void c();
    }

    public class ServerceInstance : A, B, C
    {
        public void A()
        {
            Console.WriteLine("a");
        }

        public void b()
        {
            Console.WriteLine("b");
        }

        public void c()
        {
            Console.WriteLine("c");
        }
    }
}
