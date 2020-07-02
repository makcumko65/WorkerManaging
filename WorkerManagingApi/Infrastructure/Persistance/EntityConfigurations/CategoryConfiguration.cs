using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace Infrastructure.Persistance.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                    Name = "Plumbing work"
                },
                new Category
                { 
                    Id = Guid.Parse("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                    Name = "Construction works"

                },
                new Category
                {
                    Id = Guid.Parse("a64549d1-8879-4c1f-ac89-e123fe633ad6"),
                    Name = "Laying parquet"
                });

        }
    }
}
