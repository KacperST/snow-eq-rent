﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace RentMVCApp.Migrations
{
    [DbContext(typeof(ContextDb))]
    [Migration("20230531221421_ModelsUpdate")]
    partial class ModelsUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("RentMVCApp.Models.Company", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("addres")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("openUntil")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("openfrom")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("RentMVCApp.Models.Item", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("availability")
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<int>("price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("type")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("RentMVCApp.Models.Reservation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("itemID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("reservedFrom")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("reservedUntill")
                        .HasColumnType("TEXT");

                    b.Property<int?>("userID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("itemID");

                    b.HasIndex("userID");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("RentMVCApp.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("addres")
                        .HasColumnType("TEXT");

                    b.Property<string>("lastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("RentMVCApp.Models.Reservation", b =>
                {
                    b.HasOne("RentMVCApp.Models.Item", "item")
                        .WithMany()
                        .HasForeignKey("itemID");

                    b.HasOne("RentMVCApp.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userID");

                    b.Navigation("item");

                    b.Navigation("user");
                });
#pragma warning restore 612, 618
        }
    }
}