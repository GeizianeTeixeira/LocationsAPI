using System.Text.Json.Serialization;

namespace LocationsAPI.Models.OceanModels;

public class WaveModel
{
    [JsonPropertyName("data")]
    public string Data { get; set; }

    [JsonPropertyName("dados_ondas")]
    public List<OceanPrevisionModel> WaveData { get; set; }
}
