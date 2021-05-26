using Autofac;
using Netcore2.Controllers;
using Netcore2.Instance;
using Netcore2.Interface;
using Netcore2.Tool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netcore2
{
    public class ContainerBuiderModel : Module
    {
        protected override void Load(ContainerBuilder builder) 
        {
            builder.RegisterType<OneTestA>().As<IoneTestA>().InstancePerDependency(); //顺势周期 默认瞬时周期
            builder.RegisterType<OnetestB>().As<IOnetestB>().SingleInstance();   // 单列周期
            builder.RegisterType<OnetestC>().As<IOnetestC>().InstancePerLifetimeScope();  //作用域生命周期
            builder.RegisterType<OnetestD>().As<IOnetestD>().SingleInstance();
            builder.RegisterType<OnetestE>().As<IOnetestE>().InstancePerDependency(); //瞬时周期
            builder.Register(c=> new AutofacAop ());
        }
    }
}
