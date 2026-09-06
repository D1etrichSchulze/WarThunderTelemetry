using System.Text.Json;
using WarThunderTelemetry.Models;

namespace WarThunderTelemetry.Services;

public class WarThunderApi
{
    private readonly HttpClient _httpClient;

    private readonly JsonSerializerOptions _jsonOptions =
        new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

    public WarThunderApi()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:8111/")
        };
    }

    public async Task<AircraftState?> GetStateAsync()
    {
        try
        {
            string json = await _httpClient.GetStringAsync("state");

            return JsonSerializer.Deserialize<AircraftState>(
                json,
                _jsonOptions);
        }
        catch
        {
            return null;
        }
    }

    public async Task<AircraftIndicators?> GetIndicatorsAsync()
    {
        try
        {
            string json = await _httpClient.GetStringAsync("indicators");

            return JsonSerializer.Deserialize<AircraftIndicators>(
                json,
                _jsonOptions);
        }
        catch
        {
            return null;
        }
    }
}