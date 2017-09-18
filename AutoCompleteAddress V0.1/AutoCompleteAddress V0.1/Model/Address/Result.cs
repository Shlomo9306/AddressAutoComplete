using Newtonsoft.Json;

namespace AutoCompleteAddress.Model
{
    public class Result
    {
        [JsonProperty(PropertyName = "address_components")]
        public AddressComponents[] AddressDetails { get; set; }
        public string formatted_address { get; set; }
       // public Geometry geometry { get; set; }
        public string place_id { get; set; }
        public string[] types { get; set; }
    }

}