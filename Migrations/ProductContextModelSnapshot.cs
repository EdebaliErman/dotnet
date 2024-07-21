﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductApi.Models;

#nullable disable

namespace ProductApi.Migrations
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("ProductApi.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ProductStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductName = "IPhone 13",
                            ProductPrice = 50000m,
                            ProductStatus = false
                        },
                        new
                        {
                            ProductId = 2,
                            ProductName = "IPhone 14",
                            ProductPrice = 60000m,
                            ProductStatus = true
                        },
                        new
                        {
                            ProductId = 3,
                            ProductName = "IPhone 15",
                            ProductPrice = 70000m,
                            ProductStatus = true
                        },
                        new
                        {
                            ProductId = 4,
                            ProductName = "IPhone 16",
                            ProductPrice = 80000m,
                            ProductStatus = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
