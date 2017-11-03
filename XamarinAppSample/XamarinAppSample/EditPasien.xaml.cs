using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAppSample.Models;
using XamarinAppSample.Services;

namespace XamarinAppSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditPasien : ContentPage
	{
        private PasienService pasienService;
        public EditPasien()
		{
			InitializeComponent();
            pasienService = new PasienService();
		}

        private async void btnEdit_Clicked(object sender, EventArgs e)
        {
            var currPasien = (Pasien)this.BindingContext;
            try
            {
                await pasienService.Update(currPasien);
                await Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Kesalahan", "Ditemukan kesalahan : " + ex.Message, "OK");
            }
        }
    }
}