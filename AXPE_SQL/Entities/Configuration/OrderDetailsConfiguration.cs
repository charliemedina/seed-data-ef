using AXPE_SQL.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AXPE_SQL.Entities.Configuration
{
    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            var orderDetails = FakeGenerator.GetOrderDetails;
            builder.HasData(orderDetails);
        }
    }
}
