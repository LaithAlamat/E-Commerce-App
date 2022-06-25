﻿// <auto-generated />
using System;
using E_Commerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_Commerce.Migrations
{
    [DbContext(typeof(E_CommerceDbContext))]
    [Migration("20220625135006_AddUrl")]
    partial class AddUrl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("E_Commerce.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("CartID")
                        .HasColumnType("nvarchar(450)");

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

                    b.HasIndex("CartID");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("E_Commerce.Models.Cart", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("E_Commerce.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Find all PCs and Laptops in our store here!",
                            Name = "PC && Laptops",
                            URL = "data:image/png;base64,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"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Find Speakers and headsets in our store here!",
                            Name = "Audio Devices",
                            URL = "https://w7.pngwing.com/pngs/368/623/png-transparent-symbol-computer-icons-audio-signal-loudspeaker-encapsulated-postscript-loudspeaker-miscellaneous-text-logo.png"
                        },
                        new
                        {
                            ID = 3,
                            Description = "Find all Televitions in our store here!",
                            Name = "Televitions and Monitors",
                            URL = "https://i.pinimg.com/736x/5b/6c/d7/5b6cd7388dc2e7825191cfbd31e25c1d.jpg"
                        },
                        new
                        {
                            ID = 4,
                            Description = "Find all moblie devices in our store here!",
                            Name = "Mobile Phones",
                            URL = "https://d1csarkz8obe9u.cloudfront.net/posterpreviews/cell-phone-design-template-608242c6014c909324ec156c32889970_screen.jpg?ts=1581061060"
                        });
                });

            modelBuilder.Entity("E_Commerce.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CartID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CartID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 1,
                            Description = "A gaming laptop with great performance",
                            InStock = true,
                            Name = "ASUS Laptop",
                            Price = 1000.0,
                            URL = ""
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = 1,
                            Description = "A gaming laptop with great performance",
                            InStock = true,
                            Name = "Acer Laptop",
                            Price = 900.0,
                            URL = ""
                        },
                        new
                        {
                            ID = 3,
                            CategoryID = 1,
                            Description = "A descktop pc with great performance",
                            InStock = true,
                            Name = "iMac Retina",
                            Price = 1500.0,
                            URL = ""
                        },
                        new
                        {
                            ID = 4,
                            CategoryID = 1,
                            Description = "Dell OptiPlex 7780 All-in-One 10Gen Intel Core i7 up to 4.8GHz 16M 6-Cores , 8GB RAM DDR4 (upgradable) , 256 GB Gen 3 PCIe x4 NVMe SSD + 1TB HDD , 27inch WVA Full HD 250nits Screen, NO Optical Drive,Intel UHD 630 Graphic Card,",
                            InStock = true,
                            Name = "Dell OptiPlex 7780 All-in-One All-in-One 10Gen Intel Core i7 w/ Adjustable 27inch Touch",
                            Price = 1000.0,
                            URL = ""
                        },
                        new
                        {
                            ID = 5,
                            CategoryID = 2,
                            Description = "5.1 digital surround sound: Hear every detail in your Dolby Digital and DTS soundtracks the way the studio intended. Sub woofer: 165 Watts",
                            InStock = true,
                            Name = "Logitech Z906 5.1 Surround Sound Speaker System THX, Dolby Digital & DTS Digital Certified",
                            Price = 100.0,
                            URL = ""
                        },
                        new
                        {
                            ID = 6,
                            CategoryID = 2,
                            Description = "High performance speaker system that produces 50 Watts of raw, rock solid audio power",
                            InStock = true,
                            Name = "Creative SBS E2800 2.1 High Performance Speakers System - Black",
                            Price = 55.0,
                            URL = ""
                        },
                        new
                        {
                            ID = 7,
                            CategoryID = 3,
                            Description = "4-Series 4K UHD smart TV",
                            InStock = true,
                            Name = "Amazon Fire TV 43",
                            Price = 250.0,
                            URL = ""
                        },
                        new
                        {
                            ID = 8,
                            CategoryID = 3,
                            Description = "Class LED 4K UHD Smart Fire TV (PN43951-22U, 2021 Model)",
                            InStock = true,
                            Name = "Pioneer 43-inch",
                            Price = 210.0,
                            URL = ""
                        },
                        new
                        {
                            ID = 9,
                            CategoryID = 4,
                            Description = "Apple Flagship mobile phone with 256GB",
                            InStock = false,
                            Name = "iPhone 13 Pro Max",
                            Price = 1200.0,
                            URL = ""
                        },
                        new
                        {
                            ID = 10,
                            CategoryID = 4,
                            Description = "Samsung Flagship mobile phone with 256GB",
                            InStock = true,
                            Name = "Samsung Galaxy S22 Ultra",
                            Price = 1000.0,
                            URL = "https://shop.samsung.com/ie/images/products/28636/21040/2000x2000/SM-S908BZKDEUB.webp"
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

                    b.HasData(
                        new
                        {
                            Id = "administrator",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "editor",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "editor",
                            NormalizedName = "EDITOR"
                        },
                        new
                        {
                            Id = "user",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "user",
                            NormalizedName = "USER"
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "permissions",
                            ClaimValue = "create",
                            RoleId = "administrator"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "permissions",
                            ClaimValue = "delete",
                            RoleId = "administrator"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "permissions",
                            ClaimValue = "create",
                            RoleId = "editor"
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "permissions",
                            ClaimValue = "update",
                            RoleId = "editor"
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "permissions",
                            ClaimValue = "create",
                            RoleId = "user"
                        });
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

            modelBuilder.Entity("E_Commerce.Models.ApplicationUser", b =>
                {
                    b.HasOne("E_Commerce.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartID");

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("E_Commerce.Models.Product", b =>
                {
                    b.HasOne("E_Commerce.Models.Cart", null)
                        .WithMany("Products")
                        .HasForeignKey("CartID");

                    b.HasOne("E_Commerce.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
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
                    b.HasOne("E_Commerce.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("E_Commerce.Models.ApplicationUser", null)
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

                    b.HasOne("E_Commerce.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("E_Commerce.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("E_Commerce.Models.Cart", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("E_Commerce.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
