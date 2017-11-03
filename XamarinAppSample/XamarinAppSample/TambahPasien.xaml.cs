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
	public partial class TambahPasien : ContentPage
	{
        private PasienService pasienService;
        public TambahPasien ()
		{
			InitializeComponent ();
            pasienService = new PasienService();
		}

        private async void btnTambah_Clicked(object sender, EventArgs e)
        {
            try
            {
                var newPasien = new Pasien
                {
                    Nama = txtNama.Text,
                    Alamat = txtAlamat.Text,
                    Telpon = txtTelpon.Text,
                    Umur = Convert.ToInt32(txtUmur.Text)
                };

                await pasienService.Insert(newPasien);
                await Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Kesalahan", "Ditemukan kesalahan : " + ex.Message,"OK");
            }
        }
    }
}