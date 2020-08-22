using System;
using System.Collections.Generic;

namespace AXPE_SQL.Entities
{
    public class Shipper
    {
        public Guid ShipperId { get; set; }

        public string CompanyName { get; set; }

        public string Phone { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
