using System;
using System.Collections.Generic;

namespace AXPE_SQL.Entities
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime RequiredDate { get; set; }

        public DateTime ShippedDate { get; set; }

        public string ShipVia { get; set; }

        public double Freight { get; set; }

        public string ShipName { get; set; }

        public string ShipAddress { get; set; }

        public string ShipCity { get; set; }

        public string ShipRegion { get; set; }
        
        public string ShipPostalCode { get; set; }

        public string ShipCountry { get; set; }

        public int ShipperId { get; set; }
        public Shipper Shipper { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public ICollection<OrderDetails> OrdersDetails { get; set; }
    }
}
