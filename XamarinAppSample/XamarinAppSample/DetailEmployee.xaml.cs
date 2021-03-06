﻿using System;
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
    public partial class DetailEmployee : ContentPage
    {
        private DataAccess dataAccess;
        public DetailEmployee()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        private void btnEdit_Clicked(object sender, EventArgs e)
        {
            Employee currEmployee = (Employee)this.BindingContext;
            try
            {
                dataAccess.Update(currEmployee);
                Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                DisplayAlert("Kesalahan", "Error : " + ex.Message, "OK");
            }
        }

        private async void btnDelete_Clicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Konfirmasi", "Apakah anda yakin untuk delete data ini?", "Yes", "No");
            if (answer)
            {
                Employee currEmployee = (Employee)this.BindingContext;
                try
                {
                    dataAccess.Delete(currEmployee);
                    await Navigation.PopModalAsync();
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Kesalahan", "Error : " + ex.Message, "OK");
                }
            }
            else
            {
                await Navigation.PopModalAsync();
            }
        }
    }
}