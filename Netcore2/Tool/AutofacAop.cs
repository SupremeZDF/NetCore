using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Extras.DynamicProxy;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Castle.DynamicProxy;

namespace Netcore2.Tool
{
    public class AutofacAop : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("AOP 切面开始了");
            Console.WriteLine($"AOP 切换参数_:{invocation.Arguments}");
            invocation.Proceed();
            Console.WriteLine("AOP 切换结束了");
        }
    }

    public interface IOnetestE
    {
        void Name(string Wrod, string uo);
    }

    [Intercept(typeof(AutofacAop))]
    public class OnetestE : IOnetestE
    {
        public void Name(string Wrod, string uo)
        {
            Console.WriteLine($"Word:{Wrod}，uo:{uo}");
        }
    }
}
