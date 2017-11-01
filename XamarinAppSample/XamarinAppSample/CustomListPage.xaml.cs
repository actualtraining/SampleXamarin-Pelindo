using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
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
        }
    }
}