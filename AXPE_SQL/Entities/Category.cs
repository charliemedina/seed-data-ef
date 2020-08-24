using System;
using System.Collections.Generic;

namespace AXPE_SQL.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
