using System.Text.Json.Serialization;

namespace LocationsAPI.Models.Climate;

public class ClimateModel
{
    [JsonPropertyName("data")]
    public string data { get; set; }

    [JsonPropertyName("condicao")]
    public string condicao { get; set; }

    [JsonPropertyName("min")]
    public int min { get; set; }

    [JsonPropertyName("max")]
    public int max { get; set; }

    [JsonPropertyName("indice_uv")]
    public int indice_uv { get; set; }

    [JsonPropertyName("condicao_desc")]
    public string condicao_desc { get; set; }
}
