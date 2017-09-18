namespace AutoCompleteAddress.Model.RequestReocrds
{
    public static class urlList
    {
        public const string apiKey = "AIzaSyCAlKmGGJ-KUn3gXWzbqzNhZziA7Vdm5WM";
        public const string AddressPerdictions = @"https://maps.googleapis.com/maps/api/place/autocomplete/json?input={0}&key=" + apiKey;
        public const string Places = @"https://maps.googleapis.com/maps/api/geocode/json?address={0},&key=" + apiKey;

    }
}
