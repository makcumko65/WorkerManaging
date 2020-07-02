﻿// <auto-generated />
using System;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(WorkerContext))]
    [Migration("20200702150735_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address");

                    b.HasData(
                        new
                        {
                            Id = new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Lviv"
                        },
                        new
                        {
                            Id = new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Lutsk"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Plumbing work"
                        },
                        new
                        {
                            Id = new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Construction works"
                        },
                        new
                        {
                            Id = new Guid("a64549d1-8879-4c1f-ac89-e123fe633ad6"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Laying parquet"
                        });
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "217e2ab9-d528-42d4-97c7-3e707122be9e",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "worker.managing@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NormalizedEmail = "WORKER.MANAGING@GMAIL.COM",
                            NormalizedUserName = "WORKER.MANAGING@GMAIL.COM",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1fed66f4-e1a7-43f3-b82d-a577fbf16cba",
                            TwoFactorEnabled = false,
                            UserName = "worker.managing@gmail.com"
                        },
                        new
                        {
                            Id = "da2fd609-d754-4feb-8acd-c4f9ff13ba96",
                            AccessFailedCount = 0,
                            AddressId = new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                            ConcurrencyStamp = "145ca203-5823-44a1-b601-5e2f3e6ce8bb",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ivanov@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Ivan",
                            LastName = "Ivanov",
                            LockoutEnabled = false,
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NormalizedEmail = "IVANOV@GMAIL.COM",
                            NormalizedUserName = "IVANOV@GMAIL.COM",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "37f54886-0fa5-4b8e-9284-cc96f7030470",
                            TwoFactorEnabled = false,
                            UserName = "ivanov@gmail.com"
                        },
                        new
                        {
                            Id = "2902b665-1190-4c70-9915-b9c2d7680450",
                            AccessFailedCount = 0,
                            AddressId = new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                            ConcurrencyStamp = "ecc05a7c-d879-454a-a9f2-fc296d2eb601",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "petrov@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Petro",
                            LastName = "Petrov",
                            LockoutEnabled = false,
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NormalizedEmail = "PETROV@GMAIL.COM",
                            NormalizedUserName = "PETROV@GMAIL.COM",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "278bf462-2426-4dd0-abe9-6b7c41377acd",
                            TwoFactorEnabled = false,
                            UserName = "petrov@gmail.com"
                        },
                        new
                        {
                            Id = "d8663e5e-7494-4f81-8739-6e0de1bea7ee",
                            AccessFailedCount = 0,
                            AddressId = new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                            ConcurrencyStamp = "9ac2a209-ead4-4197-bc2b-45293ed36ab3",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ksenya@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Ksenya",
                            LastName = "Ksenya",
                            LockoutEnabled = false,
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NormalizedEmail = "KSENYA@GMAIL.COM",
                            NormalizedUserName = "KSENYA@GMAIL.COM",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "09ead5c9-8794-4fca-893c-59cb89e08d54",
                            TwoFactorEnabled = false,
                            UserName = "ksenya@gmail.com"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Worker", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Worker");

                    b.HasData(
                        new
                        {
                            UserId = "da2fd609-d754-4feb-8acd-c4f9ff13ba96",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Experience in plumbing repair for 2 years",
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = "2902b665-1190-4c70-9915-b9c2d7680450",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Laying parquet, tile and so on",
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Domain.Entities.WorkerCategory", b =>
                {
                    b.Property<string>("WorkerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("WorkerId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("WorkerCategory");

                    b.HasData(
                        new
                        {
                            WorkerId = "da2fd609-d754-4feb-8acd-c4f9ff13ba96",
                            CategoryId = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97")
                        },
                        new
                        {
                            WorkerId = "2902b665-1190-4c70-9915-b9c2d7680450",
                            CategoryId = new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a")
                        },
                        new
                        {
                            WorkerId = "2902b665-1190-4c70-9915-b9c2d7680450",
                            CategoryId = new Guid("a64549d1-8879-4c1f-ac89-e123fe633ad6")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "fcfa0659-1791-4caa-aa8d-81d85997d8dc",
                            Name = "Owner"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "c99a385e-19fe-456c-ab8c-cff5346e09b4",
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "01b8d073-935e-4c1d-9172-46a5be89f10c",
                            Name = "Manager"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "859c1a49-bc0f-4dd5-8a33-b4dc2fb1d4b5",
                            Name = "Worker"
                        },
                        new
                        {
                            Id = "5",
                            ConcurrencyStamp = "39f43c8c-4298-4b51-9291-5e3164464b3c",
                            Name = "User"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.HasOne("Domain.Entities.Address", "Adrress")
                        .WithMany("Users")
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("Domain.Entities.Worker", b =>
                {
                    b.HasOne("Domain.Entities.User", "User")
                        .WithOne("Worker")
                        .HasForeignKey("Domain.Entities.Worker", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.WorkerCategory", b =>
                {
                    b.HasOne("Domain.Entities.Category", "Category")
                        .WithMany("Workers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Worker", "Worker")
                        .WithMany("Categories")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}