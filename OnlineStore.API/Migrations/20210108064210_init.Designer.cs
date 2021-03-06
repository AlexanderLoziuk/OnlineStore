﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineStore.API.Data;

namespace OnlineStore.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210108064210_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("OnlineStore.API.Models.Balance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<double>("Sum");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Balances");
                });

            modelBuilder.Entity("OnlineStore.API.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("OnlineStore.API.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientName");

                    b.Property<string>("ClientSurname");

                    b.Property<string>("DeliveryMethod");

                    b.Property<string>("Email");

                    b.Property<string>("Patronymic");

                    b.Property<string>("PaymentMethod");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Place");

                    b.Property<int>("PlaceNumber");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("OnlineStore.API.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ColorName");

                    b.HasKey("Id");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("OnlineStore.API.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<DateTime>("DateTimeOrder");

                    b.Property<int>("StatusId");

                    b.Property<double>("SumOrder");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("StatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OnlineStore.API.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsMain");

                    b.Property<int>("ProductId");

                    b.Property<string>("PublicId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("OnlineStore.API.Models.PhotoCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("PublicId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId")
                        .IsUnique();

                    b.ToTable("PhotoCategory");
                });

            modelBuilder.Entity("OnlineStore.API.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<int>("ColorId");

                    b.Property<double>("Cost");

                    b.Property<string>("Description");

                    b.Property<bool>("IsAvailable");

                    b.Property<int>("MinQuantity");

                    b.Property<string>("ProductName");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColorId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("OnlineStore.API.Models.Receipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAdded");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<double>("Sum");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("OnlineStore.API.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Новый"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Принят"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Выполнен"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Отменён"
                        });
                });

            modelBuilder.Entity("OnlineStore.API.Models.StringsOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("StringsOrders");
                });

            modelBuilder.Entity("OnlineStore.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OnlineStore.API.Models.Balance", b =>
                {
                    b.HasOne("OnlineStore.API.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineStore.API.Models.Order", b =>
                {
                    b.HasOne("OnlineStore.API.Models.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnlineStore.API.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineStore.API.Models.Photo", b =>
                {
                    b.HasOne("OnlineStore.API.Models.Product", "Product")
                        .WithMany("Photos")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineStore.API.Models.PhotoCategory", b =>
                {
                    b.HasOne("OnlineStore.API.Models.Category", "Category")
                        .WithOne("photoCategory")
                        .HasForeignKey("OnlineStore.API.Models.PhotoCategory", "CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineStore.API.Models.Product", b =>
                {
                    b.HasOne("OnlineStore.API.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnlineStore.API.Models.Color", "Color")
                        .WithMany("Products")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineStore.API.Models.Receipt", b =>
                {
                    b.HasOne("OnlineStore.API.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineStore.API.Models.StringsOrder", b =>
                {
                    b.HasOne("OnlineStore.API.Models.Product", "Product")
                        .WithMany("StringsOrder")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
