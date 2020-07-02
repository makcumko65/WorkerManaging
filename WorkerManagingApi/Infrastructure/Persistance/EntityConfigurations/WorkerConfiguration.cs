using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infrastructure.Persistance.EntityConfigurations
{
     public class WorkerConfiguration : IEntityTypeConfiguration<Worker>
    {
        public void Configure(EntityTypeBuilder<Worker> builder)
        {

            builder.HasKey(w => w.UserId);

            builder.HasData(
                new Worker
                {
                    UserId = "da2fd609-d754-4feb-8acd-c4f9ff13ba96",
                    Description = "Experience in plumbing repair for 2 years"

                },
                 new Worker
                 {
                     UserId = "2902b665-1190-4c70-9915-b9c2d7680450",
                     Description = "Laying parquet, tile and so on"

                 });
        }
    }
}
