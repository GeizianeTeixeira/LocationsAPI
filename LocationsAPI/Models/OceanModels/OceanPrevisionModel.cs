using System.Text.Json.Serialization;

namespace LocationsAPI.Models.OceanModels;

public class OceanPrevisionModel
{

    [JsonPropertyName("vento")]
    public double Wind { get; set; }

    [JsonPropertyName("direcao_vento")]
    public string WindDirection { get; set; }

    [JsonPropertyName("direcao_vento_desc")]
    public string WindDirectionDesc { get; set; }

    [JsonPropertyName("altura_onda")]
    public double Waveheight { get; set; }

    [JsonPropertyName("direcao_onda")]
    public string WaveDirection { get; set; }

    [JsonPropertyName("direcao_onda_desc")]
    public string WaveDirectionDesc { get; set; }

    [JsonPropertyName("agitacao")]
    public string Agitation { get; set; }

    [JsonPropertyName("hora")]
    public string Time { get; set; }

}
