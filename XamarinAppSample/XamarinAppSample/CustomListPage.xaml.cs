using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAppSample.Models;
using XamarinAppSample.ViewModel;

namespace XamarinAppSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomListPage : ContentPage
    {
        public CustomListPage()
        {
            InitializeComponent();

            BindingContext = new DataPegawaiViewModel();

            btnListBerita.Clicked += BtnListBerita_Clicked;
            btnMain.Clicked += (object sender, EventArgs e) =>
            {
                Navigation.PopAsync();
            };

            myListBerita.ItemTapped += (object sender, ItemTappedEventArgs e) =>
            {
                var currPegawai = (Pegawai)e.Item;
                DetailPegawai detailPage = new DetailPegawai();
                detailPage.BindingContext = currPegawai;
                ((ListView)sender).SelectedItem = null;

                Navigation.PushModalAsync(detailPage);
            };
        }

        private void Navigate(object sender, EventArgs e)
        {
            string type = (string)((ToolbarItem)sender).CommandParameter;
            Type pageType = Type.GetType("XamarinAppSample." + type + ", XamarinAppSample");
            Page page = (Page)Activator.CreateInstance(pageType);
            Navigation.PushAsync(page);
        }

        private void BtnListBerita_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListBerita());
        }
    }
}