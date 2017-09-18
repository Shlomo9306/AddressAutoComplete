using Newtonsoft.Json;

namespace AutoCompleteAddress.Model
{
    class DescriptionTerm
    {
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "terms")]
        public Term[] Terms { get; set; }
    }

}
