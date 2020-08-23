using AXPE_SQL.Entities;
using AXPE_SQL.Entities.Configuration;
using Microsoft.EntityFrameworkCore;

namespace AXPE_SQL.Helpers
{
    public class AXPE_DbContext : DbContext
    {
        public AXPE_DbContext(DbContextOptions<AXPE_DbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
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
