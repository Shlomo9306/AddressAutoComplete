using Newtonsoft.Json;

namespace AutoCompleteAddress.Model
{
    public class Prediction
    {
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "matched_substrings")]
        public Matched_Substrings[] MatchedSubstrings { get; set; }

        [JsonProperty(PropertyName = "place_id")]
        public string Place_id { get; set; }

        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; }

        [JsonProperty(PropertyName = "structured_formatting")]
        public Structured_Formatting StructuredFormatting { get; set; }

        [JsonProperty(PropertyName = "terms")]
        public Term[] Terms { get; set; }

        [JsonProperty(PropertyName = "types")]
        public string[] Types { get; set; }
    }

}
