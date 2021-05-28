using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Netcore01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //创建服务
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args).
            ConfigureLogging((con,logg)=> {
                logg.AddFilter("System", LogLevel.Warning); //过滤掉系统默认的一些日志
                logg.AddFilter("Microsoft", LogLevel.Warning);//过滤掉系统默认的一些日志
                logg.AddLog4Net();
            })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }).UseServiceProviderFactory(new auo);
    }
}
