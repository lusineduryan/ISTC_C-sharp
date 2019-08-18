using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;
using System.Net;

namespace Serialization_Deserialization
{
    public static class SerializeToJSON
    {
        public static string JSONSerialize(Rootobject rootobject)
        {
            return JsonConvert.SerializeObject(rootobject, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
