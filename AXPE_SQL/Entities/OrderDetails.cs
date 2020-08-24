using System;

namespace AXPE_SQL.Entities
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }

        public int UnitPrice { get; set; }

        public int Quantity { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
