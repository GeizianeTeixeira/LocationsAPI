using System.Text.Json.Serialization;

namespace LocationsAPI.Dtos
{
    public class City
    {
        
            [JsonPropertyName("nome")]
            public string name { get; set; }

            [JsonPropertyName("estado")]
            public string state { get; set; }

            [JsonPropertyName("id")]
            public int id { get; set; }
        
    }
}
