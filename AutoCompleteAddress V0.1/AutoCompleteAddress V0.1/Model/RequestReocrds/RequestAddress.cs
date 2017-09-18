using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace AutoCompleteAddress.Model.RequestReocrds
{
    public static class RequestAddress
    {

        //requesting record from Google AutoComplete Api,
        //reciving back Json data,
        public static T GetResult<T>(string searchCriatrie, string requestFrom)
        {
            var url = CreateRequestURL_String(requestFrom, searchCriatrie);
            var response = ExecuteRequest(url);
            var jsonAddressList = "";
            T result;

            //converting to Json to address prediction Object   
            if (response != null)
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    jsonAddressList = reader.ReadToEnd();
                }
            }
            //TODO handle if jsonAddressList could not be converted to T
            //like if recived back from api that we are over the limit (google api is allowing for standert use only 1000 per day) 
            result = JsonConvert.DeserializeObject<T>(jsonAddressList);

            return result;
        }

        private static string CreateRequestURL_String(string addressPerdictions, string searchCriatrie)
        {
            var url = String.Format(addressPerdictions, searchCriatrie);
            return url;
        }
        private static HttpWebResponse ExecuteRequest(string url)
        {
            HttpWebResponse response = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException e)
            {
                System.Windows.Forms.MessageBox.Show("There was an error connecting to the google`s API... ");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return response;
        }
    }
}
