using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace WebService.Models
{
    public class SoapHerders : SoapHeader
    {
        public SoapHerders() { }

        public SoapHerders( string Name ,string Passwoed) 
        {
            name = Name;
            pswd = Passwoed;
        }

        public string name { get; set; }

        public string pswd { get; set; }
    }
}