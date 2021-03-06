﻿// <auto-generated />
using System;
using GroceriesStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroceriesStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("GroceriesStore.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Apples"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Bananas"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Oranges"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Grapes"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Tomato"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Strawberry"
                        });
                });

            modelBuilder.Entity("GroceriesStore.Models.Groceries", b =>
                {
                    b.Property<int>("GroceriesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("GroceriesId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Groceries");

                    b.HasData(
                        new
                        {
                            GroceriesId = 1,
                            CategoryId = 2,
                            Description = "Nice Yellow Banana",
                            ImageUrl = "\\Images\\banana.jpg",
                            IsOnSale = false,
                            IsOnStock = true,
                            Name = "Yellow Banana",
                            Price = 50m
                        },
                        new
                        {
                            GroceriesId = 2,
                            CategoryId = 2,
                            Description = "Nice Green Banana",
                            ImageUrl = "\\Images\\greenbanana.jpg",
                            IsOnSale = false,
                            IsOnStock = true,
                            Name = "Green Banana",
                            Price = 40m
                        },
                        new
                        {
                            GroceriesId = 3,
                            CategoryId = 1,
                            Description = "Nice Red Apple",
                            ImageUrl = "\\Images\\redapple.jpg",
                            IsOnSale = true,
                            IsOnStock = true,
                            Name = "Red Apple",
                            Price = 30m
                        },
                        new
                        {
                            GroceriesId = 4,
                            CategoryId = 1,
                            Description = "Nice Yellow Apple",
                            ImageUrl = "\\Images\\yellowapple.jpg",
                            IsOnSale = true,
                            IsOnStock = true,
                            Name = "Yellow Apple",
                            Price = 35m
                        },
                        new
                        {
                            GroceriesId = 5,
                            CategoryId = 1,
                            Description = "Nice Green Apple",
                            ImageUrl = "\\Images\\greenapple.jpg",
                            IsOnSale = false,
                            IsOnStock = true,
                            Name = "Green Apple",
                            Price = 50m
                        },
                        new
                        {
                            GroceriesId = 6,
                            CategoryId = 3,
                            Description = "Nice Orange",
                            ImageUrl = "\\Images\\orange.jpg",
                            IsOnSale = false,
                            IsOnStock = true,
                            Name = "Orange",
                            Price = 54m
                        },
                        new
                        {
                            GroceriesId = 7,
                            CategoryId = 3,
                            Description = "Nice Red Orange",
                            ImageUrl = "\\Images\\redorange.jpg",
                            IsOnSale = false,
                            IsOnStock = true,
                            Name = "Red Orange",
                            Price = 75m
                        },
                        new
                        {
                            GroceriesId = 8,
                            CategoryId = 3,
                            Description = "Nice Mandarina",
                            ImageUrl = "\\Images\\mandarina.jpg",
                            IsOnSale = false,
                            IsOnStock = true,
                            Name = "Mandarina",
                            Price = 100m
                        },
                        new
                        {
                            GroceriesId = 9,
                            CategoryId = 4,
                            Description = "Nice Grape",
                            ImageUrl = "\\Images\\grape.jpg",
                            IsOnSale = false,
                            IsOnStock = true,
                            Name = "Grape",
                            Price = 100m
                        },
                        new
                        {
                            GroceriesId = 10,
                            CategoryId = 4,
                            Description = "Nice Red Grape",
                            ImageThumbnailUrl = "\\Images\\thumbnail\\redgrapesmall.jpg",
                            ImageUrl = "\\Images\\redgrape.jpg",
                            IsOnSale = true,
                            IsOnStock = true,
                            Name = "Red Grape",
                            Price = 100m
                        },
                        new
                        {
                            GroceriesId = 11,
                            CategoryId = 4,
                            Description = "Nice Yellow Grape",
                            ImageUrl = "\\Images\\yellowgrape.jpg",
                            IsOnSale = true,
                            IsOnStock = true,
                            Name = "Yellow Grape",
                            Price = 110m
                        },
                        new
                        {
                            GroceriesId = 12,
                            CategoryId = 5,
                            Description = "Nice Tomato",
                            ImageUrl = "\\Images\\tomato.jpg",
                            IsOnSale = false,
                            IsOnStock = true,
                            Name = "Tomato",
                            Price = 150m
                        },
                        new
                        {
                            GroceriesId = 13,
                            CategoryId = 6,
                            Description = "Nice Red Strawberry",
                            ImageUrl = "\\Images\\strawberry.jpg",
                            IsOnSale = false,
                            IsOnStock = true,
                            Name = "Strawberry",
                            Price = 250m
                        });
                });

            modelBuilder.Entity("GroceriesStore.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("GroceriesStore.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("GroceriesId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("GroceriesId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("GroceriesStore.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("GroceriesId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("GroceriesId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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

            modelBuilder.Entity("GroceriesStore.Models.Groceries", b =>
                {
                    b.HasOne("GroceriesStore.Models.Category", "Category")
                        .WithMany("Groceries")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("GroceriesStore.Models.OrderDetail", b =>
                {
                    b.HasOne("GroceriesStore.Models.Groceries", "Groceries")
                        .WithMany()
                        .HasForeignKey("GroceriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroceriesStore.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Groceries");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("GroceriesStore.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("GroceriesStore.Models.Groceries", "Groceries")
                        .WithMany()
                        .HasForeignKey("GroceriesId");

                    b.Navigation("Groceries");
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

            modelBuilder.Entity("GroceriesStore.Models.Category", b =>
                {
                    b.Navigation("Groceries");
                });

            modelBuilder.Entity("GroceriesStore.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
