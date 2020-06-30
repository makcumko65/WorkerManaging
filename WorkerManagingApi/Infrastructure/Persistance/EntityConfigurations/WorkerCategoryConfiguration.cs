using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
        }
    }
}
