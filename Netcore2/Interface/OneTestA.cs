using Netcore2.Instance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netcore2.Interface
{

    public interface AA { void run(); }

    public class OneTestA : Base, IoneTestA
    {
        public IOnetestD onetestD;

        public OneTestA(IOnetestD _onetestD) 
        {
            onetestD = _onetestD;
    }

        public void run()
        {
            var c = onetestD.GetHashCode(); //3930951 34257225 48313086
        }
    }
}
