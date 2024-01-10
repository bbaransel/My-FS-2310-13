﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniShop.Data;

#nullable disable

namespace MiniShop.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MiniShop.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 10, 19, 38, 17, 579, DateTimeKind.Local).AddTicks(9565),
                            Description = "TV Kategorisi",
                            IsActive = true,
                            IsDelete = false,
                            ModifiedDate = new DateTime(2024, 1, 10, 19, 38, 17, 579, DateTimeKind.Local).AddTicks(9579),
                            Name = "Televizyon",
                            Url = "televizyon"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 10, 19, 38, 17, 579, DateTimeKind.Local).AddTicks(9582),
                            Description = "Bilgisayar Kategorisi",
                            IsActive = true,
                            IsDelete = false,
                            ModifiedDate = new DateTime(2024, 1, 10, 19, 38, 17, 579, DateTimeKind.Local).AddTicks(9582),
                            Name = "Bilgisayar",
                            Url = "bilgisayar"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 1, 10, 19, 38, 17, 579, DateTimeKind.Local).AddTicks(9583),
                            Description = "Elektronik Eşya Kategorisi",
                            IsActive = true,
                            IsDelete = false,
                            ModifiedDate = new DateTime(2024, 1, 10, 19, 38, 17, 579, DateTimeKind.Local).AddTicks(9583),
                            Name = "Elektronik Eşya",
                            Url = "elektronik-esya"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 1, 10, 19, 38, 17, 579, DateTimeKind.Local).AddTicks(9617),
                            Description = "Beyaz Eşya Kategorisi",
                            IsActive = true,
                            IsDelete = false,
                            ModifiedDate = new DateTime(2024, 1, 10, 19, 38, 17, 579, DateTimeKind.Local).AddTicks(9617),
                            Name = "Beyaz Eşya",
                            Url = "beyaz-esya"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 1, 10, 19, 38, 17, 579, DateTimeKind.Local).AddTicks(9618),
                            Description = "Telefon Kategorisi",
                            IsActive = true,
                            IsDelete = false,
                            ModifiedDate = new DateTime(2024, 1, 10, 19, 38, 17, 579, DateTimeKind.Local).AddTicks(9619),
                            Name = "Telefon",
                            Url = "telefon"
                        });
                });

            modelBuilder.Entity("MiniShop.Entity.CategoryProduct", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CategoryProducts", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = 3,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 5,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryId = 5,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 3
                        },
                        new
                        {
                            CategoryId = 5,
                            ProductId = 3
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 4
                        },
                        new
                        {
                            CategoryId = 5,
                            ProductId = 4
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 5
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 5
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 6
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 6
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 7
                        },
                        new
                        {
                            CategoryId = 4,
                            ProductId = 7
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 8
                        },
                        new
                        {
                            CategoryId = 4,
                            ProductId = 8
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 9
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 10
                        },
                        new
                        {
                            CategoryId = 4,
                            ProductId = 10
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 11
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 11
                        },
                        new
                        {
                            CategoryId = 4,
                            ProductId = 11
                        });
                });

            modelBuilder.Entity("MiniShop.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHome")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Properties")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(329),
                            ImageUrl = "1.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(330),
                            Name = "IPhone 14",
                            Price = 59000m,
                            Properties = "Harika bir telefon",
                            Url = "iphone-14"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(363),
                            ImageUrl = "2.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(363),
                            Name = "IPhone 14 Pro",
                            Price = 69000m,
                            Properties = "Bu da harika bir telefon",
                            Url = "iphone-14-pro"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(365),
                            ImageUrl = "3.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(366),
                            Name = "Samsung S23",
                            Price = 49000m,
                            Properties = "İdare eder",
                            Url = "samsung-s23"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(367),
                            ImageUrl = "4.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(368),
                            Name = "Xaomi Note 4",
                            Price = 39000m,
                            Properties = "Harika bir telefon",
                            Url = "xaomi-note-4"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(369),
                            ImageUrl = "5.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(369),
                            Name = "MacBook Air M2",
                            Price = 52000m,
                            Properties = "M2nin gücü",
                            Url = "macbook-air-m2"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(370),
                            ImageUrl = "6.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(371),
                            Name = "MacBook Pro M3",
                            Price = 79000m,
                            Properties = "16gb ram",
                            Url = "macbook-pro-m3"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(372),
                            ImageUrl = "7.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(373),
                            Name = "Vestel Çamaşır Makinesi X65",
                            Price = 19000m,
                            Properties = "Akıllı makine",
                            Url = "vestel-camasir-makinesi-x65"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(374),
                            ImageUrl = "8.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(374),
                            Name = "Arçelik Çamaşır Makinesi A-4",
                            Price = 21000m,
                            Properties = "Süper hızlı makine",
                            Url = "arcelik-camasir-makinesi-a-4"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(376),
                            ImageUrl = "9.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(376),
                            Name = "Hoop Dijital Radyo X96",
                            Price = 1250m,
                            Properties = "Klasik radyo keyfi",
                            Url = "hoop-dijital-radyo-x96"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(377),
                            ImageUrl = "10.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(378),
                            Name = "Xaomi Dijital Baskül",
                            Price = 2100m,
                            Properties = "Kilonuzu kontrol edin",
                            Url = "xaomi-dijital-baskul"
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(379),
                            ImageUrl = "10.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 10, 19, 38, 17, 580, DateTimeKind.Local).AddTicks(379),
                            Name = "Blaupunkt AC69 Led TV",
                            Price = 9800m,
                            Properties = "Android TV",
                            Url = "blaupunkt-ac69-led-tv"
                        });
                });

            modelBuilder.Entity("MiniShop.Entity.CategoryProduct", b =>
                {
                    b.HasOne("MiniShop.Entity.Category", "Category")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiniShop.Entity.Product", "Product")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MiniShop.Entity.Category", b =>
                {
                    b.Navigation("CategoryProducts");
                });

            modelBuilder.Entity("MiniShop.Entity.Product", b =>
                {
                    b.Navigation("CategoryProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
