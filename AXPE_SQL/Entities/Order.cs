using System;
using System.Collections.Generic;

namespace AXPE_SQL.Entities
{
    public class Order
    {
        public Guid OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime RequiredDate { get; set; }

        public DateTime ShippedDate { get; set; }

        public string ShipVia { get; set; }

        public double Freight { get; set; }

        public string ShipName { get; set; }

        public string ShipAddress { get; set; }

        public string ShipCity { get; set; }

        public string ShipRegion { get; set; }
        
        public int ShipPostalCode { get; set; }

        public string ShipCountry { get; set; }

        public Guid ShipperId { get; set; }
        public Shipper Shipper { get; set; }

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public ICollection<OrderDetails> OrdersDetails { get; set; }
    }
}
