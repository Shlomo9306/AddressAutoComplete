using Newtonsoft.Json;

namespace AutoCompleteAddress.Model
{
    public class Term
    {
        [JsonProperty(PropertyName = "offset")]
        public int Offset { get; set; }
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }

}
