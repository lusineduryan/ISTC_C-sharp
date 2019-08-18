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
    public static class SerializeToXML
    {
        public static string XMLSerialize(Rootobject rootobject)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Rootobject));
            string xmlFile = "";

            using (StringWriter content = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(content))
                {
                    xs.Serialize(writer, rootobject);
                    xmlFile = xs.ToString();
                }
            }

            return xmlFile;
        }
    }
}
