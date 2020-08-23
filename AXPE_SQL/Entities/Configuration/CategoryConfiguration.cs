using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AXPE_SQL.Entities.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
            (
                new Category
                {
                    CategoryId = Guid.NewGuid(),
                    CategoryName = "NewName4",
                    Description = "Description1",
                    Picture = "Picture1"
                },
                new Category
                {
                    CategoryId = Guid.NewGuid(),
                    CategoryName = "NewName5",
                    Description = "Description2",
                    Picture = "Picture2"
                }
            );
        }
    }
}
