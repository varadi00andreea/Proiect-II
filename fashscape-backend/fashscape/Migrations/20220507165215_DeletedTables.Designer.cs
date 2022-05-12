﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fashscape.Context;

namespace fashscape.Migrations
{
    [DbContext(typeof(FashscapeContext))]
    [Migration("20220507165215_DeletedTables")]
    partial class DeletedTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("fashscape.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Popular from the early 1990s to the mid 2000s, baggy jeans are back in style. They have a cool factor to them that makes even the simplest wardrobes come to life.",
                            Name = "Baggy Jeans",
                            Price = 89.989999999999995,
                            Size = "38"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Perfect for summer days. Very soft material.",
                            Name = "Casual Dress",
                            Price = 47.0,
                            Size = "Universal"
                        },
                        new
                        {
                            Id = 3,
                            Description = "I've recently buyed it but it's not the right size. I have to say it's not very stretchy.",
                            Name = "Pink Crop Top",
                            Price = 62.299999999999997,
                            Size = "S"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Perfect for a summerish wedding.",
                            Name = "Gown",
                            Price = 326.99000000000001,
                            Size = "36-38"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Form-flattering that provides ultimate comfort in high intensity workout.",
                            Name = "Gym Leggings",
                            Price = 89.900000000000006,
                            Size = "S"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Great if you are looking for a fashion forward twist on classic denim jeans.",
                            Name = "Black Flared Jeans",
                            Price = 120.98999999999999,
                            Size = "40"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Knee high boots are a staple in every wardrobe.",
                            Name = "Knee High Boots",
                            Price = 200.0,
                            Size = "39"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Very nice color. It looks good on anyone.",
                            Name = "Split Maxi Dress",
                            Price = 170.0,
                            Size = "M"
                        },
                        new
                        {
                            Id = 9,
                            Description = "High heeled sandals. You can wear them for a casual look or even for a party.",
                            Name = "Sandals",
                            Price = 219.90000000000001,
                            Size = "37"
                        });
                });

            modelBuilder.Entity("fashscape.Models.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("fashscape.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Samuel Micu, nr. 5, Alba Iulia",
                            Email = "andreea526@gmail.com",
                            FirstName = "Andreea",
                            LastName = "Varadi",
                            Password = "qwerty123",
                            PhoneNumber = "0745832667",
                            Username = "andreea12"
                        });
                });

            modelBuilder.Entity("fashscape.Models.ShoppingCart", b =>
                {
                    b.HasOne("fashscape.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
