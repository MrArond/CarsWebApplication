namespace Cars.Domain;
public class Car
{
    public required string  id { get; set; }
    public required string  brand { get; set; }
    public required string  model { get; set; }
    public int DoorsNumber { get; set; }
    public int LuggageCapacity { get; set; }
    public int EngineCapacity { get; set; }
    
    public required string FuelType { get; set; }
    public DateOnly ProductionDate { get; set; }
    public int AverageFuelConsumption { get; set; }
    public required string BodyType { get; set; }
}
