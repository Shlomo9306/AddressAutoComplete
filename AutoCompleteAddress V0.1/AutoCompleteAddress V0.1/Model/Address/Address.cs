
using Newtonsoft.Json;

namespace AutoCompleteAddress.Model
{
    public class Address
    {
        [JsonProperty(PropertyName = "results")]
        public Result[] Results { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }

}