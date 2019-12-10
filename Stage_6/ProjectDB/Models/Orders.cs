using System;
using System.Collections.Generic;

namespace ProjectDB.Models
{
    public partial class Orders
    {
        public Orders()
        {
            ItemsOrders = new HashSet<ItemsOrders>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? Date { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<ItemsOrders> ItemsOrders { get; set; }
    }
}
