using AXPE_SQL.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AXPE_SQL.Entities.Configuration
{
    public class ShipperConfiguration : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            var shippers = FakeGenerator.GetShippers;
            builder.HasData(shippers);
        }
    }
}
