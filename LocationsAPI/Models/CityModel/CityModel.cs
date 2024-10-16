using System.Text.Json.Serialization;

namespace LocationsAPI.Models.CityModel;

public class CityModel
{
    [JsonPropertyName("nome")]
    public string Name { get; set; }

    [JsonPropertyName("estado")]
    public string State { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
