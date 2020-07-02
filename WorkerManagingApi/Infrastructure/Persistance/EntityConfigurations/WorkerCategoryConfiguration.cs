using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infrastructure.Persistance.EntityConfigurations
{
    public class WorkerCategoryConfiguration : IEntityTypeConfiguration<WorkerCategory>
    {
        public void Configure(EntityTypeBuilder<WorkerCategory> builder)
        {
            builder.HasKey(wc => new { wc.WorkerId, wc.CategoryId });

            builder.HasOne(w => w.Worker)
                .WithMany(wc => wc.Categories)
                .HasForeignKey(w => w.WorkerId);

            builder.HasOne(c => c.Category)
                .WithMany(wc => wc.Workers)
                .HasForeignKey(c => c.CategoryId);

            builder.HasData(
                new WorkerCategory
                {
                    WorkerId = "da2fd609-d754-4feb-8acd-c4f9ff13ba96",
                    CategoryId = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97")
                },
                new WorkerCategory
                {
                    WorkerId = "2902b665-1190-4c70-9915-b9c2d7680450",
                    CategoryId = Guid.Parse("40ff5488-fdab-45b5-bc3a-14302d59869a")
                },
                new WorkerCategory
                {
                    WorkerId = "2902b665-1190-4c70-9915-b9c2d7680450",
                    CategoryId = Guid.Parse("a64549d1-8879-4c1f-ac89-e123fe633ad6")
                });
        }
    }
}
