using WarThunderTelemetry.Models;
using WarThunderTelemetry.Services;

namespace WarThunderTelemetry;

class Program
{
    public static async Task Main(string[] args)
    {
        
        Console.WriteLine("War Thunder Telemetry Logger");
        Console.WriteLine("-----------------------------");

        WarThunderApi api = new WarThunderApi();

        string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HHmmss");

        string filePath =
            Path.Combine(
                "Data",
                "Flights",
                $"Flight_{timestamp}.csv");

        TelemetryRecorder recorder = new TelemetryRecorder(filePath);

        Console.WriteLine($"Recording to: {filePath}");
        Console.WriteLine("Press Ctrl+C to stop.");
        Console.WriteLine();

        while (true)
        {
            AircraftState? state = await api.GetStateAsync();

            if (state != null && state.Valid)
            {
                AircraftIndicators? indicators =
                    await api.GetIndicatorsAsync();

                recorder.Record(state, indicators);

                Console.WriteLine(
                    $"IAS: {state.IAS,5:F0} km/h | " +
                    $"Alt: {state.Altitude,6:F0} m | " +
                    $"AoA: {state.AoA,5:F1}° | " +
                    $"G: {state.GForce,4:F2} | " +
                    $"RPM: {state.RPM,5:F0} | " +
                    $"Power: {state.Power,6:F0} hp");
            }
            else
            {
                Console.WriteLine("Waiting for War Thunder telemetry...");
            }

            await Task.Delay(100);
        }
    }
}
