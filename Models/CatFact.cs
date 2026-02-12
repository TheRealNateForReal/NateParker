namespace NateParker.Models
{
    using Newtonsoft.Json;

    public class CatFact
    {
        [JsonProperty("fact")]
        public string? Fact { get; set; }

        // Length of fact string
        [JsonProperty("length")]
        public int Length { get; set; }
    }
}
