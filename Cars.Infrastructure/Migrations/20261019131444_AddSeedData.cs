using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814

namespace Cars.Infrastructure.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "id", "AverageFuelConsumption", "BodyType", "DoorsNumber", "EngineCapacity", "FuelType", "LuggageCapacity", "ProductionDate", "brand", "model" },
                values: new object[,]
                {
                    { "11111111-1111-1111-1111-111111111111", 5, "Sedan", 4, 1598, "Petrol", 452, new DateOnly(2019, 3, 15), "Toyota", "Corolla" },
                    { "22222222-2222-2222-2222-222222222222", 8, "SUV", 5, 2998, "Diesel", 645, new DateOnly(2021, 6, 1), "BMW", "X5" },
                    { "33333333-3333-3333-3333-333333333333", 0, "Sedan", 4, 0, "Electric", 425, new DateOnly(2023, 1, 20), "Tesla", "Model 3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "id",
                keyValue: "11111111-1111-1111-1111-111111111111");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "id",
                keyValue: "22222222-2222-2222-2222-222222222222");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "id",
                keyValue: "33333333-3333-3333-3333-333333333333");
        }
    }
}
