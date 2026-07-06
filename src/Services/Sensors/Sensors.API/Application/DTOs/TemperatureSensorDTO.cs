namespace Sensors.API.Application.DTOs;

public class TemperatureSensorDTO
{
    public Guid Id { get; set; }
    public required string Room { get; set; } = "";
    public decimal Temperature { get; set; }
}