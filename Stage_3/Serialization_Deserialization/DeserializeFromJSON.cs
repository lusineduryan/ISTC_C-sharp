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
    public static class DeserializeFromJSON
    {
        public static Rootobject JSONDeserialize(string JSONFile)
        {
            return JsonConvert.DeserializeObject<Rootobject>(File.ReadAllText(JSONFile));
        }
    }
}
