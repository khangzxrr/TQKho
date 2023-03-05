﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TQKho.Contexts;

#nullable disable

namespace TQKho.Migrations
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("TQKho.Models.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("poCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("productCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("shelfCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("productId");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}