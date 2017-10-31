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
	public partial class ContohSimpleList : ContentPage
	{
		public ContohSimpleList ()
		{
			InitializeComponent ();

            List<string> items = new List<string> { "Monitor LG 32 inch","Keyboard Logitech","Memory Visipro 8GB",
                "Mouse Logitech X1","Monitor Samsung 43 inch"};
            myList.ItemsSource = items;

            myList.ItemTapped += MyList_ItemTapped;
		}

        private void MyList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Pilihan", "Anda memilih data " + e.Item.ToString(), "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}