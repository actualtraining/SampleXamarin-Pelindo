using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAppSample.Models;

namespace XamarinAppSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListBerita : ContentPage
	{
		public ListBerita ()
		{
			InitializeComponent();

            List<Berita> lstBerita = new List<Berita>()
            {
                new Berita {Judul="Memulai Startup Bisnis",
                    Keterangan = "Berita berisi bagaimana memulai startup bisnis dan membuat valuasi awal" },
                new Berita {Judul="Xamarin for Android",
                    Keterangan="Xamarin for Android digunakan jika anda menginginkan tampilan yang sangat flexible menggunakan native xml android"},
                new Berita {Judul="Xamarin Forms",Keterangan="Xamarin Forms digunakan untuk membuat aplikasi dengan 100% code sharing di C#"}
            };

            listBerita.ItemsSource = lstBerita;

            listBerita.ItemTapped += (object sender, ItemTappedEventArgs e) =>
            {
                Berita currBerita = e.Item as Berita;
                DisplayAlert("Keterangan", "Judul " + currBerita.Judul, "OK");
            };
        }

        
    }
}