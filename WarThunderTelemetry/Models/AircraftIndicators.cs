using System.Text.Json.Serialization;

namespace WarThunderTelemetry.Models;

public class AircraftIndicators
{
    [JsonPropertyName("valid")]
    public bool Valid { get; set; }

    [JsonPropertyName("army")]
    public string? Army { get; set; }

    [JsonPropertyName("type")]
    public string? AircraftType { get; set; }

    [JsonPropertyName("speed")]
    public double Speed { get; set; }

    [JsonPropertyName("altitude_hour")]
    public double Altitude { get; set; }

    [JsonPropertyName("manifold_pressure")]
    public double ManifoldPressure { get; set; }

    [JsonPropertyName("rpm")]
    public double RPM { get; set; }

    [JsonPropertyName("water_temperature")]
    public double WaterTemperature { get; set; }

    [JsonPropertyName("oil_pressure")]
    public double OilPressure { get; set; }

    [JsonPropertyName("fuel")]
    public double Fuel { get; set; }

    [JsonPropertyName("throttle")]
    public double Throttle { get; set; }

    [JsonPropertyName("prop_pitch_hour")]
    public double PropellerPitch { get; set; }
}