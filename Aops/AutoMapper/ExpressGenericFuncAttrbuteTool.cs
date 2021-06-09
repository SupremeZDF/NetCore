using System;
using System.Collections.Generic;
using System.Text;

namespace Aops.AutoMapper
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    class ExpressGenericFuncAttrbuteTool : Attribute
    {
        public string PropertyConvertName { get; set; }
        public ExpressGenericFuncAttrbuteTool(string _PropertyConvertName)
        {
            PropertyConvertName = _PropertyConvertName;
        }
    }
}
