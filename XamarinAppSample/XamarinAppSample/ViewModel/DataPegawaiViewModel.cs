using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinAppSample.Models;

namespace XamarinAppSample.ViewModel
{
    public class DataPegawaiViewModel : BindableObject
    {
        private List<Pegawai> listPegawai;      
        public List<Pegawai> ListPegawai
        {
            get { return listPegawai; }
            set { listPegawai = value; OnPropertyChanged("ListPegawai"); }
        }

        public DataPegawaiViewModel()
        {
            ListPegawai = new List<Pegawai>
            {
                new Pegawai {Nip="998877",Nama="Chris Riedfield",Email="chris@umbrella.com",Pic="photo1.png"},
                new Pegawai {Nip="889977",Nama="Jill Valentine",Email="jill@umbrella.com",Pic="photo2.png"},
                new Pegawai {Nip="776655",Nama="Claire Riedfield",Email="claire@umbrella.com",Pic="photo3.png"}
            };
        }

    }
}
