using System.Text.Json.Serialization;

namespace LocationsAPI.Models.OceanModels
{
    public class Waves_Model
    {
        [JsonPropertyName("cidade")]
        public string City { get; set; }

        [JsonPropertyName("estado")]
        public string State { get; set; }

        [JsonPropertyName("atualizado_em")]
        public string Updated { get; set; }

        [JsonPropertyName("ondas")]
        public List<WaveModel> Waves { get; set; }
    }
}
