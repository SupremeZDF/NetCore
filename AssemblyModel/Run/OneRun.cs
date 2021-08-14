using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;

namespace AssemblyModel.Run
{
    public class OneRun
    {
        public static void Run() 
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var c = assembly.GetTypes().Where(x => x.Name == "aaaaaaa").FirstOrDefault();
        }
    }
}
