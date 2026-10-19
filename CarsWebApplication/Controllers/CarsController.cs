using Cars.Domain;
using Cars.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarsWebApplication.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarsController : ControllerBase
{
    private readonly DataContext _context;

    public CarsController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Car>>> GetCars()
    {
        var cars = await _context.Cars
            .AsNoTracking()
            .ToListAsync();

        return Ok(cars);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Car>> GetCar(string id)
    {
        var car = await _context.Cars
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.id == id);

        if (car is null)
        {
            return NotFound();
        }

        return Ok(car);
    }

    [HttpPost]
    public async Task<ActionResult<Car>> CreateCar(Car car)
    {
        _context.Cars.Add(car);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCar), new { id = car.id }, car);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCar(string id, Car car)
    {
        var existingCar = await _context.Cars.FindAsync(id);

        if (existingCar is null)
        {
            return NotFound();
        }

        if (id != car.id)
        {
            return BadRequest("Identyfikator w adresie musi być zgodny z identyfikatorem w treści żądania.");
        }

        existingCar.brand = car.brand;
        existingCar.model = car.model;
        existingCar.DoorsNumber = car.DoorsNumber;
        existingCar.LuggageCapacity = car.LuggageCapacity;
        existingCar.EngineCapacity = car.EngineCapacity;
        existingCar.FuelType = car.FuelType;
        existingCar.ProductionDate = car.ProductionDate;
        existingCar.AverageFuelConsumption = car.AverageFuelConsumption;
        existingCar.BodyType = car.BodyType;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCar(string id)
    {
        var car = await _context.Cars.FindAsync(id);

        if (car is null)
        {
            return NotFound();
        }

        _context.Cars.Remove(car);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
