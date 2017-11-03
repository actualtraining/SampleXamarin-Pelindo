using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinAppSample.Services;
using XamarinAppSample.Models;

namespace XamarinAppSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DaftarPasien : ContentPage
    {
        private PasienService pasienService;
        public DaftarPasien()
        {
            InitializeComponent();
            pasienService = new PasienService();

            myListPasien.ItemTapped += MyListPasien_ItemTapped;
        }

        private async void MyListPasien_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var currPasien = (Pasien)e.Item;
            EditPasien editPasien = new EditPasien();
            editPasien.BindingContext = currPasien;
            await Navigation.PushModalAsync(editPasien);
            ((ListView)sender).SelectedItem = null;
        }

        protected async override void OnAppearing()
        {
            var data = await pasienService.GetAll();
            myListPasien.ItemsSource = data;
            myIndicator.IsRunning = false;
            myIndicator.IsVisible = false;
        }

        private void menuTambah_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TambahPasien());
        }

        private void myListPasien_Refreshing(object sender, EventArgs e)
        {
            OnAppearing();
            myListPasien.IsRefreshing = false;
        }
    }
}