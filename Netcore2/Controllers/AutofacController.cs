using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Netcore2.AutoReflection;
using Netcore2.Instance;
using Netcore2.Tool;
using System.Reflection;

namespace Netcore2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [CustomerControllerFiler]
    public class AutofacController : ControllerBase
    {

        private IoneTestA _ioneTestA;
        private IOnetestB _onetestB;
        private IOnetestC _onetestC;
        private IOnetestD _onetestD;
        private IOnetestE _onetestE;

        /// <summary>
        /// 
        /// </summary>
        public AutofacController(IoneTestA ioneTestA, IOnetestB onetestB, IOnetestC onetestC, IOnetestD onetestD, IOnetestE onetestE) 
        {
            _ioneTestA = ioneTestA;
            _onetestB = onetestB;
            _onetestC = onetestC;
            _onetestD = onetestD;
            _onetestE = onetestE;
        }

        /// <summary>
        /// 
        /// </summary>
        [ActionFilter]
        [HttpGet]
        public void Name() 
        {
            _onetestE.Name("1","2");
            throw new Exception("");
        }
    }
}
