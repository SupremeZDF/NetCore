using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class JsonpController : ControllerBase
    {
        [HttpGet]
        public string GetJson() {
            dynamic dy = new { json = "123", name = "123" };
            return Newtonsoft.Json.JsonConvert.SerializeObject(dy);
        }
    }
}
