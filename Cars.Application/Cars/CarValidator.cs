using Cars.Domain;
using FluentValidation;

namespace Cars.Application.Cars;

public class CarValidator : AbstractValidator<Car>
{
    public CarValidator()
    {
        RuleFor(x => x.brand)
            .NotEmpty()
            .WithMessage("Brand is required.");

        RuleFor(x => x.model)
            .NotEmpty()
            .WithMessage("Model is required.");

        RuleFor(x => x.DoorsNumber)
            .InclusiveBetween(2, 5)
            .WithMessage("Doors number must be between 2 and 5.");

        RuleFor(x => x.LuggageCapacity)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Luggage capacity cannot be negative.");

        RuleFor(x => x.EngineCapacity)
            .GreaterThan(0)
            .WithMessage("Engine capacity must be greater than 0.");

        RuleFor(x => x.ProductionDate)
            .LessThanOrEqualTo(DateOnly.FromDateTime(DateTime.UtcNow))
            .WithMessage("Production date cannot be in the future.");

        RuleFor(x => x.AverageFuelConsumption)
            .GreaterThan(0)
            .WithMessage("Average fuel consumption must be greater than 0.");
    }
}
