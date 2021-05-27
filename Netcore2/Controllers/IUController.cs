using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Netcore2.Instance;

namespace Netcore2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IUController : ControllerBase
    {

        public IoneTestA ioneTestA;
        public IOnetestB _onetestB;

        public IUController(IoneTestA ioneTestA, IOnetestB onetestB) 
        {
            ioneTestA = ioneTestA;
            var gg = ioneTestA.GetHashCode();  //3789628 5187339  4032828
            _onetestB = onetestB;
            var uu = onetestB.GetHashCode();   //9570543 9570543
        }

        //[ServiceFilter]
        [HttpPost]
        public void GetName() 
        {
        
        }
    }
}
