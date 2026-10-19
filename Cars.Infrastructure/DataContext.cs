using Cars.Domain;
using Microsoft.EntityFrameworkCore;

namespace Cars.Infrastructure;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Car> Cars => Set<Car>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Car>().HasData(
            new Car
            {
                id = "11111111-1111-1111-1111-111111111111",
                brand = "Toyota",
                model = "Corolla",
                DoorsNumber = 4,
                LuggageCapacity = 452,
                EngineCapacity = 1598,
                FuelType = "Petrol",
                ProductionDate = new DateOnly(2019, 3, 15),
                AverageFuelConsumption = 5,
                BodyType = "Sedan"
            },
            new Car
            {
                id = "22222222-2222-2222-2222-222222222222",
                brand = "BMW",
                model = "X5",
                DoorsNumber = 5,
                LuggageCapacity = 645,
                EngineCapacity = 2998,
                FuelType = "Diesel",
                ProductionDate = new DateOnly(2021, 6, 1),
                AverageFuelConsumption = 8,
                BodyType = "SUV"
            },
            new Car
            {
                id = "33333333-3333-3333-3333-333333333333",
                brand = "Tesla",
                model = "Model 3",
                DoorsNumber = 4,
                LuggageCapacity = 425,
                EngineCapacity = 0,
                FuelType = "Electric",
                ProductionDate = new DateOnly(2023, 1, 20),
                AverageFuelConsumption = 0,
                BodyType = "Sedan"
            });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=cars.db");
        }
    }
}
