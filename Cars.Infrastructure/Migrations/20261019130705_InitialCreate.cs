using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    id = table.Column<string>(type: "TEXT", nullable: false),
                    brand = table.Column<string>(type: "TEXT", nullable: false),
                    model = table.Column<string>(type: "TEXT", nullable: false),
                    DoorsNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    LuggageCapacity = table.Column<int>(type: "INTEGER", nullable: false),
                    EngineCapacity = table.Column<int>(type: "INTEGER", nullable: false),
                    FuelType = table.Column<string>(type: "TEXT", nullable: false),
                    ProductionDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    AverageFuelConsumption = table.Column<int>(type: "INTEGER", nullable: false),
                    BodyType = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
