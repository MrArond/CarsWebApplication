using Cars.Application.Cars;
using Cars.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarsWebApplication.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarsController : ControllerBase
{
    private readonly ISender _sender;

    public CarsController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    public async Task<ActionResult<List<Car>>> GetCars()
    {
        return await _sender.Send(new GetCarList.Query());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Car>> GetCar(string id)
    {
        var car = await _sender.Send(new Details.Query { Id = id });

        if (car is null)
        {
            return NotFound();
        }

        return car;
    }

    [HttpPost]
    public async Task<ActionResult<Car>> CreateCar(Car car)
    {
        var result = await _sender.Send(new Create.Command { Car = car });

        return CreatedAtAction(
            nameof(GetCar),
            new { id = result.id },
            result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCar(string id, Car car)
    {
        var result = await _sender.Send(new Edit.Command
        {
            Id = id,
            Car = car
        });

        if (!result)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCar(string id)
    {
        var result = await _sender.Send(new Delete.Command { Id = id });

        if (!result)
        {
            return NotFound();
        }

        return NoContent();
    }
}
