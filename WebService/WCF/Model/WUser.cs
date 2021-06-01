using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebService.WCF.Model
{
    [DataContract]
    public class WUser
    {
        public WUser() 
        { }

        //public WUser(int i)
        //{
        //    ID = i;
        //}
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Age { get; set; }

        public string Name { get; set; }
    }
}