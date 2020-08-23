using System;
using System.Collections.Generic;

namespace AXPE_SQL.Entities
{
    public class Product
    {
        public Guid ProductId { get; set; }

        public string ProductName { get; set; }

        public int QuantiryPerUnit { get; set; }

        public int UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public int UnitsOnOrder { get; set; }

        public int ReorderLevel { get; set; }

        public bool Discontinued { get; set; }

        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<OrderDetails> Orders { get; set; }
    }
}
