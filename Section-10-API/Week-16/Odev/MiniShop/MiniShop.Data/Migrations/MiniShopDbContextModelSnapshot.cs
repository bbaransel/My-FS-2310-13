﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniShop.Data.Concrete.Contexts;

#nullable disable

namespace MiniShop.Data.Migrations
{
    [DbContext(typeof(MiniShopDbContext))]
    partial class MiniShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.15");

            modelBuilder.Entity("MiniShop.Entity.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(1394),
                            Description = "TV kategorisi",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(1406),
                            Name = "Televizyon",
                            Url = "televizyon"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(1410),
                            Description = "Bilgisayar kategorisi",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(1410),
                            Name = "Bilgisayar",
                            Url = "bilgisayar"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(1411),
                            Description = "Elektronik Eşya kategorisi",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(1411),
                            Name = "Elektronik Eşya",
                            Url = "elektronik-esya"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(1413),
                            Description = "Beyaz Eşya kategorisi",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(1413),
                            Name = "Beyaz Eşya",
                            Url = "beyaz-esya"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(1414),
                            Description = "Telefon kategorisi",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(1414),
                            Name = "Telefon",
                            Url = "telefon"
                        });
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("date('now')");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("date('now')");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("real");

                    b.Property<string>("Properties")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6800),
                            ImageUrl = "1.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6807),
                            Name = "IPhone 14",
                            Price = 59000m,
                            Properties = "Harika bir telefon",
                            Url = "iphone-14"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6818),
                            ImageUrl = "2.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6819),
                            Name = "IPhone 14 Pro",
                            Price = 69000m,
                            Properties = "Bu da harika bir telefon",
                            Url = "iphone-14-pro"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6821),
                            ImageUrl = "3.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6821),
                            Name = "Samsung S23",
                            Price = 49000m,
                            Properties = "İdare eder",
                            Url = "samsung-s23"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6822),
                            ImageUrl = "4.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6823),
                            Name = "Xaomi Note 4",
                            Price = 39000m,
                            Properties = "Harika bir telefon",
                            Url = "xaomi-note-4"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6824),
                            ImageUrl = "5.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6825),
                            Name = "MacBook Air M2",
                            Price = 52000m,
                            Properties = "M2nin gücü",
                            Url = "macbook-air-m2"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6826),
                            ImageUrl = "6.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6826),
                            Name = "MacBook Pro M3",
                            Price = 79000m,
                            Properties = "16 Gb ram",
                            Url = "macbook-pro-m3"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6828),
                            ImageUrl = "7.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6828),
                            Name = "Vestel Çamaşır Makinesi X65",
                            Price = 19000m,
                            Properties = "Akıllı makine",
                            Url = "vestel-camasir-makinesi-x65"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6830),
                            ImageUrl = "8.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6830),
                            Name = "Arçelik Çamaşır Makinesi A-4",
                            Price = 21000m,
                            Properties = "Süper hızlı makine",
                            Url = "arcelik-camasir-makinesi-a-4"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6832),
                            ImageUrl = "9.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6833),
                            Name = "Hoop Dijital Radyo X96",
                            Price = 1250m,
                            Properties = "Klasik radyo keyfi",
                            Url = "hoop-dijital-radyo-x96"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6834),
                            ImageUrl = "10.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6834),
                            Name = "Xaomi Dijital Baskül",
                            Price = 2100m,
                            Properties = "Kilonuzu kontrol edin",
                            Url = "xaomi-dijital-baskul"
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6836),
                            ImageUrl = "11.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 27, 10, 59, 42, 692, DateTimeKind.Local).AddTicks(6836),
                            Name = "Blaupunkt AC69 Led TV",
                            Price = 9800m,
                            Properties = "Android tv",
                            Url = "blaupunkt-ac69-led-tv"
                        });
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories", (string)null);

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 1,
                            CategoryId = 5
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 5
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 5
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 5
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 4
                        });
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.ProductCategory", b =>
                {
                    b.HasOne("MiniShop.Entity.Concrete.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiniShop.Entity.Concrete.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.Product", b =>
                {
                    b.Navigation("ProductCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
