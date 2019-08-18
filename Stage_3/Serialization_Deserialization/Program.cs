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
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string content = "";
            try
            {
                content = client.DownloadString(@"https://static.h-bid.com/sncmp/sngvl.json");
            }
            catch (WebException)
            {
                Console.WriteLine("Invalid URL");
            }
            string file = @"C:\Users\Lucine\C_sharp\jsonContent.json";
            File.WriteAllText(file, content);
            Rootobject rootobject = DeserializeFromJSON.JSONDeserialize(file);
            Console.WriteLine(rootobject.gvlMaxVendorId);
            foreach (var item in rootobject.features)
            {
                Console.WriteLine(item.id);
            }

            string JSONSer = SerializeToJSON.JSONSerialize(rootobject);
            File.WriteAllText(@"C:\Users\Lucine\C_sharp\jsonSer.json", JSONSer);

            string XMLSer = SerializeToXML.XMLSerialize(rootobject);
            File.WriteAllText(@"C:\Users\Lucine\C_sharp\XMLSer.xml", XMLSer);
            Console.ReadKey();
        }
    }
}
