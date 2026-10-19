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
    [Migration("20261019130705_InitialCreate")]
    partial class InitialCreate
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
                });
#pragma warning restore 612, 618
        }
    }
}
