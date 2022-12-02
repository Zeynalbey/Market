﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuperMarket.Database;

#nullable disable

namespace SuperMarket.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221202154613_market_m2m")]
    partial class marketm2m
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SuperMarket.Database.Models.Market", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Markets", (string)null);
                });

            modelBuilder.Entity("SuperMarket.Database.Models.MarketProduct", b =>
                {
                    b.Property<int>("MarketId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("MarketId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("MarketProducts", (string)null);
                });

            modelBuilder.Entity("SuperMarket.Database.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("SuperMarket.Database.Models.MarketProduct", b =>
                {
                    b.HasOne("SuperMarket.Database.Models.Market", "Market")
                        .WithMany("MarketProducts")
                        .HasForeignKey("MarketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SuperMarket.Database.Models.Product", "Product")
                        .WithMany("MarketProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Market");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SuperMarket.Database.Models.Market", b =>
                {
                    b.Navigation("MarketProducts");
                });

            modelBuilder.Entity("SuperMarket.Database.Models.Product", b =>
                {
                    b.Navigation("MarketProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
