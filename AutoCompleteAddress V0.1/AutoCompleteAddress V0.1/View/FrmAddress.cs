using AutoCompleteAddress.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCompleteAddress.View
{
    public partial class FrmAddress : Form
    {
        private AddressDetails _addressDetail = new AddressDetails();
        private BindingList<AddressDetails> _adressDetailList = new BindingList<AddressDetails>();

        public FrmAddress()
        {
            InitializeComponent();
            this.txtNum.DataBindings.Add("Text", _addressDetail, "Num");
            this.txtStreet.DataBindings.Add("Text", _addressDetail, "Street");
            this.txtCity.DataBindings.Add("Text", _addressDetail, "City");
            this.txtState.DataBindings.Add("Text", _addressDetail, "State");
            this.txtZipCode.DataBindings.Add("Text", _addressDetail, "ZipCode");
            this.txtCountry.DataBindings.Add("Text", _addressDetail, "Country");

            AddressGridView.DataSource = _adressDetailList;
        }
        private async void txtUserInput_KeyUp(object sender, KeyEventArgs e)
        {
            //requesting data from google Address AutoComplete Api, reciving a object of AddressPrediction with details
            var fullAdreesPredictionResult = await Task.Run(() => AddressPredictions.GetAddressPerdictions(txtUserInput.Text));
            if (fullAdreesPredictionResult.Predictions.Count() > 0)
            {
                //selecting the Description (the formatted address string)
                var addressPredictionResult = fullAdreesPredictionResult.Predictions.Select(s => s.Description).ToArray();

                //Clering the old results
                listBoxPredictionResults.Items.Clear();

                addressPredictionResult.ToList().ForEach(a => listBoxPredictionResults.Items.Add(a));
                listBoxPredictionResults.Visible = true;
            }
        }

        //setting focus to listBox to be able to navigate
        private void txtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBoxPredictionResults.Focus();
                listBoxPredictionResults.SelectedIndex = 0;
            }
        }
        //selecting address with mouse clicks
        private void listBoxPredictionResults_MouseUp(object sender, MouseEventArgs e)
        {
            GetAddressDetails(sender);
        }
        //selecting address with button clicks
        private void listBoxPredictionResults_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab) { GetAddressDetails(sender); }
            }
        }
        //Getting the address Details
        //TODO Make this Async,
        //for now i have a problem becuse the propertychange is updating the textBoxes which is in another thread
        private  void GetAddressDetails(object sender)
        {
            var selectedAddress = ((ListBox)sender).SelectedItem as string;
            this._addressDetail = AddressDetails.GetAddress(selectedAddress, _addressDetail);


            txtUserInput.Text = selectedAddress;
            listBoxPredictionResults.Visible = false;

            InsertIntoTable(_addressDetail);
        }

        private void InsertIntoTable(AddressDetails addressDetail)
        {
            AddressDetails addresssDetailToInsert = new AddressDetails();
            addresssDetailToInsert = (AddressDetails)addressDetail.Clone();
            _adressDetailList.Add(addresssDetailToInsert);

            txtUserInput.Focus();
        }
    }
}
