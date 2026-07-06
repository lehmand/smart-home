namespace Sensors.API.Domain.Entities;

public abstract class SensorBase
{
    public Guid Id { get; set; }
    public required string Room { get; set; } = "";
    public required string Type { get; set; }
}