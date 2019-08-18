using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Deserialization
{
    public class Rootobject
    {
        public string customVendorListCreated { get; set; }
        public int customVendorListVersion { get; set; }
        public Feature[] features { get; set; }
        public int gvlMaxVendorId { get; set; }
        public DateTime lastUpdated { get; set; }
        public Purpos[] purposes { get; set; }
        public int vendorListVersion { get; set; }
        public Vendor[] vendors { get; set; }
    }

    public class Feature
    {
        public string description { get; set; }
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Purpos
    {
        public string description { get; set; }
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Vendor
    {
        public int?[] featureIds { get; set; }
        public int id { get; set; }
        public int?[] legIntPurposeIds { get; set; }
        public string name { get; set; }
        public string policyUrl { get; set; }
        public int?[] purposeIds { get; set; }
    }
}
