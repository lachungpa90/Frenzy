﻿// <auto-generated />
using System;
using FrenzyAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FrenzyAPI.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220514132222_UpdatedEntity")]
    partial class UpdatedEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DishName")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Models.PurchaseHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DishName")
                        .HasColumnType("TEXT");

                    b.Property<string>("RestaurantName")
                        .HasColumnType("TEXT");

                    b.Property<double>("TransactionAmount")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UsersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("PurchaseHistory");
                });

            modelBuilder.Entity("Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CashBalance")
                        .HasColumnType("REAL");

                    b.Property<string>("OpeningHours")
                        .HasColumnType("TEXT");

                    b.Property<string>("RestaurantName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CashBalance")
                        .HasColumnType("REAL");

                    b.Property<int>("Name")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Models.Menu", b =>
                {
                    b.HasOne("Models.Restaurant", "Restaurant")
                        .WithMany("Menu")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("Models.PurchaseHistory", b =>
                {
                    b.HasOne("Models.Users", null)
                        .WithMany("PurchaseHistory")
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("Models.Restaurant", b =>
                {
                    b.Navigation("Menu");
                });

            modelBuilder.Entity("Models.Users", b =>
                {
                    b.Navigation("PurchaseHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
