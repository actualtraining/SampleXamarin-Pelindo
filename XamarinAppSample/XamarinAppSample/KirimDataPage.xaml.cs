using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinAppSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KirimDataPage : ContentPage
	{
		public KirimDataPage ()
		{
			InitializeComponent();

            btnKirimData.Clicked += BtnKirimData_Clicked;
		}

        private void BtnKirimData_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerimaDataPage(txtUsername.Text));
        }
    }
}