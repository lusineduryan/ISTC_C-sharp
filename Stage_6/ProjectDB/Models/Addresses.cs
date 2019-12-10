using System;
using System.Collections.Generic;

namespace ProjectDB.Models
{
    public partial class Addresses
    {
        public Addresses()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
