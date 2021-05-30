using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using WebService.Models;

namespace WebService.WebServers
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]

    //WSDL websever 功能描述 接口描述
    //Http    服务器
    //Soap  描述了传递信息的格式 谁发送的 谁接受的 如何解析发送信息
    //XML 传输的信息格式
    public class WebService1 : System.Web.Services.WebService
    {
        public WebService1() 
        {
        
        }

        public SoapHerders soapHerders { get; set; } //接口身份验证

        [WebMethod]
        [SoapHeader("soapHerders")]
        public string HelloWorld()
        {
            var code = soapHerders.GetHashCode();  //5896758
            return "Hello World";
        }
    }
}
