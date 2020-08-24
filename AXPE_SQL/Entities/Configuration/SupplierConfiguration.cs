using AXPE_SQL.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AXPE_SQL.Entities.Configuration
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            var suppliers = FakeGenerator.GetSuppliers;
            builder.HasData(suppliers);
        }
    }
}
