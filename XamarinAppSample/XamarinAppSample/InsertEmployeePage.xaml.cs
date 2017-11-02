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
    public partial class InsertEmployeePage : ContentPage
    {
        private DataAccess dataAccess;
        public InsertEmployeePage()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            var newEmployee = new Employee
            {
                EmpName = txtNama.Text,
                Department = txtDepartment.Text,
                Qualification = txtQualification.Text
            };

            try
            {
                dataAccess.Insert(newEmployee);
                Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                DisplayAlert("Kesalahan", "Error: " + ex.Message,"OK");
            }
        }
    }
}