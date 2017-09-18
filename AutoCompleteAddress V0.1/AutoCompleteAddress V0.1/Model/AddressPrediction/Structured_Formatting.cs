using Newtonsoft.Json;

namespace AutoCompleteAddress.Model
{
    public class Structured_Formatting
    {
        [JsonProperty(PropertyName = "main_text")]
        public string MainText { get; set; }

        [JsonProperty(PropertyName = "main_text_matched_substrings")]
        public Main_Text_Matched_Substrings[] MainTextMatchedSubstrings { get; set; }

        [JsonProperty(PropertyName = "secondary_text")]
        public string Secondary_text { get; set; }
    }

}
