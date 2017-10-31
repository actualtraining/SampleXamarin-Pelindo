using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinAppSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnAdd.Clicked += BtnAdd_Clicked;

            //sample picker
            var options = new List<string> { "Satu", "Dua", "Tiga", "Empat", "Lima" };
            foreach(var option in options)
            {
                picker.Items.Add(option);
            }

            picker.SelectedIndexChanged += (sender, args) =>
            {
                DisplayAlert("Keterangan","Anda memilih " + picker.Items[picker.SelectedIndex],"OK");
            };
        }

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Pesan", "Hallo " + txtHello.Text, "OK");
        }

        private void btnHello_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Hello", "Hello World", "OK");
        }
    }
}
