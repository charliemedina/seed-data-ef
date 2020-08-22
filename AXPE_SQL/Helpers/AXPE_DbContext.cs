using AXPE_SQL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AXPE_SQL.Helpers
{
    public class AXPE_DbContext : DbContext
    {
        public AXPE_DbContext(DbContextOptions<AXPE_DbContext> options) : base(options)
        {
        }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Shipper> Shippers { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
