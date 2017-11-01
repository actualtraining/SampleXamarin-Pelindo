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
	public partial class TerimaDataPage : ContentPage
	{
		public TerimaDataPage()
		{
			InitializeComponent ();
		}

        private string username;
        public TerimaDataPage(string username)
        {
            InitializeComponent();
            this.username = username;

            lblKeterangan.Text = "Username anda : " + this.username;
        }
	}
}