using LocationsAPI.Models.Climate;
using System.Security.Claims;
using System.Text.Json.Serialization;

namespace LocationsAPI.Models
{
    public class CityClimateModel
    {
        [JsonPropertyName("cidade")]
        public string City { get; set; }

        [JsonPropertyName("estado")]
        public string State { get; set; }

        [JsonPropertyName("atualizado_em")]
        public string Updated { get; set; }

        [JsonPropertyName("clima")]
        public List<ClimateModel> Climate { get; set; }

    }
}
