﻿// <auto-generated />
using System;
using FoodDelivery.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodDelivery.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181007141328_AddFoodTypesData")]
    partial class AddFoodTypesData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodDelivery.Data.Entities.Foods.Food", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<long?>("FoodTypeId");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(500);

                    b.Property<string>("LongDescription");

                    b.Property<string>("Name")
                        .HasMaxLength(150);

                    b.Property<decimal>("Price");

                    b.Property<long?>("RestaurantId");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(250);

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("FoodTypeId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("FoodDelivery.Data.Entities.Foods.FoodType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("FoodTypes");

                    b.HasData(
                        new { Id = 1L, CreatedBy = "seed", CreatedDate = new DateTime(2018, 10, 7, 22, 13, 28, 136, DateTimeKind.Local), Name = "Asian Foods", UpdatedBy = "seed", UpdatedDate = new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local) },
                        new { Id = 2L, CreatedBy = "seed", CreatedDate = new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local), Name = "Burgers", UpdatedBy = "seed", UpdatedDate = new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local) },
                        new { Id = 3L, CreatedBy = "seed", CreatedDate = new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local), Name = "Appetizers", UpdatedBy = "seed", UpdatedDate = new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local) },
                        new { Id = 4L, CreatedBy = "seed", CreatedDate = new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local), Name = "Desserts", UpdatedBy = "seed", UpdatedDate = new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local) },
                        new { Id = 5L, CreatedBy = "seed", CreatedDate = new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local), Name = "Breakfast", UpdatedBy = "seed", UpdatedDate = new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local) },
                        new { Id = 6L, CreatedBy = "seed", CreatedDate = new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local), Name = "Pizzas", UpdatedBy = "seed", UpdatedDate = new DateTime(2018, 10, 7, 22, 13, 28, 137, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("FoodDelivery.Data.Entities.Restaurants.Restaurant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(500);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("FoodDelivery.Data.Entities.Reviews.Review", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<long?>("FoodId");

                    b.Property<int>("Rating");

                    b.Property<string>("Remark")
                        .HasMaxLength(500);

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("FoodDelivery.Data.Entities.Foods.Food", b =>
                {
                    b.HasOne("FoodDelivery.Data.Entities.Foods.FoodType", "FoodType")
                        .WithMany()
                        .HasForeignKey("FoodTypeId");

                    b.HasOne("FoodDelivery.Data.Entities.Restaurants.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId");
                });

            modelBuilder.Entity("FoodDelivery.Data.Entities.Reviews.Review", b =>
                {
                    b.HasOne("FoodDelivery.Data.Entities.Foods.Food", "Food")
                        .WithMany("Reviews")
                        .HasForeignKey("FoodId");
                });
#pragma warning restore 612, 618
        }
    }
}