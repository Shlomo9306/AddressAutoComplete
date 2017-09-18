using AutoCompleteAddress.HelperMethods;
using AutoCompleteAddress.Model;
using AutoCompleteAddress.Model.RequestReocrds;
using System;
using System.Linq;

namespace AutoCompleteAddress.ViewModel
{
    public class AddressDetails : BaseViewModel, ICloneable
    {

        private int? _huseNumber = null;
        private string _street;
        private string _city;
        private string _state;
        private string _zipCode;
        private string _country;


        public int? Num
        {
            get { return this._huseNumber; }
            set
            {
                if (_huseNumber == value) return;

                _huseNumber = value;
                OnPropertyChanged();

            }
        }
        public string Street
        {
            get { return _street; }
            set
            {
                if (_street == value) return;

                _street = value;
                OnPropertyChanged();
            }
        }
        public string City
        {
            get { return _city; }
            set
            {
                if (_city == value) return;

                _city = value;
                OnPropertyChanged();
            }
        }
        public string State
        {
            get { return _state; }
            set
            {
                if (_state == value) return;

                _state = value;
                OnPropertyChanged();
            }
        }
        public string ZipCode
        {
            get { return _zipCode; }
            set
            {
                if (_zipCode == value) return;

                _zipCode = value;
                OnPropertyChanged();
            }
        }
        public string Country
        {
            get { return _country; }
            set
            {
                if (_country == value) return;

                _country = value;
                OnPropertyChanged();
            }
        }
        public static AddressDetails GetAddress(string address, AddressDetails addressDetails)
        {
            if (address != null)
            {
                var adr = RequestAddress.GetResult<Address>(address, urlList.Places);
                var addressComponents = adr.Results[0].AddressDetails;


                addressDetails.Num = Parsing.TryParseNullable(addressComponents.Where(a => a.Types.Contains("street_number")).Select(ad => ad.LongName).SingleOrDefault());
                addressDetails.Street = addressComponents.Where(a => a.Types.Contains("route")).Select(ad => ad.LongName).SingleOrDefault();
                addressDetails.City = addressComponents.Where(a => a.Types.Contains("locality")).Select(ad => ad.LongName).SingleOrDefault();
                addressDetails.State = addressComponents.Where(a => a.Types.Contains("state") || a.Types.Contains("administrative_area_level_1")).Select(ad => ad.LongName).SingleOrDefault();
                addressDetails.Country = addressComponents.Where(a => a.Types.Contains("country")).Select(ad => ad.LongName).SingleOrDefault();
                addressDetails.ZipCode = addressComponents.Where(a => a.Types.Contains("postal_code")).Select(ad => ad.LongName).SingleOrDefault();
            }
            return addressDetails;
        }


        //to create copy of object
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
