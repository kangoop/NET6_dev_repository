﻿// <auto-generated />
using System;
using BikeShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BikeShop.Migrations
{
    [DbContext(typeof(ProductionDbContext))]
    partial class ProductionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BikeShop.Models.Brand", b =>
                {
                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CREATETIME")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 11, 23, 0, 1, 2, 948, DateTimeKind.Local).AddTicks(2904));

                    b.Property<string>("ISUSEABLE")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("brands");
                });

            modelBuilder.Entity("BikeShop.Models.Category", b =>
                {
                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CREATETIME")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 11, 23, 0, 1, 2, 948, DateTimeKind.Local).AddTicks(2568));

                    b.Property<string>("ISUSEABLE")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("BikeShop.Models.Product", b =>
                {
                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<int>("brand_id")
                        .HasColumnType("int");

                    b.Property<int>("category_id")
                        .HasColumnType("int");

                    b.Property<int>("model_year")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("products");
                });
#pragma warning restore 612, 618
        }
    }
}
