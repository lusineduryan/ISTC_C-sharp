using System;
using System.Collections.Generic;

namespace ProjectDB.Models
{
    public partial class Users
    {
        public Users()
        {
            Cart = new HashSet<Cart>();
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int? AddressId { get; set; }
        public string Token { get; set; }

        public virtual Addresses Address { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
