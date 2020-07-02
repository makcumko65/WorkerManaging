using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Persistance.EntityConfigurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = "Owner"
                },
                new IdentityRole
                {
                    Id = "2",
                    Name = "Administrator"
                },
                new IdentityRole
                {
                    Id = "3",
                    Name = "Manager"
                },
                new IdentityRole
                {
                    Id = "4",
                    Name = "Worker"
                },
                new IdentityRole
                {
                    Id = "5",
                    Name = "User"
                });
        }
    }
}
