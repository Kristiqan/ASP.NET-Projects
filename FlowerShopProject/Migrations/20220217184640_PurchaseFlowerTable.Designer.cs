﻿// <auto-generated />
using System;
using FlowerShopProject.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlowerShopProject.Migrations
{
    [DbContext(typeof(FlowerShopDbContext))]
    [Migration("20220217184640_PurchaseFlowerTable")]
    partial class PurchaseFlowerTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FlowerShopProject.Data.Flower", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FlowerFamily")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlowerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("ShippingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ShippingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Flowers");
                });
#pragma warning restore 612, 618
        }
    }
}
