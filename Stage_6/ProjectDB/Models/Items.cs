using System;
using System.Collections.Generic;

namespace ProjectDB.Models
{
    public partial class Items
    {
        public Items()
        {
            Cart = new HashSet<Cart>();
            ItemsOrders = new HashSet<ItemsOrders>();
        }

        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? Color { get; set; }
        public int? Size { get; set; }
        public int? Quantity { get; set; }
        public string Image { get; set; }

        public virtual Products Product { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<ItemsOrders> ItemsOrders { get; set; }
    }
}
