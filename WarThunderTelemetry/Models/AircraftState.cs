using System.Text.Json.Serialization;

namespace WarThunderTelemetry.Models;

public class AircraftState
{
    [JsonPropertyName("valid")]
    public bool Valid { get; set; }

    [JsonPropertyName("aileron, %")]
    public double Aileron { get; set; }

    [JsonPropertyName("elevator, %")]
    public double Elevator { get; set; }

    [JsonPropertyName("rudder, %")]
    public double Rudder { get; set; }

    [JsonPropertyName("flaps, %")]
    public double Flaps { get; set; }

    [JsonPropertyName("gear, %")]
    public double Gear { get; set; }

    [JsonPropertyName("H, m")]
    public double Altitude { get; set; }

    [JsonPropertyName("TAS, km/h")]
    public double TAS { get; set; }

    [JsonPropertyName("IAS, km/h")]
    public double IAS { get; set; }

    [JsonPropertyName("M")]
    public double Mach { get; set; }

    [JsonPropertyName("AoA, deg")]
    public double AoA { get; set; }

    [JsonPropertyName("AoS, deg")]
    public double AoS { get; set; }

    [JsonPropertyName("Ny")]
    public double GForce { get; set; }

    [JsonPropertyName("Vy, m/s")]
    public double VerticalSpeed { get; set; }

    [JsonPropertyName("Wx, deg/s")]
    public double RollRate { get; set; }

    [JsonPropertyName("Mfuel, kg")]
    public double Fuel { get; set; }

    [JsonPropertyName("Mfuel0, kg")]
    public double InitialFuel { get; set; }

    [JsonPropertyName("throttle 1, %")]
    public double Throttle { get; set; }

    [JsonPropertyName("power 1, hp")]
    public double Power { get; set; }

    [JsonPropertyName("RPM 1")]
    public double RPM { get; set; }

    [JsonPropertyName("manifold pressure 1, atm")]
    public double ManifoldPressure { get; set; }

    [JsonPropertyName("water temp 1, C")]
    public double WaterTemperature { get; set; }

    [JsonPropertyName("oil temp 1, C")]
    public double OilTemperature { get; set; }

    [JsonPropertyName("pitch 1, deg")]
    public double PropellerPitch { get; set; }

    [JsonPropertyName("thrust 1, kgs")]
    public double Thrust { get; set; }

    [JsonPropertyName("efficiency 1, %")]
    public double EngineEfficiency { get; set; }
}