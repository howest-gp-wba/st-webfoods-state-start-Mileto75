﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wba.WebFoods.Web.Data;

#nullable disable

namespace Wba.WebFoods.Web.Migrations
{
    [DbContext(typeof(WebFoodsDbContext))]
    [Migration("20231109123642_seeding")]
    partial class seeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProductProperty", b =>
                {
                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("PropertiesId")
                        .HasColumnType("int");

                    b.HasKey("ProductsId", "PropertiesId");

                    b.HasIndex("PropertiesId");

                    b.ToTable("ProductProperty");

                    b.HasData(
                        new
                        {
                            ProductsId = 1,
                            PropertiesId = 1
                        },
                        new
                        {
                            ProductsId = 1,
                            PropertiesId = 2
                        },
                        new
                        {
                            ProductsId = 2,
                            PropertiesId = 3
                        },
                        new
                        {
                            ProductsId = 2,
                            PropertiesId = 2
                        },
                        new
                        {
                            ProductsId = 3,
                            PropertiesId = 3
                        },
                        new
                        {
                            ProductsId = 3,
                            PropertiesId = 4
                        },
                        new
                        {
                            ProductsId = 3,
                            PropertiesId = 5
                        });
                });

            modelBuilder.Entity("Wba.WebFoods.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Antipasti"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Primi"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Secondi"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dessert"
                        });
                });

            modelBuilder.Entity("Wba.WebFoods.Core.Entities.OrderLine", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderLines");
                });

            modelBuilder.Entity("Wba.WebFoods.Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Very goodie",
                            Name = "Bruschetta mista",
                            Price = 10.00m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Meat",
                            Name = "Affetati rustica",
                            Price = 12.50m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "A classic",
                            Name = "Spaghetti carbonara",
                            Price = 13.90m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Hot dish",
                            Name = "Penne all'arrabiata",
                            Price = 13.80m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            Description = "Classic meat",
                            Name = "Osso buco alla Milanese",
                            Price = 23.80m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "Vegan meat",
                            Name = "Saltimbocca all'Abruzzese",
                            Price = 25.80m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            Description = "Vegan woodfruit",
                            Name = "Millefoglie au frutti di bosco",
                            Price = 14.80m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            Description = "Chocolate and alcohol",
                            Name = "Tartufo all'amaro",
                            Price = 12.80m
                        });
                });

            modelBuilder.Entity("Wba.WebFoods.Core.Entities.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Spicy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Vegan"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Meatlovers"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Gluten free"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Sugar free"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Traditional"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Modern Italian"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Fusion"
                        });
                });

            modelBuilder.Entity("Wba.WebFoods.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProductProperty", b =>
                {
                    b.HasOne("Wba.WebFoods.Core.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Wba.WebFoods.Core.Entities.Property", null)
                        .WithMany()
                        .HasForeignKey("PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Wba.WebFoods.Core.Entities.OrderLine", b =>
                {
                    b.HasOne("Wba.WebFoods.Core.Entities.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Wba.WebFoods.Core.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Wba.WebFoods.Core.Entities.Product", b =>
                {
                    b.HasOne("Wba.WebFoods.Core.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Wba.WebFoods.Core.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Wba.WebFoods.Core.Entities.Product", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Wba.WebFoods.Core.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
