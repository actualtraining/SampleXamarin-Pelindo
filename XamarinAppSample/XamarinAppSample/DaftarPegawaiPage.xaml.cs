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
    public partial class DaftarPegawaiPage : ContentPage
    {
        private List<Pegawai> dataPegawai;
        public DaftarPegawaiPage()
        {
            InitializeComponent();

            dataPegawai = new List<Pegawai>
            {
                new Pegawai {Nip="998877",Nama="Chris Riedfield",Email="chris@umbrella.com",Pic="photo1.png"},
                new Pegawai {Nip="889977",Nama="Jill Valentine",Email="jill@umbrella.com",Pic="photo2.png"},
                new Pegawai {Nip="776655",Nama="Claire Riedfield",Email="claire@umbrella.com",Pic="photo3.png"}
            };

            pegawaiList.ItemsSource = dataPegawai;

            pegawaiList.ItemTapped += PegawaiList_ItemTapped;
        }

        private void PegawaiList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Pegawai currPegawai = e.Item as Pegawai;
            DisplayAlert("Keterangan", "Anda memilih data pegawai " + currPegawai.Nama,"OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}