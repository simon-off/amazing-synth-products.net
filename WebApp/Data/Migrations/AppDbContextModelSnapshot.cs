﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Contexts;

#nullable disable

namespace WebApp.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProduct");

                    b.HasData(
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 1
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 2
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 3
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 4
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 5
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 6
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 7
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 8
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 9
                        },
                        new
                        {
                            CategoriesId = 1,
                            ProductsId = 10
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 6
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 7
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 8
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 9
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 10
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 11
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 12
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 13
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 14
                        },
                        new
                        {
                            CategoriesId = 2,
                            ProductsId = 15
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 11
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 12
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 13
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 14
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 15
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 16
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 17
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 18
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 19
                        },
                        new
                        {
                            CategoriesId = 3,
                            ProductsId = 20
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "admin",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = "customer",
                            Name = "Customer"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebApp.Models.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "New"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Featured"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Popular"
                        });
                });

            modelBuilder.Entity("WebApp.Models.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Synth!",
                            Image = "product1.jpg",
                            Name = "Product 1",
                            Price = 79m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Synth!",
                            Image = "product2.jpg",
                            Name = "Product 2",
                            Price = 57m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Synth!",
                            Image = "product3.jpg",
                            Name = "Product 3",
                            Price = 80m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Synth!",
                            Image = "product4.jpg",
                            Name = "Product 4",
                            Price = 67m
                        },
                        new
                        {
                            Id = 5,
                            Description = "Synth!",
                            Image = "product5.jpg",
                            Name = "Product 5",
                            Price = 62m
                        },
                        new
                        {
                            Id = 6,
                            Description = "Synth!",
                            Image = "product6.jpg",
                            Name = "Product 6",
                            Price = 72m
                        },
                        new
                        {
                            Id = 7,
                            Description = "Synth!",
                            Image = "product7.jpg",
                            Name = "Product 7",
                            Price = 58m
                        },
                        new
                        {
                            Id = 8,
                            Description = "Synth!",
                            Image = "product8.jpg",
                            Name = "Product 8",
                            Price = 68m
                        },
                        new
                        {
                            Id = 9,
                            Description = "Synth!",
                            Image = "product9.jpg",
                            Name = "Product 9",
                            Price = 52m
                        },
                        new
                        {
                            Id = 10,
                            Description = "Synth!",
                            Image = "product10.jpg",
                            Name = "Product 10",
                            Price = 68m
                        },
                        new
                        {
                            Id = 11,
                            Description = "Synth!",
                            Image = "product11.jpg",
                            Name = "Product 11",
                            Price = 72m
                        },
                        new
                        {
                            Id = 12,
                            Description = "Synth!",
                            Image = "product12.jpg",
                            Name = "Product 12",
                            Price = 88m
                        },
                        new
                        {
                            Id = 13,
                            Description = "Synth!",
                            Image = "product13.jpg",
                            Name = "Product 13",
                            Price = 75m
                        },
                        new
                        {
                            Id = 14,
                            Description = "Synth!",
                            Image = "product14.jpg",
                            Name = "Product 14",
                            Price = 86m
                        },
                        new
                        {
                            Id = 15,
                            Description = "Synth!",
                            Image = "product15.jpg",
                            Name = "Product 15",
                            Price = 82m
                        },
                        new
                        {
                            Id = 16,
                            Description = "Synth!",
                            Image = "product16.jpg",
                            Name = "Product 16",
                            Price = 97m
                        },
                        new
                        {
                            Id = 17,
                            Description = "Synth!",
                            Image = "product17.jpg",
                            Name = "Product 17",
                            Price = 78m
                        },
                        new
                        {
                            Id = 18,
                            Description = "Synth!",
                            Image = "product18.jpg",
                            Name = "Product 18",
                            Price = 53m
                        },
                        new
                        {
                            Id = 19,
                            Description = "Synth!",
                            Image = "product19.jpg",
                            Name = "Product 19",
                            Price = 62m
                        },
                        new
                        {
                            Id = 20,
                            Description = "Synth!",
                            Image = "product20.jpg",
                            Name = "Product 20",
                            Price = 87m
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("WebApp.Models.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
