using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinAppSample.Models;

namespace XamarinAppSample.ViewModel
{
    public class DataPegawaiViewModel : BindableObject
    {
        private ObservableCollection<Pegawai> listPegawai;      
        public ObservableCollection<Pegawai> ListPegawai
        {
            get { return listPegawai; }
            set { listPegawai = value; OnPropertyChanged("ListPegawai"); }
        }

        public DataPegawaiViewModel()
        {
            var listData = new List<Pegawai>
            {
                new Pegawai {Nip="998877",Nama="Chris Riedfield",Email="chris@umbrella.com",Pic="photo1.png"},
                new Pegawai {Nip="889977",Nama="Jill Valentine",Email="jill@umbrella.com",Pic="photo2.png"},
                new Pegawai {Nip="776655",Nama="Claire Riedfield",Email="claire@umbrella.com",Pic="photo3.png"}
            };
            ListPegawai = new ObservableCollection<Pegawai>(listData);

            MessagingCenter.Subscribe<Pegawai>(this, "EditRequested", (sender) =>
            {
                var data = (Pegawai)sender;
                data.Nama = data.Nama + " - Edited";
            });

            MessagingCenter.Subscribe<Pegawai>(this, "DeleteRequested", (sender) =>
            {
                var delPegawai = (Pegawai)sender;
                ListPegawai.Remove(delPegawai);
            });
        }
    }
}
