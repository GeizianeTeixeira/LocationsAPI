using System.Text.Json.Serialization;

namespace LocationsAPI.Models.Climate
{
    public class AirportCapClimateModel
    {
        [JsonPropertyName("codigo_icao")]
        public string IcaoCode { get; set; }

        [JsonPropertyName("atualizado_em")]
        public DateTime Updated { get; set; }

        [JsonPropertyName("pressao_atmosferica")]
        public string AtmosphericPressure { get; set; }

        [JsonPropertyName("visibilidade")]
        public string Visibility { get; set; }

        [JsonPropertyName("vento")]
        public int Wind { get; set; }

        [JsonPropertyName("direcao_vento")]
        public int WindDirection { get; set; }

        [JsonPropertyName("umidade")]
        public int Moisture { get; set; }

        [JsonPropertyName("condicao")]
        public string Condition { get; set; }

        [JsonPropertyName("condicao_Desc")]
        public string ConditionDesc { get; set; }

        [JsonPropertyName("temp")]
        public int Temperature { get; set; }
    }
}
