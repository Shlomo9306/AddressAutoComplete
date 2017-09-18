using AutoCompleteAddress.Model;
using AutoCompleteAddress.Model.RequestReocrds;

namespace AutoCompleteAddress.ViewModel
{
    public static class AddressPredictions
    {
        public static AddressPrediction GetAddressPerdictions(string partialAddress)
        {
            return RequestAddress.GetResult<AddressPrediction>(partialAddress, urlList.AddressPerdictions);

        }
    }
}
