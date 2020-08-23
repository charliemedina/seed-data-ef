using System;

namespace AXPE_SQL.Entities
{
    public class OrderDetails
    {
        public Guid OrderDetailsId { get; set; }

        public int UnitPrice { get; set; }

        public int Quantity { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}
