using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netcore2.AutoReflection
{
    public interface IOneReflection
    {

    }

    public interface IOneReflectionB :  IOneReflection{ }

    public abstract class records: IOneReflection
    {
    
    }
    //{Name = "IOneReflection" FullName = "Netcore2.AutoReflection.IOneReflection"}
    public class Names : records
    {
    
    }

    public class OneReflection : Names
    {

    }

    public enum ui { }
}
