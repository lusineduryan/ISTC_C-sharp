using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_LinkedinProfiles
{
    public class Profiles
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public string Location { get; set; }
        public string Education { get; set; }
        public string Company { get; set; }
        public int? ConnectionCount { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }
        public string Connected { get; set; }
        public string ImageUrl { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
