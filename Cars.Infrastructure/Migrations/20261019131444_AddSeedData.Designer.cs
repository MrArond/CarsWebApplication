using System;
using Cars.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cars.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20261019131444_AddSeedData")]
    partial class AddSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "10.0.13");

            modelBuilder.Entity("Cars.Domain.Car", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AverageFuelConsumption")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BodyType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DoorsNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EngineCapacity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("LuggageCapacity")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("ProductionDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            id = "11111111-1111-1111-1111-111111111111",
                            AverageFuelConsumption = 5,
                            BodyType = "Sedan",
                            DoorsNumber = 4,
                            EngineCapacity = 1598,
                            FuelType = "Petrol",
                            LuggageCapacity = 452,
                            ProductionDate = new DateOnly(2019, 3, 15),
                            brand = "Toyota",
                            model = "Corolla"
                        },
                        new
                        {
                            id = "22222222-2222-2222-2222-222222222222",
                            AverageFuelConsumption = 8,
                            BodyType = "SUV",
                            DoorsNumber = 5,
                            EngineCapacity = 2998,
                            FuelType = "Diesel",
                            LuggageCapacity = 645,
                            ProductionDate = new DateOnly(2021, 6, 1),
                            brand = "BMW",
                            model = "X5"
                        },
                        new
                        {
                            id = "33333333-3333-3333-3333-333333333333",
                            AverageFuelConsumption = 0,
                            BodyType = "Sedan",
                            DoorsNumber = 4,
                            EngineCapacity = 0,
                            FuelType = "Electric",
                            LuggageCapacity = 425,
                            ProductionDate = new DateOnly(2023, 1, 20),
                            brand = "Tesla",
                            model = "Model 3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
