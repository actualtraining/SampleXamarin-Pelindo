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

            datePicker.DateSelected += (object sender, DateChangedEventArgs e) =>
            {
                eventValue.Text = e.NewDate.ToString();
                pageValue.Text = datePicker.Date.ToString();
            };

            timePicker.PropertyChanged += TimePicker_PropertyChanged;
            stepper.ValueChanged += Stepper_ValueChanged;

            switcher.Toggled += Switcher_Toggled;
        }

        private void Switcher_Toggled(object sender, ToggledEventArgs e)
        {
            eventValue.Text = string.Format("Nilai switch : {0}", e.Value);
            pageValue.Text = switcher.IsToggled.ToString();
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            eventValue.Text = String.Format("Stepper value is {0:F1}", e.NewValue);
            pageValue.Text = stepper.Value.ToString();
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                pageValue.Text = timePicker.Time.ToString();
            }
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
