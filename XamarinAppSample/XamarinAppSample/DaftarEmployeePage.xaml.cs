using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAppSample.Data;
using XamarinAppSample.Models;

namespace XamarinAppSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DaftarEmployeePage : ContentPage
    {
        private DataAccess dataAccess;
        public DaftarEmployeePage()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        protected override void OnAppearing()
        {
            var data = dataAccess.GetAll();
            myListView.ItemsSource = data;
        }

        private void menuTambah_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new InsertEmployeePage());
        }
    }
}