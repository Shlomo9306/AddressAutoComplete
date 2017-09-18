using Newtonsoft.Json;

namespace AutoCompleteAddress.Model
{
    public class AddressPrediction
    {
        [JsonProperty(PropertyName = "predictions")]
        public Prediction[] Predictions { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }

}
