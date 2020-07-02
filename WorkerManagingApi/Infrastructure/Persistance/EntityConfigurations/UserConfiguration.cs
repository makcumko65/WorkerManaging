using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infrastructure.Persistance.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasOne(w => w.Worker)
                .WithOne(u => u.User)
                .HasForeignKey<Worker>(w => w.UserId);

            builder.HasData(
                 new User
                 {
                     Id = "1",
                     Email = "worker.managing@gmail.com",
                     NormalizedEmail = "WORKER.MANAGING@GMAIL.COM",
                     EmailConfirmed = true,
                     UserName = "worker.managing@gmail.com",
                     NormalizedUserName = "WORKER.MANAGING@GMAIL.COM",
                     FirstName = "Admin",
                     LastName = "Admin"

                 },
                 new User
                 {
                     Id = "da2fd609-d754-4feb-8acd-c4f9ff13ba96",
                     Email = "ivanov@gmail.com",
                     NormalizedEmail = "IVANOV@GMAIL.COM",
                     EmailConfirmed = true,
                     UserName = "ivanov@gmail.com",
                     NormalizedUserName = "IVANOV@GMAIL.COM",
                     FirstName = "Ivan",
                     LastName = "Ivanov",
                     AddressId = Guid.Parse("102b566b-ba1f-404c-b2df-e2cde39ade09")
                 },
                 new User
                 {
                     Id = "2902b665-1190-4c70-9915-b9c2d7680450",
                     Email = "petrov@gmail.com",
                     NormalizedEmail = "PETROV@GMAIL.COM",
                     EmailConfirmed = true,
                     UserName = "petrov@gmail.com",
                     NormalizedUserName = "PETROV@GMAIL.COM",
                     FirstName = "Petro",
                     LastName = "Petrov",
                     AddressId = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b")
                 },
                 new User
                 {
                     Id = "d8663e5e-7494-4f81-8739-6e0de1bea7ee",
                     Email = "ksenya@gmail.com",
                     NormalizedEmail = "KSENYA@GMAIL.COM",
                     EmailConfirmed = true,
                     UserName = "ksenya@gmail.com",
                     NormalizedUserName = "KSENYA@GMAIL.COM",
                     FirstName = "Ksenya",
                     LastName = "Ksenya",
                     AddressId = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b")
                 }
            );


        }
    }
}
