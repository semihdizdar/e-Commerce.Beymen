﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stock.Repository;

namespace Stock.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Stock.Core.Model.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MetaDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductCode")
                        .IsUnique()
                        .HasFilter("[ProductCode] IS NOT NULL");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            AdminComment = "Stok var",
                            CreatedDate = new DateTime(2022, 2, 25, 2, 51, 44, 54, DateTimeKind.Utc).AddTicks(9910),
                            MetaDescription = "Iphone 12 CellPhone",
                            Name = "Iphone 12",
                            ProductCode = "IPHONE12",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProductId = 2,
                            AdminComment = "Stok var",
                            CreatedDate = new DateTime(2022, 2, 25, 2, 51, 44, 55, DateTimeKind.Utc).AddTicks(8873),
                            MetaDescription = "Iphone 13 CellPhone",
                            Name = "Iphone 13",
                            ProductCode = "IPHONE13",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Stock.Core.Model.StockInfo", b =>
                {
                    b.Property<int>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 2, 25, 5, 51, 44, 51, DateTimeKind.Local).AddTicks(5663));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

                    b.Property<int>("VariantId")
                        .HasColumnType("int");

                    b.HasKey("StockId");

                    b.HasIndex("ProductId");

                    b.HasIndex("VariantId");

                    b.ToTable("StockInfo");

                    b.HasData(
                        new
                        {
                            StockId = 1,
                            CreatedDate = new DateTime(2022, 2, 25, 2, 51, 44, 56, DateTimeKind.Utc).AddTicks(3446),
                            ProductId = 1,
                            Quantity = 30,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VariantId = 1
                        },
                        new
                        {
                            StockId = 2,
                            CreatedDate = new DateTime(2022, 2, 25, 2, 51, 44, 56, DateTimeKind.Utc).AddTicks(3854),
                            ProductId = 1,
                            Quantity = 40,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VariantId = 2
                        },
                        new
                        {
                            StockId = 3,
                            CreatedDate = new DateTime(2022, 2, 25, 2, 51, 44, 56, DateTimeKind.Utc).AddTicks(3874),
                            ProductId = 1,
                            Quantity = 60,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VariantId = 3
                        },
                        new
                        {
                            StockId = 4,
                            CreatedDate = new DateTime(2022, 2, 25, 2, 51, 44, 56, DateTimeKind.Utc).AddTicks(3876),
                            ProductId = 2,
                            Quantity = 70,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VariantId = 4
                        });
                });

            modelBuilder.Entity("Stock.Core.Model.Variant", b =>
                {
                    b.Property<int>("VariantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VariantCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VariantId");

                    b.HasIndex("ProductId");

                    b.HasIndex("VariantId")
                        .IsUnique();

                    b.ToTable("Variants");

                    b.HasData(
                        new
                        {
                            VariantId = 1,
                            CreatedDate = new DateTime(2022, 2, 25, 2, 51, 44, 56, DateTimeKind.Utc).AddTicks(8139),
                            Name = "Rose - 128",
                            ProductId = 1,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VariantCode = "1000000851090"
                        },
                        new
                        {
                            VariantId = 2,
                            CreatedDate = new DateTime(2022, 2, 25, 2, 51, 44, 56, DateTimeKind.Utc).AddTicks(8533),
                            Name = "Rose - 64",
                            ProductId = 1,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VariantCode = "1000000851091"
                        },
                        new
                        {
                            VariantId = 3,
                            CreatedDate = new DateTime(2022, 2, 25, 2, 51, 44, 56, DateTimeKind.Utc).AddTicks(8548),
                            Name = "Gold - 64",
                            ProductId = 1,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VariantCode = "1000000851092"
                        },
                        new
                        {
                            VariantId = 4,
                            CreatedDate = new DateTime(2022, 2, 25, 2, 51, 44, 56, DateTimeKind.Utc).AddTicks(8552),
                            Name = "Gold - 128",
                            ProductId = 2,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            VariantCode = "1000000851093"
                        });
                });

            modelBuilder.Entity("Stock.Core.Model.StockInfo", b =>
                {
                    b.HasOne("Stock.Core.Model.Product", "Product")
                        .WithMany("Stocks")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Stock.Core.Model.Variant", "Variant")
                        .WithMany()
                        .HasForeignKey("VariantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Stock.Core.Model.Variant", b =>
                {
                    b.HasOne("Stock.Core.Model.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
