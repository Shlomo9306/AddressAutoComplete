using Newtonsoft.Json;

namespace AutoCompleteAddress.Model
{
    public class Main_Text_Matched_Substrings
    {
        [JsonProperty(PropertyName = "length")]
        public int Length { get; set; }
        [JsonProperty(PropertyName = "offset")]
        public int Offset { get; set; }
    }

}
