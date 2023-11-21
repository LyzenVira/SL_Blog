﻿// <auto-generated />
using System;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace SuperLandscapers_Blog.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231120063636_CreateFirstMigration")]
    partial class CreateFirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("1d7f4741-2cb1-4baf-a1f9-65dd95208333"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "855a9bc0-d632-4468-894c-58101949fac3",
                            CreatedDateTime = new DateTime(2023, 11, 20, 8, 36, 35, 836, DateTimeKind.Local).AddTicks(1532),
                            Email = "customer@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Danyil",
                            LastName = "Terentiev",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEHIRE6Pk0mBwugqfOPe2LUhl+TbcJ1f4tz12skFuWmrVyvlEDqnKHts1WSlrWvztPA==",
                            PhoneNumber = "0505874855",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "DaniTer"
                        },
                        new
                        {
                            Id = new Guid("24143b4c-87a7-401d-830d-26f8eeaaa43a"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fc06cb09-52d8-47ab-a00e-be329e6f554b",
                            CreatedDateTime = new DateTime(2023, 11, 20, 8, 36, 36, 166, DateTimeKind.Local).AddTicks(4922),
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Danya",
                            LastName = "Terentiev",
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEKkxWY3JneMpZTPyIM4CjZxKV6Qr0qsB0NBSIT0FN0AiQyaDjAL1bXViPuMuw/IzdA==",
                            PhoneNumber = "777",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("DAL.Entities.OrderBlog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("OrderType")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("OrderBlog", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("99cb9dd2-55bb-4176-af84-8a27e642821a"),
                            CreatedDateTime = new DateTime(2023, 11, 20, 8, 36, 36, 553, DateTimeKind.Local).AddTicks(5807),
                            Email = "user1@example.com",
                            OrderType = 0,
                            ShortDescription = "Description 1",
                            Username = "User1"
                        },
                        new
                        {
                            Id = new Guid("3b71be6f-df2e-4cf5-910b-5c616119ab94"),
                            CreatedDateTime = new DateTime(2023, 11, 20, 8, 36, 36, 553, DateTimeKind.Local).AddTicks(5856),
                            Email = "user2@example.com",
                            OrderType = 2,
                            ShortDescription = "Description 2",
                            Username = "User2"
                        },
                        new
                        {
                            Id = new Guid("f0e09020-4f16-4f55-b0da-8b6738ecd2ff"),
                            CreatedDateTime = new DateTime(2023, 11, 20, 8, 36, 36, 553, DateTimeKind.Local).AddTicks(5877),
                            Email = "user3@example.com",
                            OrderType = 1,
                            ShortDescription = "Description 3",
                            Username = "User3"
                        },
                        new
                        {
                            Id = new Guid("ffe844c8-fe30-4afe-ba6c-68ecea5cd0f2"),
                            CreatedDateTime = new DateTime(2023, 11, 20, 8, 36, 36, 553, DateTimeKind.Local).AddTicks(6004),
                            Email = "user4@example.com",
                            OrderType = 0,
                            ShortDescription = "Description 4",
                            Username = "User4"
                        },
                        new
                        {
                            Id = new Guid("0baf1925-f7c6-447c-8651-739df3e54fce"),
                            CreatedDateTime = new DateTime(2023, 11, 20, 8, 36, 36, 553, DateTimeKind.Local).AddTicks(6026),
                            Email = "user5@example.com",
                            OrderType = 1,
                            ShortDescription = "Description 5",
                            Username = "User5"
                        },
                        new
                        {
                            Id = new Guid("f068f4c4-41a2-46b7-aa82-591cb85b9dcf"),
                            CreatedDateTime = new DateTime(2023, 11, 20, 8, 36, 36, 553, DateTimeKind.Local).AddTicks(6041),
                            Email = "user6@example.com",
                            OrderType = 2,
                            ShortDescription = "Description 6",
                            Username = "User6"
                        },
                        new
                        {
                            Id = new Guid("2e702fc8-f5cd-4188-9e70-f3133aef3f33"),
                            CreatedDateTime = new DateTime(2023, 11, 20, 8, 36, 36, 553, DateTimeKind.Local).AddTicks(6064),
                            Email = "user7@example.com",
                            OrderType = 1,
                            ShortDescription = "Description 7",
                            Username = "User7"
                        },
                        new
                        {
                            Id = new Guid("f5cc9f51-7a68-4350-ad0e-9bf866effc90"),
                            CreatedDateTime = new DateTime(2023, 11, 20, 8, 36, 36, 553, DateTimeKind.Local).AddTicks(6080),
                            Email = "user8@example.com",
                            OrderType = 0,
                            ShortDescription = "Description 8",
                            Username = "User8"
                        },
                        new
                        {
                            Id = new Guid("78d9552a-aad2-41f9-b8cf-004873c9e967"),
                            CreatedDateTime = new DateTime(2023, 11, 20, 8, 36, 36, 553, DateTimeKind.Local).AddTicks(6097),
                            Email = "user9@example.com",
                            OrderType = 1,
                            ShortDescription = "Description 9",
                            Username = "User9"
                        },
                        new
                        {
                            Id = new Guid("0c12e965-24d5-4f45-b710-81fffc836734"),
                            CreatedDateTime = new DateTime(2023, 11, 20, 8, 36, 36, 553, DateTimeKind.Local).AddTicks(6119),
                            Email = "user10@example.com",
                            OrderType = 2,
                            ShortDescription = "Description 10",
                            Username = "User10"
                        });
                });

            modelBuilder.Entity("DAL.Entities.OrderProject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NumberPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("OrderType")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OrderProject", (string)null);
                });

            modelBuilder.Entity("DAL.Entities.OrderProjectStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ProjectStatus")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("OrderProjectStatus", (string)null);
                });

            modelBuilder.Entity("DAL.Entities.PeriodProgress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberWeek")
                        .HasColumnType("int");

                    b.Property<Guid>("OrderProjectStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Progress")
                        .HasColumnType("int");

                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrderProjectStatusId");

                    b.HasIndex("ServiceId");

                    b.ToTable("PeriodProgress", (string)null);
                });

            modelBuilder.Entity("DAL.Entities.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Service", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8379b56f-7881-48ae-bf99-a29f53059332"),
                            ConcurrencyStamp = "0c10c8c1-308b-44a8-b0d1-5ade6453818d",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("25d5bfcb-e10c-49a4-b936-6dd443f23e30"),
                            ConcurrencyStamp = "3ce6bb98-2252-4e14-8b00-b0acb3b208e1",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("24143b4c-87a7-401d-830d-26f8eeaaa43a"),
                            RoleId = new Guid("8379b56f-7881-48ae-bf99-a29f53059332")
                        },
                        new
                        {
                            UserId = new Guid("1d7f4741-2cb1-4baf-a1f9-65dd95208333"),
                            RoleId = new Guid("25d5bfcb-e10c-49a4-b936-6dd443f23e30")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DAL.Entities.OrderProjectStatus", b =>
                {
                    b.HasOne("DAL.Entities.Customer", "Customer")
                        .WithMany("OrderProjectStatuses")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DAL.Entities.PeriodProgress", b =>
                {
                    b.HasOne("DAL.Entities.OrderProjectStatus", "OrderProjectStatus")
                        .WithMany("PeriodProgresses")
                        .HasForeignKey("OrderProjectStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Service", "Service")
                        .WithMany("PeriodProgresses")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderProjectStatus");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("DAL.Entities.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("DAL.Entities.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("DAL.Entities.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Entities.Customer", b =>
                {
                    b.Navigation("OrderProjectStatuses");
                });

            modelBuilder.Entity("DAL.Entities.OrderProjectStatus", b =>
                {
                    b.Navigation("PeriodProgresses");
                });

            modelBuilder.Entity("DAL.Entities.Service", b =>
                {
                    b.Navigation("PeriodProgresses");
                });
#pragma warning restore 612, 618
        }
    }
}