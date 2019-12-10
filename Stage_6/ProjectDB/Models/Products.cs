using System;
using System.Collections.Generic;

namespace ProjectDB.Models
{
    public partial class Products
    {
        public Products()
        {
            Items = new HashSet<Items>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public decimal? Price { get; set; }

        public virtual Categories Category { get; set; }
        public virtual ICollection<Items> Items { get; set; }
    }
}
