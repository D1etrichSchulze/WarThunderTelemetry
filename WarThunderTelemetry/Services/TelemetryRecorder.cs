using WarThunderTelemetry.Models;

namespace WarThunderTelemetry.Services;

public class TelemetryRecorder
{
    private readonly string _filePath;

    public TelemetryRecorder(string filePath)
    {
        _filePath = filePath;

        string? directory = Path.GetDirectoryName(filePath);

        if (!string.IsNullOrEmpty(directory))
        {
            Directory.CreateDirectory(directory);
        }

        if (!File.Exists(_filePath))
        {
            File.WriteAllText(_filePath,
                "Timestamp,Aircraft,Altitude,IAS,TAS,Mach,AoA,AoS,GForce,VerticalSpeed," +
                "Aileron,Elevator,Rudder,Flaps,Throttle,RPM,Power,ManifoldPressure," +
                "WaterTemperature,OilTemperature,PropellerPitch,Thrust,Fuel\n");
        }
    }

    public void Record(AircraftState state, AircraftIndicators? indicators)
    {
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

        string aircraft = indicators?.AircraftType ?? "Unknown";

        string line =
            $"{timestamp}," +
            $"{aircraft}," +
            $"{state.Altitude}," +
            $"{state.IAS}," +
            $"{state.TAS}," +
            $"{state.Mach}," +
            $"{state.AoA}," +
            $"{state.AoS}," +
            $"{state.GForce}," +
            $"{state.VerticalSpeed}," +
            $"{state.Aileron}," +
            $"{state.Elevator}," +
            $"{state.Rudder}," +
            $"{state.Flaps}," +
            $"{state.Throttle}," +
            $"{state.RPM}," +
            $"{state.Power}," +
            $"{state.ManifoldPressure}," +
            $"{state.WaterTemperature}," +
            $"{state.OilTemperature}," +
            $"{state.PropellerPitch}," +
            $"{state.Thrust}," +
            $"{state.Fuel}\n";

        File.AppendAllText(_filePath, line);
    }
}